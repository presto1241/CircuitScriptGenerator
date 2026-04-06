/*
 * Filename: RecRoomObjectTakeAuthority.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Takes authority of the input Rec Room Object.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Rec Room Object)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("bc3debb0-559c-4c9e-aefc-827b1c9ca1f2")]
public class RecRoomObjectTakeAuthority : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Rec Room Object Take Authority";
    public string GetVariableQualifiedName() => "recRoomObjectTakeAuthority";
}