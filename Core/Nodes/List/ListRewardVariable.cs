/*
 * Filename: ListRewardVariable.cs
 * Category: List
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: A list of Rewards
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * (unnamed) (List<Reward>)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 * (unnamed) (List<Reward>)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.List;

[Node("40a49ce8-a734-4e3e-bb59-00a4698a942e")]
public class ListRewardVariable : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "List<Reward> Variable";
    public string GetVariableQualifiedName() => "listRewardVariable";
}