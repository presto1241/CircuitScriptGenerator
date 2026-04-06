/*
 * Filename: PistonGetTargetDistance.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Outputs the set distance of the Marker on a target Piston.
 * Types: 
 * 
 * INPUTS: 
 * Target (Piston)
 *
 * OUTPUTS: 
 * Value (float)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("639a360e-aeb1-4c5d-8bc1-96bfaea8aef2")]
public class PistonGetTargetDistance : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Piston Get Target Distance";
    public string GetVariableQualifiedName() => "pistonGetTargetDistance";
}