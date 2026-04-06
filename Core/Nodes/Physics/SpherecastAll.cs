/*
 * Filename: SpherecastAll.cs
 * Category: Physics
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Fires an invisible sphere of the specified Radius from the Start Position, in the Direction specified. Returns a list of all objects or players hit, with the sphere penetrating through objects and players until it reaches its Max Distance. You can configure the chip itself to ignore players or objects specifically. Specific objects or players will not show up in this list twice (for example, if the sphere goes through a player's arm and then hits their torso, only the first hit is returned). This can also detect hits with static Rec Room Studio objects in the Rec Room Studio Unity Scene, in which case both the Player and Object ports of the Collision Data will be invalid.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Start Position (Vector3)
 * Radius (float)
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

[Node("7ddd732f-c1a2-40a9-9006-cd6ca37ffb4f")]
public class SpherecastAll : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Spherecast All";
    public string GetVariableQualifiedName() => "spherecastAll";
}