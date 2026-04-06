/*
 * Filename: CustomConsumableCreateTrinketforLocalPlayer.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Creates a custom consumable trinket for the local player
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Mesh (RecNet Mesh)
 * Name (string)
 * Scale (float)
 * Quantity (int)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 * On Created (exec)
 * Success (bool)
 * Error Message (string)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("4332a655-27be-4f0a-8f5e-963736980241")]
public class CustomConsumableCreateTrinketforLocalPlayer : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Custom Consumable Create Trinket for Local Player";
    public string GetVariableQualifiedName() => "customConsumableCreateTrinketforLocalPlayer";
}