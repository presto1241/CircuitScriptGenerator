/*
 * Filename: CreationObjectGetWorldScale.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Gets the world scale of the target object.
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

[Node("9eef1937-f45d-47ff-b3d9-c4d3b691027c")]
public class CreationObjectGetWorldScale : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Creation Object Get World Scale";
    public string GetVariableQualifiedName() => "creationObjectGetWorldScale";
}