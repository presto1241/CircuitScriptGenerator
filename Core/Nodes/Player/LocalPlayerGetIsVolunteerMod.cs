/*
 * Filename: LocalPlayerGetIsVolunteerMod.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns true if the local player is a Volunteer Moderator.
 * Types: 
 * 
 * INPUTS: 
 * 
 *
 * OUTPUTS: 
 * Is Moderator (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("1a828a3d-5ad7-4a95-a848-a3666c3150c0")]
public class LocalPlayerGetIsVolunteerMod : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Local Player Get Is Volunteer Mod";
    public string GetVariableQualifiedName() => "localPlayerGetIsVolunteerMod";
}