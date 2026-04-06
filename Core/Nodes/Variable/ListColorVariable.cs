/*
 * Filename: ListColorVariable.cs
 * Category: Variable
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Reads or writes a variable in the current scope based on the name.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * (unnamed) (List<Color>)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 * (unnamed) (List<Color>)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Variable;

[Node("9216dded-da74-49a7-a327-5750f4809787")]
public class ListColorVariable : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "List<Color> Variable";
    public string GetVariableQualifiedName() => "listColorVariable";
}