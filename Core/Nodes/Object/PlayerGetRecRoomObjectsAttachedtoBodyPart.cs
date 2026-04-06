/*
 * Filename: PlayerGetRecRoomObjectsAttachedtoBodyPart.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Gets a list of all the Rec Room Objects which are currently attached to a player on the specified body part
 * Types: 
 * 
 * INPUTS: 
 * Player (Player)
 * Body Part (Body Part)
 *
 * OUTPUTS: 
 * Objects (List<Rec Room Object>)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("574e325f-d493-46cb-92bb-5e4800a99fee")]
public class PlayerGetRecRoomObjectsAttachedtoBodyPart : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Player Get Rec Room Objects Attached to Body Part";
    public string GetVariableQualifiedName() => "playerGetRecRoomObjectsAttachedtoBodyPart";
}