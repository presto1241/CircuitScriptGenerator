/*
 * Filename: RecRoomObjectGetRootObject.cs
 * Category: Misc
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns a reference to the root object of the target object's hierarchy. 
 * Types: 
 * 
 * INPUTS: 
 * Target Object (Rec Room Object)
 *
 * OUTPUTS: 
 * Root Object (Rec Room Object)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Misc;

[Node("a2e31d7e-b107-49c1-a060-e9c417e8c59d")]
public class RecRoomObjectGetRootObject : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Rec Room Object Get Root Object";
    public string GetVariableQualifiedName() => "recRoomObjectGetRootObject";
}