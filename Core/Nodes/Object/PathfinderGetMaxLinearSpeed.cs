/*
 * Filename: PathfinderGetMaxLinearSpeed.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the max linear speed of the target Pathfinder
 * Types: 
 * 
 * INPUTS: 
 * Pathfinder (Pathfinder)
 *
 * OUTPUTS: 
 * Max Linear Speed (float)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("07dcdde1-97a5-4923-8d75-78a74c942731")]
public class PathfinderGetMaxLinearSpeed : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Pathfinder Get Max Linear Speed";
    public string GetVariableQualifiedName() => "pathfinderGetMaxLinearSpeed";
}