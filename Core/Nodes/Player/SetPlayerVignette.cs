/*
 * Filename: SetPlayerVignette.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Apply a vignette of the given color to the given player. The vignette will be displayed at the given intensity for the given duration, and then fade out. The intensity must be between 0 and 1.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Player (Player)
 * Time (float)
 * Color (Color)
 * Intensity (float)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("fee486b2-823f-4110-b33a-241adb59b634")]
public class SetPlayerVignette : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Set Player Vignette";
    public string GetVariableQualifiedName() => "setPlayerVignette";
}