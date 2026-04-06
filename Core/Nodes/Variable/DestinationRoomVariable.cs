/*
 * Filename: DestinationRoomVariable.cs
 * Category: Variable
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Stores a destination room. Destination cannot be configured from variable - for that, use a Constant.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * (unnamed) (Destination Room)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 * (unnamed) (Destination Room)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Variable;

[Node("31eab00d-a6f7-4505-9f84-02d3e1eedd86")]
public class DestinationRoomVariable : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Destination Room Variable";
    public string GetVariableQualifiedName() => "destinationRoomVariable";
}