/*
 * Filename: AngularVelocitySetDeprecated.cs
 * Category: Physics
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: 
 * Types: (Vector3 | Quaternion)
 * 
 * INPUTS: 
 * Set Velocity (exec)
 * Target (Rec Room Object)
 * Rotation (T)
 * Velocity Multiplier (float)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Physics;

[Node("98b24bc7-32d8-4386-9348-d44ad00d7702")]
public class AngularVelocitySetDeprecated : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Angular Velocity Set (Deprecated)";
    public string GetVariableQualifiedName() => "angularVelocitySetDeprecated";
}