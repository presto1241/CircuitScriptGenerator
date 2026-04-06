/*
 * Filename: ShowPurchasePromptDeveloper.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Show player a purchase prompt for a Developer-Only Types. If called too many times sequentially, the purchase prompt will appear as a Watch notification, instead of as a popup.
 * Types: (Room Key | Consumable | Room Currency | GiftDrop Shop Item | Room Offer | RRO Storefront Item | Limited Time Bundle | Store Item)
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

[Node("ce7435ad-2630-4092-8cd3-0f60f71845c1")]
public class ShowPurchasePromptDeveloper : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Show Purchase Prompt (Developer)";
    public string GetVariableQualifiedName() => "showPurchasePromptDeveloper";
}