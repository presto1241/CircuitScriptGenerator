/*
 * Filename: PlayerSetSteeringVelocity.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets the steering velocity for the given player.  
Steering Velocity should generally be modified via Locomotion Steering Request. 
Setting it directly may result in animation artifacts but can be done in special cases.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Player (Player)
 * Steering Velocity (Vector3)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("50968d3b-7692-4531-826b-8dbbfd4c38f9")]
public class PlayerSetSteeringVelocity : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Player Set Steering Velocity";
    public string GetVariableQualifiedName() => "playerSetSteeringVelocity";
}