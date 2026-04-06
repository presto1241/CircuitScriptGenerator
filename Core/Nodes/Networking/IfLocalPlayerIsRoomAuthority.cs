/*
 * Filename: IfLocalPlayerIsRoomAuthority.cs
 * Category: Networking
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: I'm Authority exec fires on the player's machine who has authority over the room. I'm Not Authority exec fires for everyone else.
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

[Node("5e28057f-214b-4ff8-81bc-512be207c9d7")]
public class IfLocalPlayerIsRoomAuthority : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "If Local Player Is Room Authority";
    public string GetVariableQualifiedName() => "ifLocalPlayerIsRoomAuthority";
}