/*
 * Filename: GetAuthority.cs
 * Category: Networking
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Gets the authority player of the chip's current context.
 * Types: 
 * 
 * INPUTS: 
 * 
 *
 * OUTPUTS: 
 * (unnamed) (Player)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Networking;

[Node("eaf712f8-3257-4415-9f88-ae94e308396e")]
public class GetAuthority : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Get Authority";
    public string GetVariableQualifiedName() => "getAuthority";
}