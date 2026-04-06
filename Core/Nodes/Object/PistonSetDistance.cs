/*
 * Filename: PistonSetDistance.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Moves the target piston to the input distance.
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

[Node("283cb154-76e8-4d60-9899-2a50b6e4c093")]
public class PistonSetDistance : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Piston Set Distance";
    public string GetVariableQualifiedName() => "pistonSetDistance";
}