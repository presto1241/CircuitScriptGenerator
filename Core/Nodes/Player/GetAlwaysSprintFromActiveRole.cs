/*
 * Filename: GetAlwaysSprintFromActiveRole.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: 
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (Player)
 *
 * OUTPUTS: 
 * (unnamed) (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("d7adce4f-12bf-4876-8ec2-fd0adf6d9197")]
public class GetAlwaysSprintFromActiveRole : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Get Always Sprint From Active Role";
    public string GetVariableQualifiedName() => "getAlwaysSprintFromActiveRole";
}