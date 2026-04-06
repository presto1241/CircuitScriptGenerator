/*
 * Filename: DiceGetResult.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the result of the dice.
 * Types: 
 * 
 * INPUTS: 
 * Target (Die)
 *
 * OUTPUTS: 
 * Result (int)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("c80e2979-c672-4e7a-81fb-0ed1964e3ea6")]
public class DiceGetResult : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Dice Get Result";
    public string GetVariableQualifiedName() => "diceGetResult";
}