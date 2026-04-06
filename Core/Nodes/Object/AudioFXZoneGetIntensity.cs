/*
 * Filename: AudioFXZoneGetIntensity.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the intensity of the target Audio FX Zone object.
 * Types: 
 * 
 * INPUTS: 
 * Target (Audio FX Zone)
 *
 * OUTPUTS: 
 * Intensity (float)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("26000298-f08f-4600-b100-3ee0076b2b63")]
public class AudioFXZoneGetIntensity : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Audio FX Zone Get Intensity";
    public string GetVariableQualifiedName() => "audioFXZoneGetIntensity";
}