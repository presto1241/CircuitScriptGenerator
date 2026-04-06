/*
 * Filename: PlayerGetIsAuthorityOf.cs
 * Category: Networking
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Outputs if a Player is authority of the input object.
 * Types: 
 * 
 * INPUTS: 
 * Target (Player)
 * Object (Rec Room Object)
 *
 * OUTPUTS: 
 * Result (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Networking;

[Node("c35fe6fe-d231-4ee5-80ff-9e69f24eb29e")]
public class PlayerGetIsAuthorityOf : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Player Get Is Authority Of";
    public string GetVariableQualifiedName() => "playerGetIsAuthorityOf";
}