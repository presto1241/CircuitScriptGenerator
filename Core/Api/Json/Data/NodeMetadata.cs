/*
 * Filename: NodeMetadata.cs
 * Created Date: Thursday, April 9th 2026, 6:23:52 pm
 * Author: Preston
 * 
 * Description: A class that contains all metadata about a cv2 chip.
 */

namespace CircuitScriptGenerator.Core.Api.Json.Data;
using System.Collections.Generic;
using Newtonsoft.Json;

public class NodesRoot
{
    [JsonProperty("Nodes")]
    public Dictionary<string, NodeMetadata> Nodes { get; set; } = new();
}

public class NodeMetadata
{
    [JsonProperty("ReadonlyPaletteName")]
    public string ReadonlyPaletteName { get; set; } = string.Empty;

    [JsonProperty("ReadonlyChipName")]
    public string ReadonlyChipName { get; set; } = string.Empty;

    [JsonProperty("Description")]
    public string Description { get; set; } = string.Empty;

    [JsonProperty("IsBetaChip")]
    public bool IsBetaChip { get; set; }

    [JsonProperty("IsValidInRoom1")]
    public bool IsValidInRoom1 { get; set; }

    [JsonProperty("IsValidInRoom2")]
    public bool IsValidInRoom2 { get; set; }

    [JsonProperty("IsTrollingRisk")]
    public bool IsTrollingRisk { get; set; }

    [JsonProperty("IsRoleAssignmentRisk")]
    public bool IsRoleAssignmentRisk { get; set; }

    [JsonProperty("DeprecationStage")]
    public string DeprecationStage { get; set; } = string.Empty;

    [JsonProperty("PaletteNameSource")]
    public string PaletteNameSource { get; set; } = string.Empty;

    [JsonProperty("ChipNameSource")]
    public string ChipNameSource { get; set; } = string.Empty;

    [JsonProperty("NodeDescs")]
    public List<NodeDesc> NodeDescs { get; set; } = new();

    [JsonProperty("NodeFilters")]
    public List<NodeFilter> NodeFilters { get; set; } = new();
}

public class NodeDesc
{
    [JsonProperty("Name")]
    public string Name { get; set; } = string.Empty;

    [JsonProperty("ReadonlyTypeParams")]
    public Dictionary<string, object> ReadonlyTypeParams { get; set; } = new();

    [JsonProperty("Inputs")]
    public List<NodePort> Inputs { get; set; } = new();

    [JsonProperty("Outputs")]
    public List<NodePort> Outputs { get; set; } = new();
}

public class NodePort
{
    [JsonProperty("Name")]
    public string Name { get; set; } = string.Empty;

    [JsonProperty("ReadonlyType")]
    public string ReadonlyType { get; set; } = string.Empty;

    [JsonProperty("Description")]
    public string Description { get; set; } = string.Empty;
}

public class NodeFilter
{
    [JsonProperty("FilterPath")]
    public List<string> FilterPath { get; set; } = new();
}