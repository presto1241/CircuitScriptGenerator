/*
 * Filename: SetHUDElementContent.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Override all Game HUD Element properties using default values from Game HUD Element Constant input
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (HUD Constant) - Constant values to be applied to the HUD element
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("31295d8e-f416-4c44-b0bd-2eda32200365")]
public class SetHUDElementContent : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Set HUD Element Content";
    public string GetVariableQualifiedName() => "setHUDElementContent";
}