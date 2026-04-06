/*
 * Filename: PathfinderGetTagsToIgnore.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the list of the tags that the Pathfinder is set to ignore
 * Types: 
 * 
 * INPUTS: 
 * Pathfinder (Pathfinder)
 *
 * OUTPUTS: 
 * Tags To Ignore (List<string>)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("11510599-9682-47ff-8218-91a83504275f")]
public class PathfinderGetTagsToIgnore : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Pathfinder Get Tags To Ignore";
    public string GetVariableQualifiedName() => "pathfinderGetTagsToIgnore";
}