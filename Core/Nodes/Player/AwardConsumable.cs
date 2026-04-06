/*
 * Filename: AwardConsumable.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Award a room consumable to a player. Multiple award room consumable requests from the same client are sent in bulk with a ten-second cooldown. The Success port will be TRUE if the consumable was entirely, or in part, awarded to the player. If the consumable could not be awarded, the Success port will be FALSE. Use the Log Output toggle in the configuration settings to see more information about why a failure occurred. Logging output may impact room performance and should be toggled off when not in use.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Consumable (Consumable)
 * Player (Player)
 * Quantity (int)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 * On Award Consumable Complete (exec)
 * Success (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("9ceb3e5a-2030-4034-98a4-dc2809828b63")]
public class AwardConsumable : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Award Consumable";
    public string GetVariableQualifiedName() => "awardConsumable";
}