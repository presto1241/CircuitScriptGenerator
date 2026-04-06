/*
 * Filename: SetRotationinReferenceObjectSpace.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets the rotation of the target player or object in the coordinate space defined by the reference object. Fails if the target object is marked as static (as all child objects are by default) or if it or its parent is selected/frozen by the maker pen. Will also fail on players that are seated. 
 * Types: (Player | Rec Room Object)
 * 
 * INPUTS: 
 * Run (exec)
 * Target (T)
 * Rotation (U)
 * Reference Object (R)
 *
 * OUTPUTS: 
 * Run (exec)
 * Success (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("64319731-bdb8-4a19-ad65-8e9e7100c0bf")]
public class SetRotationinReferenceObjectSpace : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Set Rotation in Reference Object Space";
    public string GetVariableQualifiedName() => "setRotationinReferenceObjectSpace";
}