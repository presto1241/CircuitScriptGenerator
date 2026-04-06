/*
 * Filename: LocalPlayerIsUsingController.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Check whether the local player is using a controller or not.
 * Types: 
 * 
 * INPUTS: 
 * 
 *
 * OUTPUTS: 
 * Is Using Controller (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("00b3958e-4f84-42fa-acd8-cdb33dd44f25")]
public class LocalPlayerIsUsingController : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Local Player Is Using Controller";
    public string GetVariableQualifiedName() => "localPlayerIsUsingController";
}