/*
 * Filename: VelocityReflect.cs
 * Category: Physics
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: The input target's velocity parallel to the input direction vector is reflected along the input direction and velocities perpendicular to it, are maintained. The input velocity will be multiplied by the magnitude of the vector provided in the input direction.
 * Types: (Player | Rec Room Object)
 * 
 * INPUTS: 
 * Reflect Velocity (exec)
 * Target (T)
 * Additional Speed (m/s) (float)
 * Speed Multiplier (float)
 * Direction (Vector3)
 * Maximum Speed (m/s) (float)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Physics;

[Node("f0137efc-b3b7-4217-ba8b-1d2e78d451bd")]
public class VelocityReflect : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Velocity Reflect";
    public string GetVariableQualifiedName() => "velocityReflect";
}