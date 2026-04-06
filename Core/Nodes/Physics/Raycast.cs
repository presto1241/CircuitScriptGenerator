/*
 * Filename: Raycast.cs
 * Category: Physics
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Fires an invisible ray from the "Start Position", in the "Direction" specified. Returns True if any object or player is hit within the target "Max Distance". Otherwise, returns False. You can configure the chip itself to ignore players or objects specifically.
 * Types: 
 * 
 * INPUTS: 
 * Start Position (Vector3)
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

[Node("765190a1-0926-4d53-9c46-f9ae89748da9")]
public class Raycast : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Raycast";
    public string GetVariableQualifiedName() => "raycast";
}