/*
 * Filename: AIVariable.cs
 * Category: Variable
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: 
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * (unnamed) (AI)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 * (unnamed) (AI)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Variable;

[Node("0e92a7fb-fb38-418c-af39-9afec92112ee")]
public class AIVariable : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "AI Variable";
    public string GetVariableQualifiedName() => "aIVariable";
}