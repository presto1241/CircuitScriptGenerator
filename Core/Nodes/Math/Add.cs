/*
 * Filename: Add.cs
 * Created Date: Sunday, April 5th 2026, 1:58:29 am
 * Author: Preston
 * 
 * Description: Add any inputs together to generate an output.
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Math;

[Node("0ccb153c-dd08-4f22-80fd-9d8c5940928c")]
public class Add : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Add";
    public string GetVariableQualifiedName() => "add";
}