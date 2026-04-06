/*
 * Filename: AudioFXZoneSetPriority.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets the priority of the target Audio FX Zone object.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Audio FX Zone)
 * Priority (int)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("19605859-538d-4e1d-9d62-b00abb3e294a")]
public class AudioFXZoneSetPriority : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Audio FX Zone Set Priority";
    public string GetVariableQualifiedName() => "audioFXZoneSetPriority";
}