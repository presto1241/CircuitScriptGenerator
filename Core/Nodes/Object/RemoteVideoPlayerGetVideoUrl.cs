/*
 * Filename: RemoteVideoPlayerGetVideoUrl.cs
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
 * Url (string)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("dc362efa-2fb1-4aa0-85b5-b021f7c46dd0")]
public class RemoteVideoPlayerGetVideoUrl : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Remote Video Player Get Video Url";
    public string GetVariableQualifiedName() => "remoteVideoPlayerGetVideoUrl";
}