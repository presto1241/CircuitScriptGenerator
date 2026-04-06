/*
 * Filename: CreationObjectSetLocalScale.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets the local scale of the target object.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Rec Room Object)
 * Scale (float)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 * Success (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("530e25f3-2b87-43d0-990c-f4073234f6d7")]
public class CreationObjectSetLocalScale : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Creation Object Set Local Scale";
    public string GetVariableQualifiedName() => "creationObjectSetLocalScale";
}