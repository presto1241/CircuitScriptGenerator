/*
 * Filename: PlayerVariable.cs
 * Category: Variable
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Reads or writes a variable in the current scope based on the name.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * (unnamed) (Player)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 * (unnamed) (Player)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Variable;

[Node("ea61960b-3a53-426e-b87c-f0e94dd2c3da")]
public class PlayerVariable : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Player Variable";
    public string GetVariableQualifiedName() => "playerVariable";
}