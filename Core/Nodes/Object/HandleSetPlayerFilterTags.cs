/*
 * Filename: HandleSetPlayerFilterTags.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets the tags that a handle is using in its Tag Filter. The Tag Filter must be enabled in the handle's configure menu for this to work.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Handle)
 * Value (List<string>)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("fa0d31e8-149d-4554-9994-894cb3d79f3d")]
public class HandleSetPlayerFilterTags : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Handle Set Player Filter Tags";
    public string GetVariableQualifiedName() => "handleSetPlayerFilterTags";
}