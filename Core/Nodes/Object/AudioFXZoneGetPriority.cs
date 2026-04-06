/*
 * Filename: AudioFXZoneGetPriority.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the priority of the target Audio FX Zone object.
 * Types: 
 * 
 * INPUTS: 
 * Target (Audio FX Zone)
 *
 * OUTPUTS: 
 * Priority (int)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("bbf3d871-ab5d-4405-ab53-aec19cdc6c8a")]
public class AudioFXZoneGetPriority : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Audio FX Zone Get Priority";
    public string GetVariableQualifiedName() => "audioFXZoneGetPriority";
}