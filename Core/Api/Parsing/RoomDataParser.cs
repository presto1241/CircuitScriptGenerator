/*
 * Filename: RoomDataParser.cs
 * Created Date: Sunday, April 5th 2026, 12:35:36 am
 * Author: Preston
 * 
 * Description: 
 */
using System.Diagnostics;
using System.IO.Compression;
using CircuitScriptGenerator.Core.Api.Json;
using CircuitScriptGenerator.Core.Api.Json.Data;
using CircuitScriptGenerator.Core.Api.Logging;
using CircuitScriptGenerator.Core.Api.Parsing.Data;
using CircuitScriptGenerator.Core.Data;
using RecRoom.Protobuf;

namespace CircuitScriptGenerator.Core.Api.Parsing;

[DataParser]
public class RoomDataParser : IDataParser
{
    // @todo: Read the raw room byte array and seperate room data from circuits data. 
    public bool TryParseData(ZipArchive archive, out List<Graph>? graphs)   
    {
        graphs = null;

        Logger.Log("RoomDataParser", "All file entries\n" + string.Join("", archive.Entries.Select(e => "    - " + e.FullName + "\n")));

        var subRooms = archive.Entries.Where(e => e.FullName.Contains("persisted_room_data.binpb"));

        foreach (var room in subRooms)
        {
            Logger.Log("RoomDataParser", "Loading subroom: " + room.FullName);
            LoadSubroom(archive, room.FullName);
        }

        return true;
    }

    private List<Graph>? LoadSubroom(ZipArchive archive, string folderName)
    {
        List<Graph>? graphs = null;
        ZipArchiveEntry? zipArchiveEntry = null;

        try
        {
            zipArchiveEntry = archive.GetEntry(folderName);
        }
        catch (Exception e)
        {
            Logger.Log("RoomDataParser", "Unable to load \"persisted_room_data.binpb\" " + e.Message, LogLevel.Warn);
            return null;
        }
        
        if (zipArchiveEntry == null) return null;
        Stream data = zipArchiveEntry.Open();
        PersistedRoomData roomData = PersistedRoomData.Parser.ParseFrom(data);
        Dictionary<string, CircuitsCsv> csvData = Utils.LoadCsv(
            folderName.Replace("persisted_room_data.binpb", ""), archive);

        Logger.Log("RoomDataParser", $"Subroom {roomData.SubRoomId} has {roomData.CircuitV2Data.Root.NodeDatas.Count} nodes");

        /*
        Logger.Log("RoomDataParser", 
            $"Subroom {roomData.SubRoomId} csv nodes:\n{string.Join("", csvData.Values.Select(v => $"    - {v.Base64Guid} | {v.Guid} | {v.Type}\n"))}");
        */
        List<string> allFoundTypes = new();
        
        foreach (var val in CircuitsJsonLoader.Nodes.Values)
        {
            foreach (var desc in val.NodeDescs[0].Inputs)
            {
                foreach (var type in Utils.GetNodeTypes(desc.ReadonlyType))
                {
                    if (allFoundTypes.Contains(type)) continue;
                    allFoundTypes.Add(type);
                }
            }
            
            Logger.Log("RoomDataParser", "Chip: " + val.ChipNameSource);
        }

        try
        {
            Logger.Log("RoomDataParser", "Found this many unique types:\n" + string.Join("", allFoundTypes.Select(t => "    - " + t + "\n")));
        }
        catch (Exception e)
        {
            Logger.Log("RoomDataParser", $"{e.Message}");
        }

        data.Close();
        
        return graphs;
    }
}
