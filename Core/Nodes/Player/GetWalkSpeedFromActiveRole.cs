/*
 * Filename: GetWalkSpeedFromActiveRole.cs
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

[Node("9efdf3b9-d1a7-4f7e-a8fa-acf682a4ca54")]
public class GetWalkSpeedFromActiveRole : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Get Walk Speed From Active Role";
    public string GetVariableQualifiedName() => "getWalkSpeedFromActiveRole";
}