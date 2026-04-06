/*
 * Filename: PistonGetMaxDistance.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Outputs the max distance of the target Piston.
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

[Node("bb702e97-9f40-45cb-b35d-3a2193ab6800")]
public class PistonGetMaxDistance : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Piston Get Max Distance";
    public string GetVariableQualifiedName() => "pistonGetMaxDistance";
}