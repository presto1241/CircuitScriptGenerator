/*
 * Filename: RaycastAll.cs
 * Category: Physics
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Fires an invisible ray from the "Start Position", in the "Direction" specified. Returns a list of all objects or players hit, with the ray penetrating through objects and players until it reaches its Max Distance. You can configure the chip itself to ignore players or objects specifically. Specific objects or players will not show up in this list twice (for example, if the ray goes through a player's arm and then hits their torso, only the first hit is returned). This can also detect hits with static Rec Room Studio objects in the Rec Room Studio Unity Scene, in which case both the Player and Object ports of the Collision Data will be invalid.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Start Position (Vector3)
 * Direction (Vector3)
 * Max Distance (m) (float)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 * Hits (List<Collision Data>)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Physics;

[Node("b3cde004-869b-45c3-aa92-940ca31cd3e7")]
public class RaycastAll : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Raycast All";
    public string GetVariableQualifiedName() => "raycastAll";
}