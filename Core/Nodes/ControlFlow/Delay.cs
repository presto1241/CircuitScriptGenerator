/*
 * Filename: Delay.cs
 * Category: Control Flow
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Fires outputs based on the inputted time to delay. The Run exec fires as soon as the node is executed. The After Delay exec fires once the input delay duration has completed. After Canceled fires after the delay node’s Cancel exec has been fired. Cancel cancels all current delays running from this node, except for delays scheduled for the next tick.
 * Types: 
 * 
 * INPUTS: 
 * Run (exec)
 * Delay (s) (float)
 * Cancel (exec)
 *
 * OUTPUTS: 
 * Run (exec)
 * After Delay (exec)
 * Cancel (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.ControlFlow;

[Node("cefee2a5-d4a8-4dff-8c4e-bad684ca8d34")]
public class Delay : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Delay";
    public string GetVariableQualifiedName() => "delay";
}