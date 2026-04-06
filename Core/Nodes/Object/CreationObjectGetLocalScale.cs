/*
 * Filename: CreationObjectGetLocalScale.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Gets the local scale of the target object.
 * Types: 
 * 
 * INPUTS: 
 * Target (Rec Room Object)
 *
 * OUTPUTS: 
 * Scale (float)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("cf8bcfa3-5715-403c-95c5-ab6c70e51863")]
public class CreationObjectGetLocalScale : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Creation Object Get Local Scale";
    public string GetVariableQualifiedName() => "creationObjectGetLocalScale";
}