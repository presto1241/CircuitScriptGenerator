/*
 * Filename: PathfinderSetTagsToIgnore.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets the object tags that the pathfinder ignores on collision
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Pathfinder (Pathfinder)
 * Tags To Ignore (List<string>)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("8b3b16ee-7078-4376-b56b-7da679c9ef14")]
public class PathfinderSetTagsToIgnore : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Pathfinder Set Tags To Ignore";
    public string GetVariableQualifiedName() => "pathfinderSetTagsToIgnore";
}