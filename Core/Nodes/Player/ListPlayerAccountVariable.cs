/*
 * Filename: ListPlayerAccountVariable.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Stores a list of Player Accounts
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * (unnamed) (List<Player Account>)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 * (unnamed) (List<Player Account>)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("482165ef-dc08-4d2e-95fb-ca7ea30368dc")]
public class ListPlayerAccountVariable : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "List<Player Account> Variable";
    public string GetVariableQualifiedName() => "listPlayerAccountVariable";
}