/*
 * Filename: RemoteVideoPlayerGetIsPlaying.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: 
 * Types: 
 * 
 * INPUTS: 
 * Target (Remote Video Player)
 *
 * OUTPUTS: 
 * Is Playing (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("a4f4cc38-8df9-4b50-b877-b91ca2bf8519")]
public class RemoteVideoPlayerGetIsPlaying : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Remote Video Player Get Is Playing";
    public string GetVariableQualifiedName() => "remoteVideoPlayerGetIsPlaying";
}