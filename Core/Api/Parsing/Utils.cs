/*
 * Filename: Utils.cs
 * Created Date: Thursday, April 9th 2026, 5:18:08 pm
 * Author: Preston
 * 
 * Descriptor: A utility class to parse and load graphs from config files.
 */

using System.IO.Compression;
using System.Numerics;
using System.Text.RegularExpressions;
using Circuits.Static.Api.Protobuf;
using CircuitScriptGenerator.Core.Api.Json;
using CircuitScriptGenerator.Core.Api.Json.Data;
using CircuitScriptGenerator.Core.Api.Logging;
using CircuitScriptGenerator.Core.Api.Parsing.Data;
using CircuitScriptGenerator.Core.Data;
using CircuitsV2.Protobuf;
using CsvHelper;
using Google.Protobuf;
using RecRoom.Protobuf.Core;

namespace CircuitScriptGenerator.Core.Api.Parsing;

public static class Utils
{
    private class NodePortBinding
    {
        public ByteString? Node;
        public GuidData SourcePort = new();
        public List<GuidData> DestinationPort = new();
    }

    public static List<Graph> GenerateGraphFromCircuitRootData(CircuitTemplateRootData rootData, Dictionary<string, CircuitsCsv> csvData)
    {
        List<Graph> graphs = new();
        List<Connection> connections = new();
        List<NodePortBinding> nodePortBindings = new();

        foreach (var edge in rootData.Root.Edges)
        {
            //edge.
        }

        for (int i = 0; i < rootData.Root.NodeDatas.Count; i++)
        {
            var node = rootData.Root.NodeDatas[i];
            List<StaticEdgeData> inputEdges = rootData.Root.Edges.Where(e => e.DstNodeId.Value == node.NodeId.Value).ToList();
            List<StaticEdgeData> outputEdges = rootData.Root.Edges.Where(e => e.SrcNodeId.Value == node.NodeId.Value).ToList();
            
            //GenerateNode(node, inputEdges, outputEdges);
            var base64guid = node.NodeType.Value.ToBase64();
            
            csvData.TryGetValue(base64guid, out CircuitsCsv? typeName);

            string logName = typeName == null ? base64guid : typeName.Type;

            Guid guid = new Guid(Convert.FromBase64String(base64guid));
            
            NodeMetadata nodeMetadata = CircuitsJsonLoader.Nodes[guid.ToString()];
        }

        return graphs;
    }

    /// <summary>
    /// Get the circuits csv file from the room. Returns a dictionary where the key is base64guid
    /// </summary>
    /// <param name="basePath"></param>
    /// <param name="archive"></param>
    /// <returns></returns>
    public static Dictionary<string, CircuitsCsv> LoadCsv(string basePath, ZipArchive archive)
    {
        Dictionary<string, CircuitsCsv> data = new();
        string path = basePath + "CV2NodeTypes.csv";

        
        ZipArchiveEntry? entry = null;
        try
        {
            entry = archive.GetEntry(path);
        }
        catch (Exception e)
        {
            Logger.Log("Utils", "Unable to load \"CV2NodeTypes.csv\" " + e.Message, LogLevel.Warn);
            return data;
        }

        if (entry == null) return data;
        StreamReader reader = new StreamReader(entry.Open());
        
        try
        {
            var csv = new CsvReader(reader, System.Globalization.CultureInfo.InvariantCulture);
            var records = csv.GetRecords<CircuitsCsv>();
            //reader.Close();

            foreach (var record in records)
            {
                //Logger.Log("Utils", $"Adding {record.Type} to circuits");
                data.Add(record.Base64Guid, record);
            }
        }
        catch (Exception e)
        {
            Logger.Log("Utils", $"Error parsing file: {e.Message}", LogLevel.Warn);
            return data;
        }

        return data;
    }

    public static Node GenerateNode(NodeMetadata nodeMetadata)
    {
        List<Port> inPorts = new();
        List<Port> outPorts = new();

        // First process inputs.
        foreach (var input in nodeMetadata.NodeDescs[0].Inputs)
        {
            Port? port = null;
            List<Type> foundTypes = new();
            //PortType portType = PortType.Value; 
            
            string[] types = Regex.Replace(input.ReadonlyType, @"[()\s]", "").Split("|");

            foreach (var type in types)
            {
                Type? nodeType = NodeGetType(type);
                if (nodeType == null) continue;
                //if ()
                foundTypes.Add(nodeType);
            }

            port = new Port(foundTypes, null, PortType.Value);
            inPorts.Add(port);
        }

        //Port port = new Port(port.Name, );
        return new Node("", 0, "", new Port[0], new Port[0]);
    }

    public static Type? NodeGetType(string type)
    {
        switch (type)
        {
            case "int": return typeof(int);
            case "float": return typeof(float);
            case "vector3": return typeof(Vector3);
            case "quaternion": return typeof(Quaternion);
        }

        return null;
    }

    public static string[] GetNodeTypes(string type)
    {
        return Regex.Replace(type, @"[()\s]", "").Split("|");
    }
}
