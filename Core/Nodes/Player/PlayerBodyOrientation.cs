/*
 * Filename: PlayerBodyOrientation.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Outputs the rotation of a Player's body.
 * Types: 
 * 
 * INPUTS: 
 * Target (Player)
 *
 * OUTPUTS: 
 * Quaternion (Quaternion)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("d5f0503f-eee6-4a2a-811d-33ead7122bd3")]
public class PlayerBodyOrientation : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Player Body Orientation";
    public string GetVariableQualifiedName() => "playerBodyOrientation";
}