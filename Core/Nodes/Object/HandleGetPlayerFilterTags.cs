/*
 * Filename: HandleGetPlayerFilterTags.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Gets the tags that a handle is using in its Tag Filter. The Tag Filter must be enabled in the handle's configure menu for this to work.
 * Types: 
 * 
 * INPUTS: 
 * Target (Handle)
 *
 * OUTPUTS: 
 * Value (List<string>)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("37545ad5-40c3-49c0-9c32-1c4ccdd27f83")]
public class HandleGetPlayerFilterTags : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Handle Get Player Filter Tags";
    public string GetVariableQualifiedName() => "handleGetPlayerFilterTags";
}