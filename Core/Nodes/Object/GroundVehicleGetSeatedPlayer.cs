/*
 * Filename: GroundVehicleGetSeatedPlayer.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the player sitting in the seat corresponding to the given index. Driver=0, Passenger=1, and back seats = 2 and 3.
 * Types: 
 * 
 * INPUTS: 
 * Target (Ground Vehicle)
 * Seat index (int)
 *
 * OUTPUTS: 
 * Player (Player)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("d150c8fa-91fd-4483-a8b5-ca6c62f2c648")]
public class GroundVehicleGetSeatedPlayer : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Ground Vehicle Get Seated Player";
    public string GetVariableQualifiedName() => "groundVehicleGetSeatedPlayer";
}