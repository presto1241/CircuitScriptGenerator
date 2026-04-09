/*
 * Filename: RoomDataParser.cs
 * Created Date: Sunday, April 5th 2026, 12:35:36 am
 * Author: Preston
 * 
 * Description: 
 */
using System.IO.Compression;
using CircuitScriptGenerator.Core.Api.Logging;
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

        Logger.Log("RoomDataParser", $"Subroom {roomData.SubRoomId} has {roomData.CircuitV2Data.Root.NodeDatas.Count} nodes");
        
        /*
        for (int i = 0; i < roomData.CircuitV2Data.Root.NodeDatas.Count; i++)
        {
            var node = roomData.CircuitV2Data.Root.NodeDatas[i];
            Logger.Log("RoomDataParser", $"Subroom {roomData.SubRoomId} : Loading node id {node.NodeId.Value}");
        }
        */
        
        return graphs;
    }
}
