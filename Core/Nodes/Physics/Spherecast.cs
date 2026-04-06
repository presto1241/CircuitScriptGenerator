/*
 * Filename: Spherecast.cs
 * Category: Physics
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Fires an invisible sphere of the specified Radius from the Start Position, in the Direction specified. Returns true if any object or player is hit within the target Max Distance. Otherwise, returns false. You can configure the chip itself to ignore players or objects specifically.
 * Types: 
 * 
 * INPUTS: 
 * Start Position (Vector3)
 * Radius (float)
 * Direction (Vector3)
 * Max Distance (m) (float)
 *
 * OUTPUTS: 
 * Hit (bool)
 * Player (Player)
 * Object (Rec Room Object)
 * Distance (float)
 * Hit Position (Vector3)
 * Surface Normal (Vector3)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Physics;

[Node("12bfc350-82f6-42a4-8e26-668e240e8fd2")]
public class Spherecast : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Spherecast";
    public string GetVariableQualifiedName() => "spherecast";
}