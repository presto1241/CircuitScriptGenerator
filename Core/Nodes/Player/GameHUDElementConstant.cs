/*
 * Filename: GameHUDElementConstant.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Defines an element of the Game HUD, which can then be modified with the other HUD chips
 * Types: 
 * 
 * INPUTS: 
 * 
 *
 * OUTPUTS: 
 * (unnamed) (HUD Element)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("4a3c3d38-f1a4-493b-977f-5444ab2d404b")]
public class GameHUDElementConstant : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Game HUD Element Constant";
    public string GetVariableQualifiedName() => "gameHUDElementConstant";
}