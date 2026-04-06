/*
 * Filename: BigDebugChip.cs
 * Category: Misc
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Used in conjunction with the Circuits V2 window for debugging.
 * Types: 
 * 
 * INPUTS: 
 * 
 *
 * OUTPUTS: 
 * 
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Misc;

[Node("3f4f7344-8aea-48f9-80a4-888f1492b166")]
public class BigDebugChip : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Big Debug Chip";
    public string GetVariableQualifiedName() => "bigDebugChip";
}