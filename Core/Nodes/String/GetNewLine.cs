/*
 * Filename: GetNewLine.cs
 * Category: String
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns a new line string.
 * Types: 
 * 
 * INPUTS: 
 * 
 *
 * OUTPUTS: 
 * New Line (string)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.String;

[Node("975fde92-136c-4ce5-b749-bf149b817695")]
public class GetNewLine : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Get New Line";
    public string GetVariableQualifiedName() => "getNewLine";
}