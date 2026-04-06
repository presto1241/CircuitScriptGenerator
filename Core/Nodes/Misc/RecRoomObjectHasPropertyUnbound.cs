/*
 * Filename: RecRoomObjectHasPropertyUnbound.cs
 * Category: Misc
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Used to detect whether the specified object has this property
 * Types: 
 * 
 * INPUTS: 
 * Target (Rec Room Object)
 *
 * OUTPUTS: 
 * Has Property (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Misc;

[Node("60de7c71-60c4-4f87-a592-af6446cef763")]
public class RecRoomObjectHasPropertyUnbound : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Rec Room Object Has Property (Unbound)";
    public string GetVariableQualifiedName() => "recRoomObjectHasPropertyUnbound";
}