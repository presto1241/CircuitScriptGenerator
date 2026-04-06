/*
 * Filename: GetSprintSpeedFromActiveRole.cs
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
 * (unnamed) (float)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("c69f1ca0-63f2-4f66-9848-38304941708f")]
public class GetSprintSpeedFromActiveRole : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Get Sprint Speed From Active Role";
    public string GetVariableQualifiedName() => "getSprintSpeedFromActiveRole";
}