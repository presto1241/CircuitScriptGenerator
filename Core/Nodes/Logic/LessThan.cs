/*
 * Filename: LessThan.cs
 * Category: Logic
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns True if input A is less than input B.
 * Types: (int | float)
 * 
 * INPUTS: 
 * A (T)
 * B (T)
 *
 * OUTPUTS: 
 * Result (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Logic;

[Node("a05cd0de-609a-4d92-93ad-65b635306233")]
public class LessThan : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Less Than";
    public string GetVariableQualifiedName() => "lessThan";
}