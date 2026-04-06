/*
 * Filename: DestinationRoomConstant.cs
 * Category: Constant
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Configure this constant to choose a destination, specifying room, subroom, and welcome mat. If destination room is different than current room, only Entry Subrooms may be targeted. Party follow options may vary by destination. Use this chip with Go To Room.
 * Types: 
 * 
 * INPUTS: 
 * 
 *
 * OUTPUTS: 
 * (unnamed) (Destination Room)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Constant;

[Node("330f3621-0d37-4cd7-8b92-270c7df43fcb")]
public class DestinationRoomConstant : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Destination Room Constant";
    public string GetVariableQualifiedName() => "destinationRoomConstant";
}