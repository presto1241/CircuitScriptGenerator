/*
 * Filename: PlayerIsHoldingMakerPen.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Outputs if the Player is holding their Maker Pen.
Useful for having different logic while creating.
 * Types: 
 * 
 * INPUTS: 
 * Target (Player)
 *
 * OUTPUTS: 
 * Result (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("554060d7-5631-40a0-8d75-5dca5b2b910b")]
public class PlayerIsHoldingMakerPen : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Player Is Holding Maker Pen";
    public string GetVariableQualifiedName() => "playerIsHoldingMakerPen";
}