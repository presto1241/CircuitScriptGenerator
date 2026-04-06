/*
 * Filename: Nand.cs
 * Category: Logic
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Outputs False only when all inputs are True. If any input is False, it outputs True.
 * Types: 
 * 
 * INPUTS: 
 * Input (bool)
 *
 * OUTPUTS: 
 * Result (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Logic;

[Node("502e86d1-5b3a-4213-97e2-df25836ffcc4")]
public class Nand : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Nand";
    public string GetVariableQualifiedName() => "nand";
}