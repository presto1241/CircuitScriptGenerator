/*
 * Filename: ParseTime.cs
 * Category: Time
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Parses the input date and time and returns the corresponding universal seconds. The chip will automatically try to find the correct format of the input data.
 * Types: 
 * 
 * INPUTS: 
 * Time (string)
 *
 * OUTPUTS: 
 * Universal Seconds (int)
 * Success (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Time;

[Node("836b64ad-0fd2-4936-bc1f-d25098df8b1d")]
public class ParseTime : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Parse Time";
    public string GetVariableQualifiedName() => "parseTime";
}