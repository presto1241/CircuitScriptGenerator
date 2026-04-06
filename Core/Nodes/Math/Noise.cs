/*
 * Filename: Noise.cs
 * Category: Math
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Samples a 3D Perlin noise field and returns a value usually bounded in [0,1].
 * Types: 
 * 
 * INPUTS: 
 * Point (Vector3)
 *
 * OUTPUTS: 
 * Result (float)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Math;

[Node("06f8732b-b1cb-4b79-815e-5b389c1dd78f")]
public class Noise : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Noise";
    public string GetVariableQualifiedName() => "noise";
}