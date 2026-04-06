/*
 * Filename: Or.cs
 * Category: Logic
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Outputs True if any input is True. Otherwise outputs False.
 * Types: 
 * 
 * INPUTS: 
 * Input (bool)
 *
 * OUTPUTS: 
 * Result (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Logic;

[Node("b5dcded0-eb2b-468d-a4b9-ffb1054f6214")]
public class Or : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Or";
    public string GetVariableQualifiedName() => "or";
}