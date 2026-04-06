/*
 * Filename: DetachAllObjectsfromPlayerTorso.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Detach all Rec Room Objects that are currently attached to a player's torso
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Player (Player)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("a35f7049-2b92-4cb5-8bac-b503f6a264d2")]
public class DetachAllObjectsfromPlayerTorso : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Detach All Objects from Player Torso";
    public string GetVariableQualifiedName() => "detachAllObjectsfromPlayerTorso";
}