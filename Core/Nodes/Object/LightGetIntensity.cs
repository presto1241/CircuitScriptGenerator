/*
 * Filename: LightGetIntensity.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the intensity of the target light.
 * Types: 
 * 
 * INPUTS: 
 * Target (Light)
 *
 * OUTPUTS: 
 * Intensity (float)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("67bf3eac-2273-4345-94b3-8288f63f9a0e")]
public class LightGetIntensity : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Light Get Intensity";
    public string GetVariableQualifiedName() => "lightGetIntensity";
}