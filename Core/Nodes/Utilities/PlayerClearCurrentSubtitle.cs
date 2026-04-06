/*
 * Filename: PlayerClearCurrentSubtitle.cs
 * Category: Utilities
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Clears any subtitle which is currently being displayed for the given player.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Player (Player)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Utilities;

[Node("a542e800-22c8-4e0b-ac4d-ea712875a5f8")]
public class PlayerClearCurrentSubtitle : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Player Clear Current Subtitle";
    public string GetVariableQualifiedName() => "playerClearCurrentSubtitle";
}