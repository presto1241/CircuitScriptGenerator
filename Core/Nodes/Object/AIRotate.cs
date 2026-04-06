/*
 * Filename: AIRotate.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Commands an AI to turn an inputted number of degrees. To command the AI to back to default rotating behavior, use the AI Stop Looking node.
 * Types: (float | int | Vector3)
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * AI (AI)
 * Rotation (degrees) (T)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("c2cb2ea2-f663-4aa6-9394-3b741f6b9064")]
public class AIRotate : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "AI Rotate";
    public string GetVariableQualifiedName() => "aIRotate";
}