/*
 * Filename: LightSetIntensity.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets the brightness level for a point light or a spotlight.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Light)
 * Intensity (float)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("aa6dc013-3f5b-45f4-87a2-8aa4d16cc375")]
public class LightSetIntensity : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Light Set Intensity";
    public string GetVariableQualifiedName() => "lightSetIntensity";
}