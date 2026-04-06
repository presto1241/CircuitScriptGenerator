/*
 * Filename: If.cs
 * Category: Control Flow
 * Created Date: 2026-04-05T23:55:26+00:00
 * Author: Preston
 * 
 * Description: Takes a boolean condition as an input. If True, the "Then" exec pin fires. If False, the "Else" exec pin fires.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Condition (bool)
 *
 * OUTPUTS: 
 * Then (exec)
 * Else (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Control Flow;

[Node("7adc6ab1-fcab-4746-aec6-006352e29cdc")]
public class If : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "If";
    public string GetVariableQualifiedName() => "if";
}