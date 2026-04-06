/*
 * Filename: LocalPlayerGetIsInfluencer.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns true if the local player is enrolled in the partnered video program.
 * Types: 
 * 
 * INPUTS: 
 * 
 *
 * OUTPUTS: 
 * Is Influencer (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("668c34ed-a2a1-47a3-8db2-e1861785f2c3")]
public class LocalPlayerGetIsInfluencer : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Local Player Get Is Influencer";
    public string GetVariableQualifiedName() => "localPlayerGetIsInfluencer";
}