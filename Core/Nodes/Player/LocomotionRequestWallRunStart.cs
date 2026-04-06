/*
 * Filename: LocomotionRequestWallRunStart.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Request that the local player begin to wall run. Only works if called via an exec line from the WallRunReady event.  
Not affected by CanWallRun. If you want that property to impact this request you should check it yourself.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Gravity Multiplier (float)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("13989690-57a9-432f-b79d-9e8a33c9888b")]
public class LocomotionRequestWallRunStart : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Locomotion Request Wall Run Start";
    public string GetVariableQualifiedName() => "locomotionRequestWallRunStart";
}