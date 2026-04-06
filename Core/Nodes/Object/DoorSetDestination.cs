/*
 * Filename: DoorSetDestination.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Set the Destination for the target Door prop. Use with a Destination constant.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Room Door)
 * Room (Destination Room)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("5b9dc865-0fac-4d3a-9edc-68184ee189a2")]
public class DoorSetDestination : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Door Set Destination";
    public string GetVariableQualifiedName() => "doorSetDestination";
}