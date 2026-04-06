/*
 * Filename: VelocitySet.cs
 * Category: Physics
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Momentarily sets the velocity of the input target in the input direction. The input velocity will be multiplied by the magnitude of the vector provided in the input direction.
 * Types: (Player | Rec Room Object)
 * 
 * INPUTS: 
 * Set Velocity (exec)
 * Target (T)
 * Multiplier (float)
 * Velocity (m/s) (Vector3)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Physics;

[Node("ea00c655-56ff-4406-8d65-b8399e6d0169")]
public class VelocitySet : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Velocity Set";
    public string GetVariableQualifiedName() => "velocitySet";
}