/*
 * Filename: ExecutionStringSwitch.cs
 * Category: Logic
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Executes the associated output of the compare value that matches the 'match' input. Executes the default output if no match can be found.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Match (string)
 *
 * OUTPUTS: 
 * Failed (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Logic;

[Node("80c7d803-df40-45a5-ac7b-bfccb0b511c7")]
public class ExecutionStringSwitch : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Execution String Switch";
    public string GetVariableQualifiedName() => "executionStringSwitch";
}