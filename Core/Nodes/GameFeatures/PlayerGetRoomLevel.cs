/*
 * Filename: PlayerGetRoomLevel.cs
 * Category: Game Features
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the current Room Level of the specified player. Will not function correctly unless Room Progression is enabled in Room Settings.
 * Types: 
 * 
 * INPUTS: 
 * Player (Player)
 *
 * OUTPUTS: 
 * Level (int)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.GameFeatures;

[Node("475ba7d2-6031-4ea7-b7b8-11028971e466")]
public class PlayerGetRoomLevel : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Player Get Room Level";
    public string GetVariableQualifiedName() => "playerGetRoomLevel";
}