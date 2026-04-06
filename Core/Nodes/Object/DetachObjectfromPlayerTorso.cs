/*
 * Filename: DetachObjectfromPlayerTorso.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Detaches a Rec Room Object from a player's torso if it is attached
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Player (Player)
 * Object To Detach (Rec Room Object)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 * Success (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("4185a205-99bc-4149-9ea3-2d927991087d")]
public class DetachObjectfromPlayerTorso : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Detach Object from Player Torso";
    public string GetVariableQualifiedName() => "detachObjectfromPlayerTorso";
}