/*
 * Filename: RecRoomObjectUnsnap.cs
 * Category: Objects
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Unsnaps an object from anything it's snapped to. Returns true if any unsnaps occured.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Object (Rec Room Object)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 * Snap Successful (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Objects;

[Node("014b98aa-19d2-4dfa-92fc-951b6eaf9cad")]
public class RecRoomObjectUnsnap : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Rec Room Object Unsnap";
    public string GetVariableQualifiedName() => "recRoomObjectUnsnap";
}