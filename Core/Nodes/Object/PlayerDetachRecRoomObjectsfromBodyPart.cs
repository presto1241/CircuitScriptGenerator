/*
 * Filename: PlayerDetachRecRoomObjectsfromBodyPart.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Detach all Rec Room Objects that are currently attached to a player on the specified body part.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Player (Player)
 * Body Part (Body Part)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("7d77b9e8-c003-4856-8a2c-2aa3b3b65213")]
public class PlayerDetachRecRoomObjectsfromBodyPart : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Player Detach Rec Room Objects from Body Part";
    public string GetVariableQualifiedName() => "playerDetachRecRoomObjectsfromBodyPart";
}