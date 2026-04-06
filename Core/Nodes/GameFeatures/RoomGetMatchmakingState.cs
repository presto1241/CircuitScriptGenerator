/*
 * Filename: RoomGetMatchmakingState.cs
 * Category: Game Features
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Return whether this instance of the room is visible to Rec Room's matchmaking
 * Types: 
 * 
 * INPUTS: 
 * 
 *
 * OUTPUTS: 
 * Matchmaking Permitted (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.GameFeatures;

[Node("2d358c91-9000-4851-ad37-65759a135ab7")]
public class RoomGetMatchmakingState : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Room Get Matchmaking State";
    public string GetVariableQualifiedName() => "roomGetMatchmakingState";
}