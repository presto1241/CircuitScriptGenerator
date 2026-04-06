/*
 * Filename: LocalPlayerIsUsingKeyboardAndMouse.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Check whether the local player is using keyboard and mouse controls or not.
 * Types: 
 * 
 * INPUTS: 
 * 
 *
 * OUTPUTS: 
 * Is Using Keyboard And Mouse (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("859d380b-573e-4db7-94dd-82729dcc2e39")]
public class LocalPlayerIsUsingKeyboardAndMouse : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Local Player Is Using Keyboard And Mouse";
    public string GetVariableQualifiedName() => "localPlayerIsUsingKeyboardAndMouse";
}