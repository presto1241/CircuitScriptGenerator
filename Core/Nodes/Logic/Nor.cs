/*
 * Filename: Nor.cs
 * Category: Logic
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Outputs True when all inputs are False. Otherwise, outputs False.
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

[Node("2891bcb4-a6ab-4a2e-a08d-dd2a55f1cf66")]
public class Nor : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Nor";
    public string GetVariableQualifiedName() => "nor";
}