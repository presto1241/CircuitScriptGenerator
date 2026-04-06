/*
 * Filename: PistonGetAcceleration.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Gets the acceleration of a piston.
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

[Node("5e002bc3-c667-441c-8098-4df2f956de5b")]
public class PistonGetAcceleration : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Piston Get Acceleration";
    public string GetVariableQualifiedName() => "pistonGetAcceleration";
}