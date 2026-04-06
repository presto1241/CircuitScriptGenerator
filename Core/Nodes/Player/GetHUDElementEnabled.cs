/*
 * Filename: GetHUDElementEnabled.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns true if the local player has a HUD element of the given type currently enabled.
 * Types: 
 * 
 * INPUTS: 
 * Target (HUD Constant)
 *
 * OUTPUTS: 
 * Enabled (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("a970b2bd-0224-4b1e-9839-111315b28986")]
public class GetHUDElementEnabled : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Get HUD Element Enabled";
    public string GetVariableQualifiedName() => "getHUDElementEnabled";
}