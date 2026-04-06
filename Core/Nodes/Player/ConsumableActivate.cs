/*
 * Filename: ConsumableActivate.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets the input consumable to active. Use this to confirm a consumable used event. Can also be used independently. Displays the consumable as active in the backback and decreases the number of comsumables the player owns.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Consumable (Consumable)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("d7ea08ab-aee6-43d0-99e1-54478ac3db7f")]
public class ConsumableActivate : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Consumable Activate";
    public string GetVariableQualifiedName() => "consumableActivate";
}