/*
 * Filename: PathfinderStartPathingtoPosition.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Starts moving the Pathfinder towards the target position
It will slow down once it is within Slowdown Distance of the target
And stop once it is within Arrival Distance of the target
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Pathfinder (Pathfinder)
 * Target Position (Vector3)
 * Slowdown Distance (float)
 * Arrival Distance (float)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("9eb2c95e-9602-4a0c-a78f-3674e23291ec")]
public class PathfinderStartPathingtoPosition : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Pathfinder Start Pathing to Position";
    public string GetVariableQualifiedName() => "pathfinderStartPathingtoPosition";
}