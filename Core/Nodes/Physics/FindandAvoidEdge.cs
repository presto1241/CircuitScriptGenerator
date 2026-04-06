/*
 * Filename: FindandAvoidEdge.cs
 * Category: Physics
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Detects an Edge in the Source Direction up to the Max Distance (m)
The dimensions of the Detection Cast is (W x H x D), starting from the source.
If the source is an object, it will use the Object's collider Center, otherwise the Vector3 source Position.

The Drop Height is how far the object can drop from an edge
The hover height is how high the source hovers above the ground.
The “Rotation” will determine the Final Direction if an edge is found [-90: turn left, 90: turn right] the rotation is relative to the edge normal unless “From Edge” is false
“Optimized Direction” will show an alternate direction if one side of the source doesn’t have an edge

 * Types: (Vector3 | Rec Room Object)
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Source (TSource)
 * Source Direction (Vector3)
 * Source Dimensions (W x H x D) (Vector3)
 * Avoid Rotation (deg) (float)
 * From Edge (bool)
 * Max Distance (m) (float)
 * Drop Height (m) (float)
 * Hover Height (m) (float)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 * Edge Found (bool)
 * Final Direction (Vector3)
 * Optimized Direction (Vector3) - Alternative rotation result if one side of the source does not hit an obstacle
 * Closest Edge Data (Collision Data)
 * Closest Edge Distance (m) (float)
 * Ground Normal (Vector3)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Physics;

[Node("fde02cee-41e7-4727-9ea9-3b3afde5db50")]
public class FindandAvoidEdge : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Find and Avoid Edge";
    public string GetVariableQualifiedName() => "findandAvoidEdge";
}