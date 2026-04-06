/*
 * Filename: LocalPlayerTryUnequipMakerPen.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Attempts to unequip the Maker Pen from the local player. 'Success' will be false if the player is not currently holding the Maker Pen.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 * Success (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("98a4fbd2-fbce-4b95-b6e0-7fc52624da3c")]
public class LocalPlayerTryUnequipMakerPen : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Local Player Try Unequip Maker Pen";
    public string GetVariableQualifiedName() => "localPlayerTryUnequipMakerPen";
}