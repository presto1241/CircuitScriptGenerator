/*
 * Filename: RoomBadgeConstant.cs
 * Category: Game Features
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Can be configured to select a Room Badge and provide that value to circuits.

The Room Badge must be associated with the current room.
 * Types: 
 * 
 * INPUTS: 
 * 
 *
 * OUTPUTS: 
 * (unnamed) (Room Badge)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.GameFeatures;

[Node("1db353d9-f539-4596-92d1-54e0b63c6d4f")]
public class RoomBadgeConstant : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Room Badge Constant";
    public string GetVariableQualifiedName() => "roomBadgeConstant";
}