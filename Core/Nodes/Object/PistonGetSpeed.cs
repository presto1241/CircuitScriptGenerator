/*
 * Filename: PistonGetSpeed.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the speed of a piston.
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

[Node("1b8b2b6f-1568-438e-a5ff-117f7d9e6489")]
public class PistonGetSpeed : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Piston Get Speed";
    public string GetVariableQualifiedName() => "pistonGetSpeed";
}