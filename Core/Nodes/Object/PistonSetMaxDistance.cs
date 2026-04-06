/*
 * Filename: PistonSetMaxDistance.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets the max distance of a target Piston.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Piston)
 * Value (float)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("95431866-97f3-43b4-91f3-4bd3574b2b02")]
public class PistonSetMaxDistance : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Piston Set Max Distance";
    public string GetVariableQualifiedName() => "pistonSetMaxDistance";
}