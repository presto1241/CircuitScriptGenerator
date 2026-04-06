/*
 * Filename: PathfinderSetGroundClamping.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Toggles enabling ground clamping for the pathfinder
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Pathfinder (Pathfinder)
 * Enable (bool)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("9806dabd-f9e6-416c-9fe7-e0346de88c49")]
public class PathfinderSetGroundClamping : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Pathfinder Set Ground Clamping";
    public string GetVariableQualifiedName() => "pathfinderSetGroundClamping";
}