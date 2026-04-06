/*
 * Filename: RequestVelocitySetOverDuration.cs
 * Category: Physics
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets the velocity of the input target, similar to Velocity Set, but reapplies every physics tick until either the input duration has elapsed, the authority of the input target has changed, or another impulsing CV2 chip has been executed against the same input target.
 * Types: (Player | Rec Room Object)
 * 
 * INPUTS: 
 * Request Set Velocity (exec)
 * Object (T)
 * Multiplier (float)
 * Velocity (m/s) (Vector3)
 * Duration (s) (float)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Physics;

[Node("73a26510-9160-4e68-93dc-da60aa68a514")]
public class RequestVelocitySetOverDuration : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Request Velocity Set Over Duration";
    public string GetVariableQualifiedName() => "requestVelocitySetOverDuration";
}