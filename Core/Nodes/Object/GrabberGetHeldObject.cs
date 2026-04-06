/*
 * Filename: GrabberGetHeldObject.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns whether the Grabber is currently holding an object, and a reference to that object if so. If no object is held, returns Invalid Object.
 * Types: 
 * 
 * INPUTS: 
 * Target (Grabber)
 *
 * OUTPUTS: 
 * Has Held Object (bool)
 * Held Object (Rec Room Object)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("338a3300-ad0d-40d9-a9a7-ff57f5401905")]
public class GrabberGetHeldObject : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Grabber Get Held Object";
    public string GetVariableQualifiedName() => "grabberGetHeldObject";
}