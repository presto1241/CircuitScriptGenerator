/*
 * Filename: PistonSetSpeedDeprecated.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets the speed of a target Piston.
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

[Node("419d2d2f-18f8-4223-b2f7-a7d1450c242c")]
public class PistonSetSpeedDeprecated : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Piston Set Speed (Deprecated)";
    public string GetVariableQualifiedName() => "pistonSetSpeedDeprecated";
}