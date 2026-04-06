/*
 * Filename: PathfinderSetMaxAcceleration.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets the maximum linear acceleration of the Pathfinder, in meters per second squared
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Pathfinder (Pathfinder)
 * Max Acceleration (float)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("c299c80e-2406-456f-9455-bf61008d90a2")]
public class PathfinderSetMaxAcceleration : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Pathfinder Set Max Acceleration";
    public string GetVariableQualifiedName() => "pathfinderSetMaxAcceleration";
}