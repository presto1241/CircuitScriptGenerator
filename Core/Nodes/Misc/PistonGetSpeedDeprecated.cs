/*
 * Filename: PistonGetSpeedDeprecated.cs
 * Category: Misc
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

namespace CircuitScriptGenerator.Core.Nodes.Misc;

[Node("1d989cd3-d6ae-4503-b80e-5e630ec3f308")]
public class PistonGetSpeedDeprecated : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Piston Get Speed (Deprecated)";
    public string GetVariableQualifiedName() => "pistonGetSpeedDeprecated";
}