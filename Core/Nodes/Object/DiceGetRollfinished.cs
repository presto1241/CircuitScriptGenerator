/*
 * Filename: DiceGetRollfinished.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Outputs an exec when the dice finished rolling.
 * Types: 
 * 
 * INPUTS: 
 * Target (Die)
 *
 * OUTPUTS: 
 * Roll Finished (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("b8735ad9-cd89-4d81-ab9b-be3eb50e3b5a")]
public class DiceGetRollfinished : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Dice Get Roll finished";
    public string GetVariableQualifiedName() => "diceGetRollfinished";
}