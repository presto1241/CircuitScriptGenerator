/*
 * Filename: RemoteVideoPlayerGetVideoFrame.cs
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
 * Frame (int)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("2a3a8729-8faa-47ac-992e-94d2e391c30b")]
public class RemoteVideoPlayerGetVideoFrame : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Remote Video Player Get Video Frame";
    public string GetVariableQualifiedName() => "remoteVideoPlayerGetVideoFrame";
}