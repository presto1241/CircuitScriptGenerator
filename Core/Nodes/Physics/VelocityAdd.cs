/*
 * Filename: VelocityAdd.cs
 * Category: Physics
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Adds velocity to the input target. The input velocity will be multiplied by the magnitude of the vector provided in the input direction.
 * Types: (Player | Rec Room Object)
 * 
 * INPUTS: 
 * Add Velocity (exec)
 * Target (T)
 * Multiplier (float)
 * Velocity (m/s) (Vector3)
 * Maximum Speed (m/s) (float)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Physics;

[Node("f94206bd-1903-492f-85fc-07f8f756b9f5")]
public class VelocityAdd : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Velocity Add";
    public string GetVariableQualifiedName() => "velocityAdd";
}