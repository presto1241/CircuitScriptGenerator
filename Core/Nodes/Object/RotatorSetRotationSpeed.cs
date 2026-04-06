/*
 * Filename: RotatorSetRotationSpeed.cs
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

[Node("a2cce02f-f94e-4b17-a0e6-e795b8bc198c")]
public class RotatorSetRotationSpeed : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Rotator Set Rotation Speed";
    public string GetVariableQualifiedName() => "rotatorSetRotationSpeed";
}