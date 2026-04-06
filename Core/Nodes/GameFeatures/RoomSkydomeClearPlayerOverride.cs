/*
 * Filename: RoomSkydomeClearPlayerOverride.cs
 * Category: Game Features
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Clears the given player's local room skydome state override.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Player (Player)
 * Blend Time (float)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 * Blend Finished (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.GameFeatures;

[Node("de67b647-5c82-4875-a6c4-051768c27c32")]
public class RoomSkydomeClearPlayerOverride : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Room Skydome Clear Player Override";
    public string GetVariableQualifiedName() => "roomSkydomeClearPlayerOverride";
}