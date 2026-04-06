/*
 * Filename: ListDestinationRoomVariable.cs
 * Category: List
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Stores a list of Destinations. Use constants to configure destinations.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * (unnamed) (List<Destination Room>)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 * (unnamed) (List<Destination Room>)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.List;

[Node("fff164aa-d775-4d67-a6b0-d1396cb74161")]
public class ListDestinationRoomVariable : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "List<Destination Room> Variable";
    public string GetVariableQualifiedName() => "listDestinationRoomVariable";
}