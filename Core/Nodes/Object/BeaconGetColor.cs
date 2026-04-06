/*
 * Filename: BeaconGetColor.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the color of the target Beacon object.
 * Types: 
 * 
 * INPUTS: 
 * Target (Beacon)
 *
 * OUTPUTS: 
 * Color (Color)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("5f7cd28c-bafc-409d-8872-f21ccec5f022")]
public class BeaconGetColor : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Beacon Get Color";
    public string GetVariableQualifiedName() => "beaconGetColor";
}