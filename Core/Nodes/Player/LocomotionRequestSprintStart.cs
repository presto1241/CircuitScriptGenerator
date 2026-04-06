/*
 * Filename: LocomotionRequestSprintStart.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Used for custom locomotion in order to request starting a sprint. 
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

[Node("72e44053-7f7d-44f8-a45e-0d8eab06b13a")]
public class LocomotionRequestSprintStart : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Locomotion Request Sprint Start";
    public string GetVariableQualifiedName() => "locomotionRequestSprintStart";
}