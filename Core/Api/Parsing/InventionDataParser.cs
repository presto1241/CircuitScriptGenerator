/*
 * Filename: InventionDataParser.cs
 * Created Date: Tuesday, April 7th 2026, 11:19:08 pm
 * Author: Preston
 * 
 * Description: Attempt to load invention data.
 */

using System.IO.Compression;
using CircuitScriptGenerator.Core.Api.Logging;
using CircuitScriptGenerator.Core.Data;
using Google.Protobuf;
using RecRoom.Protobuf;
using RecRoom.Protobuf.Core;

namespace CircuitScriptGenerator.Core.Api.Parsing;

[DataParser]
public class InventionDataParser : IDataParser
{
    // @todo: Read the raw room byte array and seperate room data from circuits data. 
    public bool TryParseData(ZipArchive archive, out List<Graph>? graphs)
    {
        graphs = null;

        ZipArchiveEntry? zipArchiveEntry = null;
        try
        {
            zipArchiveEntry = archive.GetEntry("spawnable_template_data.binpb");
        }
        catch (Exception e)
        {
            Logger.Log("InventionDataParser", "Unable to load \"spawnable_template_data.binpb\" " + e.Message, LogLevel.Warn);
            return false;
        }

        if (zipArchiveEntry == null) return false;
        Stream data = zipArchiveEntry.Open();

        SpawnableTemplateData spawnableTemplateData = SpawnableTemplateData.Parser.ParseFrom(data);

        Logger.Log(
            "InventionDataParser", 
            "Successfully Loaded Invention! Circuits Version: " + (spawnableTemplateData.CircuitV2Data.Version), 
            LogLevel.Debug);

        //spawnableTemplateData.CircuitV2Data.Root.NodeDatas[2]
        for (int i = 0; i < spawnableTemplateData.CircuitV2Data.Root.NodeDatas.Count; i++)
        {
            //spawnableTemplateData.CircuitV2Data.Root.NodeDatas[i].
            //GuidData nodeId = spawnableTemplateData.CircuitV2Data.Root.NodeDatas[i].NodeId;
            //Logger.Log("InventionDataParser", $"Edge {i} is id: " +  nodeId);
            GuidData nodeType = spawnableTemplateData.CircuitV2Data.Root.NodeDatas[i].NodeType;
            Logger.Log("InventionDataParser", $"Node {i} is type: " +  nodeType);
        }
        return true;
    }
}
