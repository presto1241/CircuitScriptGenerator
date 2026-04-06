/*
 * Filename: ShowPurchasePrompt.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Shows the item details for a given UGC Purchasable (e.g. a Room Offer) by opening the target player's watch
 * Types: Room Offer
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * In-Room Purchasable (T)
 * Player (Player)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("53a17ff2-a6fe-4b69-adb0-1b1fdf5a7de0")]
public class ShowPurchasePrompt : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Show Purchase Prompt";
    public string GetVariableQualifiedName() => "showPurchasePrompt";
}