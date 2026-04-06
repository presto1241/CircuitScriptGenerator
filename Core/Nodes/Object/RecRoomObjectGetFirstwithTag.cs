/*
 * Filename: RecRoomObjectGetFirstwithTag.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Gets the first object with the input tag.
 * Types: 
 * 
 * INPUTS: 
 * Tag (string)
 *
 * OUTPUTS: 
 * Object (Rec Room Object)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("43ff2d3c-c3aa-45bc-a7b7-01587c8a61f6")]
public class RecRoomObjectGetFirstwithTag : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Rec Room Object Get First with Tag";
    public string GetVariableQualifiedName() => "recRoomObjectGetFirstwithTag";
}