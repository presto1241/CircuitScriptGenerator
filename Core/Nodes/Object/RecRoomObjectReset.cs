/*
 * Filename: RecRoomObjectReset.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Resets an object.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Object (Rec Room Object)
 *
 * OUTPUTS: 
 * Reset Object (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("6ba175cf-493a-4790-b916-57259f94cd98")]
public class RecRoomObjectReset : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Rec Room Object Reset";
    public string GetVariableQualifiedName() => "recRoomObjectReset";
}