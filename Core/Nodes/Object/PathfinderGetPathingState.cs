/*
 * Filename: PathfinderGetPathingState.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Gets the Pathfinder's current pathing state information
* Is Pathing
* Has Arrived
* Within Slowdown Distance
 * Types: 
 * 
 * INPUTS: 
 * Pathfinder (Pathfinder)
 *
 * OUTPUTS: 
 * Is Pathing (bool)
 * Has Arrived (bool)
 * Within Slowdown Distance (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("f39decac-fc9d-40fb-ae61-090946d64cfe")]
public class PathfinderGetPathingState : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Pathfinder Get Pathing State";
    public string GetVariableQualifiedName() => "pathfinderGetPathingState";
}