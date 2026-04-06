/*
 * Filename: RandomFloat.cs
 * Category: Math
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Generates a random float from ["Min" to "Max"]. "Min" is inclusive, and "Max" is also inclusive. For example with a "Min" of 0 and a "Max" of 1, both 0 and 1 have the possibility of getting output because they are both included in the range.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Min (Inclusive) (float)
 * Max (Inclusive) (float)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 * Value (float)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Math;

[Node("4ecbf247-ab14-4f9e-8094-e40a45d283e6")]
public class RandomFloat : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Random Float";
    public string GetVariableQualifiedName() => "randomFloat";
}