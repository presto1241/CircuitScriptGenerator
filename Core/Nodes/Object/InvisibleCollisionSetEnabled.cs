/*
 * Filename: InvisibleCollisionSetEnabled.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets the enabled state of a target Invisible Collision object.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Invisible Collision)
 * Enabled (bool)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("a5b78c7e-d718-44d4-91c4-7f795bf73814")]
public class InvisibleCollisionSetEnabled : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Invisible Collision Set Enabled";
    public string GetVariableQualifiedName() => "invisibleCollisionSetEnabled";
}