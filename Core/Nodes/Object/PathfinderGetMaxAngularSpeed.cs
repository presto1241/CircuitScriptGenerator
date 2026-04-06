/*
 * Filename: PathfinderGetMaxAngularSpeed.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the max angular speed of the target Pathfinder
 * Types: 
 * 
 * INPUTS: 
 * Pathfinder (Pathfinder)
 *
 * OUTPUTS: 
 * Max Angular Speed (float)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("de4897c7-a9d2-4219-8674-e1714e1fc9ab")]
public class PathfinderGetMaxAngularSpeed : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Pathfinder Get Max Angular Speed";
    public string GetVariableQualifiedName() => "pathfinderGetMaxAngularSpeed";
}