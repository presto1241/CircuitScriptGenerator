/*
 * Filename: PathfinderSetMaxAngularSpeed.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets the maximum angular speed of the Pathfinder, in degrees per second
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Pathfinder (Pathfinder)
 * Max Angular Speed (deg/s) (float) - degrees per second
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("dea14fad-b6ba-4ce6-ac67-57dfe0f88b39")]
public class PathfinderSetMaxAngularSpeed : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Pathfinder Set Max Angular Speed";
    public string GetVariableQualifiedName() => "pathfinderSetMaxAngularSpeed";
}