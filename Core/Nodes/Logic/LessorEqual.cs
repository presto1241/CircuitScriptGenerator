/*
 * Filename: LessorEqual.cs
 * Category: Logic
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns True if input A is less than or equal to input B.
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

[Node("8c78eedf-f79e-4f70-b187-65092893d1b6")]
public class LessorEqual : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Less or Equal";
    public string GetVariableQualifiedName() => "lessorEqual";
}