/*
 * Filename: RecRoomObjectGetAttachedBodyPart.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Gets the body part and player a Rec Room Object is currently attached to.
 * Types: 
 * 
 * INPUTS: 
 * Object (Rec Room Object)
 *
 * OUTPUTS: 
 * Player (Player)
 * Body Part (Body Part)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("af75c332-22d0-42f4-8e17-34b018bd004a")]
public class RecRoomObjectGetAttachedBodyPart : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Rec Room Object Get Attached Body Part";
    public string GetVariableQualifiedName() => "recRoomObjectGetAttachedBodyPart";
}