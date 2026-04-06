/*
 * Filename: LocomotionRequestJumpCutoff.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Request that the local player's jump is cancelled or shortened.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("584c70a5-5bd1-448c-9dfa-45a0461481ef")]
public class LocomotionRequestJumpCutoff : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Locomotion Request Jump Cutoff";
    public string GetVariableQualifiedName() => "locomotionRequestJumpCutoff";
}