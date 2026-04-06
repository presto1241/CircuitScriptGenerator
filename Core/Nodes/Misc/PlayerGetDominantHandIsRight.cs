/*
 * Filename: PlayerGetDominantHandIsRight.cs
 * Category: Misc
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns true if the given player has their right hand set as dominant.
 * Types: 
 * 
 * INPUTS: 
 * Player (Player)
 *
 * OUTPUTS: 
 * Result (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Misc;

[Node("2cc92be4-ca23-4148-88d6-71cfb9b7fd58")]
public class PlayerGetDominantHandIsRight : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Player Get Dominant Hand Is Right";
    public string GetVariableQualifiedName() => "playerGetDominantHandIsRight";
}