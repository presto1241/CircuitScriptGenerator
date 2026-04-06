/*
 * Filename: BreakTuple.cs
 * Category: Utilities
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Separates a Tuple into its two component values
 * Types: any
 * 
 * INPUTS: 
 * Tuple ((T0, T1))
 *
 * OUTPUTS: 
 * Item 0 (T0)
 * Item 1 (T1)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Utilities;

[Node("9478334a-451d-4802-bab1-4b05f00d45e4")]
public class BreakTuple : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Break Tuple";
    public string GetVariableQualifiedName() => "breakTuple";
}