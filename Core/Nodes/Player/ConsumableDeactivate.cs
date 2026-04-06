/*
 * Filename: ConsumableDeactivate.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets the input consumable to inactive. Displays the consumable as not active in the backback and allow using another one.
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

[Node("6809978a-e1fc-403a-a41a-d4e94f22281f")]
public class ConsumableDeactivate : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Consumable Deactivate";
    public string GetVariableQualifiedName() => "consumableDeactivate";
}