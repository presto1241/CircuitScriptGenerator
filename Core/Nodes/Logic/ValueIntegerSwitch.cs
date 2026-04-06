/*
 * Filename: ValueIntegerSwitch.cs
 * Category: Logic
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the associated input of the compare value that matches the 'match' input. Returns the default value if no match can be found.
 * Types: any
 * 
 * INPUTS: 
 * Match (int)
 * Default (T)
 *
 * OUTPUTS: 
 * Data (T)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Logic;

[Node("be534038-473e-40ad-b4e2-abd38a76711b")]
public class ValueIntegerSwitch : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Value Integer Switch";
    public string GetVariableQualifiedName() => "valueIntegerSwitch";
}