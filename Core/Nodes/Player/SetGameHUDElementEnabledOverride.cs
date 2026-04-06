/*
 * Filename: SetGameHUDElementEnabledOverride.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: On enable: true, sets the input Game HUD Element Constant values to the specified element and enables it. On enable: false, disables specified Game HUD element
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (HUD Constant) - Constant values to be applied to the HUD element
 * Enable (bool) - Make visible or not
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("fcee19ec-5d60-4c84-bc89-479c3cfd604f")]
public class SetGameHUDElementEnabledOverride : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Set Game HUD Element Enabled (Override)";
    public string GetVariableQualifiedName() => "setGameHUDElementEnabledOverride";
}