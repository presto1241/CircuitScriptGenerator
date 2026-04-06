/*
 * Filename: PlayerSetForceManualSprint.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets whether manual sprint is required for a given player.

Players can choose whether they want to use auto sprint in their settings.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Player (Player)
 * Force Manual Sprint (bool)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("25663723-fc4c-454f-9d33-d28120163245")]
public class PlayerSetForceManualSprint : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Player Set Force Manual Sprint";
    public string GetVariableQualifiedName() => "playerSetForceManualSprint";
}