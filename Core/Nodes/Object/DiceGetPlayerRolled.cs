/*
 * Filename: DiceGetPlayerRolled.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the player who rolled the dice.
 * Types: 
 * 
 * INPUTS: 
 * Target (Die)
 *
 * OUTPUTS: 
 * Player (Player)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("c1fdc4fa-fcb4-4ea4-b505-7b1d15fb8117")]
public class DiceGetPlayerRolled : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Dice Get Player Rolled";
    public string GetVariableQualifiedName() => "diceGetPlayerRolled";
}