/*
 * Filename: RotatorSetTargetRotation.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets the rotation of the Marker on a target Rotator in degrees.
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

[Node("0f9da436-0752-422d-8323-fa445a9ca06b")]
public class RotatorSetTargetRotation : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Rotator Set Target Rotation";
    public string GetVariableQualifiedName() => "rotatorSetTargetRotation";
}