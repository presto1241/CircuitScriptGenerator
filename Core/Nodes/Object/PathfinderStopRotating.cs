/*
 * Filename: PathfinderStopRotating.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Clears the target rotation of a Pathfinder
Automatic rotation to face the pathing direction will resume
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Pathfinder (Pathfinder)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("4d13671f-026a-4eaa-8871-405c4c79f2b5")]
public class PathfinderStopRotating : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Pathfinder Stop Rotating";
    public string GetVariableQualifiedName() => "pathfinderStopRotating";
}