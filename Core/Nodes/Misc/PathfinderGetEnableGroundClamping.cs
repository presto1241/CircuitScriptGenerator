/*
 * Filename: PathfinderGetEnableGroundClamping.cs
 * Category: Misc
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns whether the Ground Clamping config setting is enabled on the target Pathfinder
 * Types: 
 * 
 * INPUTS: 
 * Pathfinder (Pathfinder)
 *
 * OUTPUTS: 
 * Is Ground Clamping Enabled (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Misc;

[Node("04dfa392-1f6d-4f7e-9c84-777846cf9ff8")]
public class PathfinderGetEnableGroundClamping : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Pathfinder Get Enable Ground Clamping";
    public string GetVariableQualifiedName() => "pathfinderGetEnableGroundClamping";
}