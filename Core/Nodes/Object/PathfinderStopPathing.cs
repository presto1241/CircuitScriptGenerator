/*
 * Filename: PathfinderStopPathing.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Stops moving the Pathfinder
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

[Node("03375be5-3c6e-4f11-8f65-3454c37ed9f6")]
public class PathfinderStopPathing : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Pathfinder Stop Pathing";
    public string GetVariableQualifiedName() => "pathfinderStopPathing";
}