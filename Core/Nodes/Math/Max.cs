/*
 * Filename: Max.cs
 * Category: Math
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns largest of two or more values.
 * Types: (int | float)
 * 
 * INPUTS: 
 * Value (T)
 *
 * OUTPUTS: 
 * Max (T)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Math;

[Node("1cb807b1-85e7-4c14-b3ae-5775b7873b7d")]
public class Max : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Max";
    public string GetVariableQualifiedName() => "max";
}