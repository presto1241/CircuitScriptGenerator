/*
 * Filename: StringSplitAtIndex.cs
 * Category: String
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Splits the target string in two at the input index.
 * Types: 
 * 
 * INPUTS: 
 * String (string)
 * Index (int)
 *
 * OUTPUTS: 
 * List (List<string>)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.String;

[Node("6b92c345-e6bc-40d9-aae9-4754e634777c")]
public class StringSplitAtIndex : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "String Split At Index";
    public string GetVariableQualifiedName() => "stringSplitAtIndex";
}