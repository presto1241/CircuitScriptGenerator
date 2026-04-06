/*
 * Filename: RoomBackgroundObjectsClearPlayerOverride.cs
 * Category: Game Features
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Clears the given player's local room background objects state override.
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

[Node("b890f7ef-5126-401c-8d66-794e9b1bc2a5")]
public class RoomBackgroundObjectsClearPlayerOverride : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Room Background Objects Clear Player Override";
    public string GetVariableQualifiedName() => "roomBackgroundObjectsClearPlayerOverride";
}