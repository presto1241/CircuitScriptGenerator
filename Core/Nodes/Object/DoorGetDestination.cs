/*
 * Filename: DoorGetDestination.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the current Destination to which the target Door prop is set
 * Types: 
 * 
 * INPUTS: 
 * Target (Room Door)
 *
 * OUTPUTS: 
 * Destination (Destination Room)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("5f0eb749-1c4e-46fb-b2d1-4faaf69446bb")]
public class DoorGetDestination : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Door Get Destination";
    public string GetVariableQualifiedName() => "doorGetDestination";
}