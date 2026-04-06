/*
 * Filename: FindandAvoidObstacle.cs
 * Category: Physics
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Detects an Object in the Source Direction up to the Max Distance (m)
The dimensions of the Detection Cast is (W x H x D), starting from the source.
If the source is an object, it will use the Object's collider Center, otherwise the Vector3 source Position.
If the Source Object is a Rec Room Object, the object will be filtered out from collision detection
The Jump Height is how high the source can jump to go over obstacles
The hover height is how high the source hovers above the ground

The “Rotation” will determine the Final Direction if an obstacle is found [-90: turn left, 90: turn right] the rotation is relative to the object normal unless “From Edge” is false
“Optimized Direction” will show an alternate direction if one side of the source doesn’t find an object

 * Types: (Vector3 | Rec Room Object)
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Source (TSource)
 * Source Direction (Vector3)
 * Source Dimensions (W x H x D) (Vector3)
 * Avoid Rotation (deg) (float)
 * From Obstacle (bool)
 * Max Distance (m) (float)
 * Jump Height (m) (float)
 * Hover Height (m) (float)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 * Obstacle Found (bool)
 * Can Jump (bool)
 * Is Floor (< 45) (bool)
 * Final Direction (Vector3)
 * Optimized Direction (Vector3) - Alternative rotation result if one side of the source does not hit an obstacle
 * Closest Object Data (Collision Data)
 * Closest Object Distance (m) (float)
 * Ground Normal (Vector3)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Physics;

[Node("ddc9c0fa-32bc-4df7-af76-4b0c1fbe22bd")]
public class FindandAvoidObstacle : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Find and Avoid Obstacle";
    public string GetVariableQualifiedName() => "findandAvoidObstacle";
}