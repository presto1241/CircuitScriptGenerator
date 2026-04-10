/*
 * Filename: GraphBuilder.cs
 * Created Date: Friday, April 10th 2026, 11:14:38 am
 * Author: Preston
 * 
 * Description: A class to help build graphs from node data
 */

using Circuits.Static.Api.Protobuf;
using Circuits.Static.Core.GraphSystem.Protobuf;
using CircuitScriptGenerator.Core.Api.Json;
using CircuitScriptGenerator.Core.Api.Json.Data;
using CircuitScriptGenerator.Core.Api.Parsing.Data;
using CircuitScriptGenerator.Core.Data;
using CircuitsV2.Protobuf;

namespace CircuitScriptGenerator.Core.Api.Parsing;

public static class GraphBuilder
{
    /// <summary>
    /// Builds graphs from room data
    /// </summary>
    /// <param name="circuitData"></param>
    /// <param name="csvData"></param>
    /// <returns></returns>
    public static List<Graph> Build(CircuitTemplateRootData circuitData, Dictionary<string, CircuitsCsv> csvData)
    {
        var root = circuitData.Root;
        var entities = circuitData.Entities;
        var graphEntities = entities.GraphEntities[0];


        // Build legacy graph ids
        var legacyIdToDefId = new Dictionary<string, int>();
        var legacyIds = graphEntities.LegacyNodeIds;
        var defIds = graphEntities.NodeDefIds;

        for (int i = 0; i < legacyIds.Count; i++)
        {
            string key = legacyIds[i].Value.ToBase64();
            legacyIdToDefId.Add(key, defIds[i]);
        }


        // Build legacy id to node data
        var legacyIdsToNodeData = new Dictionary<string, NodesData>();
        
        foreach (var edge in circuitData.Root.Edges)
        {
            //edge.
        }

        for (int i = 0; i < circuitData.Root.NodeDatas.Count; i++)
        {
            var node = circuitData.Root.NodeDatas[i];
            List<StaticEdgeData> inputEdges = circuitData.Root.Edges.Where(e => e.DstNodeId.Value == node.NodeId.Value).ToList();
            List<StaticEdgeData> outputEdges = circuitData.Root.Edges.Where(e => e.SrcNodeId.Value == node.NodeId.Value).ToList();
            
            //GenerateNode(node, inputEdges, outputEdges);
            var base64guid = node.NodeType.Value.ToBase64();
            
            csvData.TryGetValue(base64guid, out CircuitsCsv? typeName);

            string logName = typeName == null ? base64guid : typeName.Type;

            Guid guid = new Guid(Convert.FromBase64String(base64guid));
            
            NodeMetadata nodeMetadata = CircuitsJsonLoader.Nodes[guid.ToString()];
        }

        return new();
    }

}