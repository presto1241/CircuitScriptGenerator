/*
 * Filename: GetHUDElementColor.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the color of the target HUD Element
 * Types: 
 * 
 * INPUTS: 
 * Target (HUD Constant)
 *
 * OUTPUTS: 
 * Color (Color)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("119d2860-e05c-4140-ba5f-c24139b78652")]
public class GetHUDElementColor : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Get HUD Element Color";
    public string GetVariableQualifiedName() => "getHUDElementColor";
}