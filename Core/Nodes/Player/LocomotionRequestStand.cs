/*
 * Filename: LocomotionRequestStand.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Requests that the local player stand.
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

[Node("b6169557-e604-47bf-b11b-939f53daf6e9")]
public class LocomotionRequestStand : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Locomotion Request Stand";
    public string GetVariableQualifiedName() => "locomotionRequestStand";
}