/*
 * Filename: AngularVelocityAddDeprecated.cs
 * Category: Physics
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: 
 * Types: (Vector3 | Quaternion)
 * 
 * INPUTS: 
 * Add Velocity (exec)
 * Target (Rec Room Object)
 * Rotation (T)
 * Velocity Multiplier (float)
 * Max Angular Velocity Applied (deg/s) (float)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Physics;

[Node("87f6886f-fa2b-4961-b0ed-c8014aadc56b")]
public class AngularVelocityAddDeprecated : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Angular Velocity Add (Deprecated)";
    public string GetVariableQualifiedName() => "angularVelocityAddDeprecated";
}