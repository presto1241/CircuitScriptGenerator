/*
 * Filename: RequestBalanceAnimation.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Puts the player into a generic locomotion state and plays the balance animation.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("16ab1470-78e0-4551-9e08-499e777abee9")]
public class RequestBalanceAnimation : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Request Balance Animation";
    public string GetVariableQualifiedName() => "requestBalanceAnimation";
}