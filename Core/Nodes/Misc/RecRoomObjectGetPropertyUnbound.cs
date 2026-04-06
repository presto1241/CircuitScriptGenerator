/*
 * Filename: RecRoomObjectGetPropertyUnbound.cs
 * Category: Misc
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Gets the current value of this property from the specified object. Will error if the object does not have this property, so use Has Property to verify first if there is any uncertainty
 * Types: 
 * 
 * INPUTS: 
 * Target (Rec Room Object)
 *
 * OUTPUTS: 
 * 
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Misc;

[Node("d5db3130-3013-4b9e-bfe8-d4861c9d219c")]
public class RecRoomObjectGetPropertyUnbound : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Rec Room Object Get Property (Unbound)";
    public string GetVariableQualifiedName() => "recRoomObjectGetPropertyUnbound";
}