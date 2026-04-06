/*
 * Filename: TriggerHandleGetControlPrompt.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Return the current value of the control prompt displayed to whoever is holding the target Trigger Handle
 * Types: 
 * 
 * INPUTS: 
 * Target (Trigger Handle)
 *
 * OUTPUTS: 
 * Control Prompt (string)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("8ea2fd23-02c2-4055-ab39-68acd0b6ce67")]
public class TriggerHandleGetControlPrompt : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Trigger Handle Get Control Prompt";
    public string GetVariableQualifiedName() => "triggerHandleGetControlPrompt";
}