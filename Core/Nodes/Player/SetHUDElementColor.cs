/*
 * Filename: SetHUDElementColor.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets the color of the target HUD Element
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (HUD Constant)
 * Color (Color)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("47f61ea8-aab2-4b0e-8d59-351c0047d853")]
public class SetHUDElementColor : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Set HUD Element Color";
    public string GetVariableQualifiedName() => "setHUDElementColor";
}