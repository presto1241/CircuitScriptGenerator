/*
 * Filename: PathfinderStartRotatingtoDirection.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Starts rotating the Pathfinder towards the target direction
Rotation target takes priority over automatically rotating to face the pathing direction
It will slow down once it is within Slowdown Angle (in degrees) of the target
And stop once it is within Arrival Angle (in degrees) of the target
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Pathfinder (Pathfinder)
 * Target Direction (Vector3)
 * Slowdown Angle (float) - degrees
 * Arrival Angle (float) - degrees
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("d019ed0f-4fa9-464b-baad-22e5f89f25de")]
public class PathfinderStartRotatingtoDirection : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Pathfinder Start Rotating to Direction";
    public string GetVariableQualifiedName() => "pathfinderStartRotatingtoDirection";
}