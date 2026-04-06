/*
 * Filename: Comment.cs
 * Category: Commonly Used
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Put a comment next to your circuits to explain what they're doing.
 * Types: 
 * 
 * INPUTS: 
 * 
 *
 * OUTPUTS: 
 * 
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.CommonlyUsed;

[Node("83623f53-86b2-477d-bb2f-fe68f68ba617")]
public class Comment : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Comment";
    public string GetVariableQualifiedName() => "comment";
}