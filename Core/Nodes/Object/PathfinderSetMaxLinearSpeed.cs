/*
 * Filename: PathfinderSetMaxLinearSpeed.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets the maximum linear speed of the Pathfinder, in meters per second
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Pathfinder (Pathfinder)
 * Max Linear Speed (float)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("5ed82dc3-f83d-457a-9605-dbd3a323754e")]
public class PathfinderSetMaxLinearSpeed : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Pathfinder Set Max Linear Speed";
    public string GetVariableQualifiedName() => "pathfinderSetMaxLinearSpeed";
}