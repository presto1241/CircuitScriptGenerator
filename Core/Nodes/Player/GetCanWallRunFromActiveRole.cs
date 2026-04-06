/*
 * Filename: GetCanWallRunFromActiveRole.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: 
 * Types: 
 * 
 * INPUTS: 
 * Player (Player)
 *
 * OUTPUTS: 
 * Can Wall Run (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("268c621a-d8c2-42fe-8bf4-e66bc209c434")]
public class GetCanWallRunFromActiveRole : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Get Can Wall Run From Active Role";
    public string GetVariableQualifiedName() => "getCanWallRunFromActiveRole";
}