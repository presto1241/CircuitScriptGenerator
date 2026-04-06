/*
 * Filename: HandleGetControlPrompt.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Gets the primary action label on the target handle type object
 * Types: 
 * 
 * INPUTS: 
 * Target (Handle)
 *
 * OUTPUTS: 
 * Control Prompt (string)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("9af47a88-a066-4923-928d-50a8ff99eaaa")]
public class HandleGetControlPrompt : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Handle Get Control Prompt";
    public string GetVariableQualifiedName() => "handleGetControlPrompt";
}