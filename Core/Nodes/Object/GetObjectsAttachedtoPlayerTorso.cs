/*
 * Filename: GetObjectsAttachedtoPlayerTorso.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Gets a list of all the Rec Room Objects which are currently attached to a player's torso
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (Player)
 *
 * OUTPUTS: 
 * (unnamed) (List<Rec Room Object>)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("f3e46502-f84c-459f-b6b8-9e74482155f3")]
public class GetObjectsAttachedtoPlayerTorso : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Get Objects Attached to Player Torso";
    public string GetVariableQualifiedName() => "getObjectsAttachedtoPlayerTorso";
}