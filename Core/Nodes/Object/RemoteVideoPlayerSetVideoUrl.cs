/*
 * Filename: RemoteVideoPlayerSetVideoUrl.cs
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
 * Url (string)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("61b80006-778c-4c93-94f9-f64c5d135253")]
public class RemoteVideoPlayerSetVideoUrl : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Remote Video Player Set Video Url";
    public string GetVariableQualifiedName() => "remoteVideoPlayerSetVideoUrl";
}