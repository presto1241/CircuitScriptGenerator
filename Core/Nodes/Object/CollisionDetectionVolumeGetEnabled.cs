/*
 * Filename: CollisionDetectionVolumeGetEnabled.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns whether the target Collision Detection Volume is enabled
 * Types: 
 * 
 * INPUTS: 
 * Target (Collision Detection Volume)
 *
 * OUTPUTS: 
 * Enabled (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("9b5e9c57-babc-4e7a-a728-97bef7a11cfc")]
public class CollisionDetectionVolumeGetEnabled : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Collision Detection Volume Get Enabled";
    public string GetVariableQualifiedName() => "collisionDetectionVolumeGetEnabled";
}