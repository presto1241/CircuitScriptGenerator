/*
 * Filename: GetJumpHeightFromActiveRole.cs
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
 * Max Jump Height (float)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("6a6a1490-6b2c-43f6-9ee7-fccb23a57b4b")]
public class GetJumpHeightFromActiveRole : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Get Jump Height From Active Role";
    public string GetVariableQualifiedName() => "getJumpHeightFromActiveRole";
}