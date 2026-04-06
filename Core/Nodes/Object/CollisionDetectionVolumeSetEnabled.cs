/*
 * Filename: CollisionDetectionVolumeSetEnabled.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets whether the target Collision Detection Volume is enabled
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Collision Detection Volume)
 * Enabled (bool)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("711cadd1-24b0-4969-9fba-f65cbaeab3c5")]
public class CollisionDetectionVolumeSetEnabled : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Collision Detection Volume Set Enabled";
    public string GetVariableQualifiedName() => "collisionDetectionVolumeSetEnabled";
}