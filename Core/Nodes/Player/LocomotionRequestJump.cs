/*
 * Filename: LocomotionRequestJump.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Request that the local player jumps.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Max Jump Height (float)
 * Direction (Vector3)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("33149283-60d0-4564-b989-db074573e857")]
public class LocomotionRequestJump : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Locomotion Request Jump";
    public string GetVariableQualifiedName() => "locomotionRequestJump";
}