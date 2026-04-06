/*
 * Filename: CommunityEventVariable.cs
 * Category: Variable
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Reads or writes a variable that stores a Community Event. This variable is unique in the current scope based on its name, and defaults to an empty list
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * (unnamed) (Community Event)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 * (unnamed) (Community Event)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Variable;

[Node("355870c7-e058-4f34-8fcc-d0a8ef797fd6")]
public class CommunityEventVariable : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Community Event Variable";
    public string GetVariableQualifiedName() => "communityEventVariable";
}