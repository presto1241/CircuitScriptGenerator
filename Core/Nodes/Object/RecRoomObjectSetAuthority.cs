/*
 * Filename: RecRoomObjectSetAuthority.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets the authority player of the input Rec Room Object.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Rec Room Object)
 * Authority (Player)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("191f8009-5a2e-4da4-8817-980842a08d48")]
public class RecRoomObjectSetAuthority : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Rec Room Object Set Authority";
    public string GetVariableQualifiedName() => "recRoomObjectSetAuthority";
}