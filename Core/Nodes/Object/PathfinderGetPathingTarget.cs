/*
 * Filename: PathfinderGetPathingTarget.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Gets the current pathing target (target position, slowdown and arrival distances) of the Pathfinder
 * Types: 
 * 
 * INPUTS: 
 * Pathfinder (Pathfinder)
 *
 * OUTPUTS: 
 * Target Position (Vector3)
 * Slowdown Distance (float)
 * Arrival Distance (float)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("9665db7b-085a-4453-9121-90e2d084e527")]
public class PathfinderGetPathingTarget : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Pathfinder Get Pathing Target";
    public string GetVariableQualifiedName() => "pathfinderGetPathingTarget";
}