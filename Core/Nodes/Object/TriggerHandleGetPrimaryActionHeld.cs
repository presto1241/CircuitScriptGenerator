/*
 * Filename: TriggerHandleGetPrimaryActionHeld.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: True if the primary action button is down; otherwise, False.
 * Types: 
 * 
 * INPUTS: 
 * Target (Trigger Handle)
 *
 * OUTPUTS: 
 * Is Held (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("b309c032-1bcd-4ca1-83cf-b8871e65fb16")]
public class TriggerHandleGetPrimaryActionHeld : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Trigger Handle Get Primary Action Held";
    public string GetVariableQualifiedName() => "triggerHandleGetPrimaryActionHeld";
}