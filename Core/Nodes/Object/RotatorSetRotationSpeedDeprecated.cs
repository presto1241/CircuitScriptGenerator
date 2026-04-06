/*
 * Filename: RotatorSetRotationSpeedDeprecated.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets the speed of a target Rotator.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Rotator)
 * Value (float)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("9d0e3cf5-581d-4fb5-8346-c9e7d9877b3f")]
public class RotatorSetRotationSpeedDeprecated : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Rotator Set Rotation Speed (Deprecated)";
    public string GetVariableQualifiedName() => "rotatorSetRotationSpeedDeprecated";
}