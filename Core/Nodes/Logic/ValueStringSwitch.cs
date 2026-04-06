/*
 * Filename: ValueStringSwitch.cs
 * Category: Logic
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the associated input of the compare value that matches the 'match' input. Returns the default value if no match can be found.
 * Types: any
 * 
 * INPUTS: 
 * Match (string)
 * Default (T)
 *
 * OUTPUTS: 
 * Data (T)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Logic;

[Node("2c9dcd54-dd65-498e-8a13-50c221448358")]
public class ValueStringSwitch : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Value String Switch";
    public string GetVariableQualifiedName() => "valueStringSwitch";
}