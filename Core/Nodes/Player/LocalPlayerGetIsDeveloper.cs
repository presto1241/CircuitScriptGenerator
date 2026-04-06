/*
 * Filename: LocalPlayerGetIsDeveloper.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns true if the local player is a Developer account.
 * Types: 
 * 
 * INPUTS: 
 * 
 *
 * OUTPUTS: 
 * Is Developer (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("949f0295-23bd-443a-91e9-b8395335dd7d")]
public class LocalPlayerGetIsDeveloper : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Local Player Get Is Developer";
    public string GetVariableQualifiedName() => "localPlayerGetIsDeveloper";
}