/*
 * Filename: InvisibleCollisionGetEnabled.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Outputs True if the target Invisible Collision object is enabled.
 * Types: 
 * 
 * INPUTS: 
 * Target (Invisible Collision)
 *
 * OUTPUTS: 
 * Enabled (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("de407f3c-2fb0-4c9a-9dc4-fb6d6709737e")]
public class InvisibleCollisionGetEnabled : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Invisible Collision Get Enabled";
    public string GetVariableQualifiedName() => "invisibleCollisionGetEnabled";
}