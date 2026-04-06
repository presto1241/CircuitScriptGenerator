/*
 * Filename: AIGetLineofSightParameters.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Outputs the current line of sight parameters from the input AI.
 * Types: 
 * 
 * INPUTS: 
 * AI (AI)
 *
 * OUTPUTS: 
 * Vision Type (string)
 * Vision Range (m) (float)
 * Vision Cone Angle (float)
 * Hearing Range (m) (float)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("3edc785f-46ef-4f30-b101-a07126d3a370")]
public class AIGetLineofSightParameters : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "AI Get Line of Sight Parameters";
    public string GetVariableQualifiedName() => "aIGetLineofSightParameters";
}