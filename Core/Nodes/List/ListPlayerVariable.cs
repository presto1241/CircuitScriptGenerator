/*
 * Filename: ListPlayerVariable.cs
 * Category: List
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Reads or writes a variable in the current scope based on the name.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * (unnamed) (List<Player>)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 * (unnamed) (List<Player>)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.List;

[Node("32837e14-12de-465f-89dc-ceddb64cdd6c")]
public class ListPlayerVariable : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "List<Player> Variable";
    public string GetVariableQualifiedName() => "listPlayerVariable";
}