/*
 * Filename: IfLocalPlayerIsAuthority.cs
 * Category: Networking
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: I'm Authority exec fires on the player's machine who has authority in the current context. At the room level, this is room authority, inside an object board, this is object authority. I'm Not Authority exec fires for everyone else.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 *
 * OUTPUTS: 
 * I'm Authority (exec)
 * I'm Not Authority (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Networking;

[Node("b8b667b9-7b55-4b8d-b116-abef220777e2")]
public class IfLocalPlayerIsAuthority : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "If Local Player Is Authority";
    public string GetVariableQualifiedName() => "ifLocalPlayerIsAuthority";
}