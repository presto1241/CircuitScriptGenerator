/*
 * Filename: PathfinderGetRotationState.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Gets the Pathfinder's current rotation state information
* Is Rotating
* Has Arrived
 * Types: 
 * 
 * INPUTS: 
 * Pathfinder (Pathfinder)
 *
 * OUTPUTS: 
 * Is Rotating (bool)
 * Has Arrived (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("0e2cbe0b-53e5-41ad-807a-b8be7a8fd019")]
public class PathfinderGetRotationState : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Pathfinder Get Rotation State";
    public string GetVariableQualifiedName() => "pathfinderGetRotationState";
}