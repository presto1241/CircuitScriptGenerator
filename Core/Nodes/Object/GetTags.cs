/*
 * Filename: GetTags.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Outputs a list of tags the input object or player has.
 * Types: (Player | Rec Room Object)
 * 
 * INPUTS: 
 * Target (T)
 *
 * OUTPUTS: 
 * Tags (List<string>)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("e67cfcb7-03e8-4152-ba41-af8ca61d93fb")]
public class GetTags : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Get Tags";
    public string GetVariableQualifiedName() => "getTags";
}