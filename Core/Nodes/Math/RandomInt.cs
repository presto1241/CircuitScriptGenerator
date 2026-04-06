/*
 * Filename: RandomInt.cs
 * Category: Math
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Generates a random integer from ["Min" to "Max"]. "Min" is inclusive, and "Max" is also inclusive. For example with a "Min" of 0 and a "Max" of 1, 0 and 1 will have a chance of being output.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Min (Inclusive) (int)
 * Max (Inclusive) (int)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 * Value (int)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Math;

[Node("fb2645f0-4042-4ef1-b988-af2f80e651ec")]
public class RandomInt : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Random Int";
    public string GetVariableQualifiedName() => "randomInt";
}