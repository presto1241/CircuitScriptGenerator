/*
 * Filename: RootObject.cs
 * Category: Misc
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns a reference to the root object of the hierarchy in which this chip exists. If at room level, returns Invalid Object
 * Types: 
 * 
 * INPUTS: 
 * 
 *
 * OUTPUTS: 
 * Object (Rec Room Object)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Misc;

[Node("85be495b-0d08-421c-b20f-72b38967d34a")]
public class RootObject : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Root Object";
    public string GetVariableQualifiedName() => "rootObject";
}