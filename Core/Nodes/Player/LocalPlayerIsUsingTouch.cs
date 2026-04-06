/*
 * Filename: LocalPlayerIsUsingTouch.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Check whether the local player is using touch controls or not.
 * Types: 
 * 
 * INPUTS: 
 * 
 *
 * OUTPUTS: 
 * Is Using Touch (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("cbe72a5a-4616-4213-b2d7-660c58642bab")]
public class LocalPlayerIsUsingTouch : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Local Player Is Using Touch";
    public string GetVariableQualifiedName() => "localPlayerIsUsingTouch";
}