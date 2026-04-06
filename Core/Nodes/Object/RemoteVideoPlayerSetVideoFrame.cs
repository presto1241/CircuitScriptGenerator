/*
 * Filename: RemoteVideoPlayerSetVideoFrame.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: 
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Remote Video Player)
 * Frame (int)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("8946ba19-a4f3-4bd4-a468-c27edde4c5c7")]
public class RemoteVideoPlayerSetVideoFrame : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Remote Video Player Set Video Frame";
    public string GetVariableQualifiedName() => "remoteVideoPlayerSetVideoFrame";
}