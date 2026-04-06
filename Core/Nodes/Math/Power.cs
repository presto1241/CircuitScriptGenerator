/*
 * Filename: Power.cs
 * Category: Math
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Multiplies a value by itself an input number of times.
 * Types: (int | float)
 * 
 * INPUTS: 
 * Value (T)
 *
 * OUTPUTS: 
 * Result (T)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Math;

[Node("288d4e89-ebed-41ed-a522-4c79bd48471a")]
public class Power : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Power";
    public string GetVariableQualifiedName() => "power";
}