/*
 * Filename: VelocitySetDeprecated.cs
 * Category: Physics
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Momentarily sets the velocity of the input target in the input direction. The input velocity will be multiplied by the magnitude of the vector provided in the input direction.
 * Types: (Player | Rec Room Object)
 * 
 * INPUTS: 
 * Velocity Impulse (exec)
 * Target (T)
 * Speed (m/s) (float)
 * Direction (Vector3)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Physics;

[Node("f97c530d-03bf-498c-8854-33e814d2600b")]
public class VelocitySetDeprecated : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Velocity Set (Deprecated)";
    public string GetVariableQualifiedName() => "velocitySetDeprecated";
}