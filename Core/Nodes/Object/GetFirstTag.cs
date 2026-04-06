/*
 * Filename: GetFirstTag.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Gets the first tag of an object or player.
 * Types: (Player | Rec Room Object)
 * 
 * INPUTS: 
 * Target (T)
 *
 * OUTPUTS: 
 * Tag (string)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("cb909206-8627-4c66-ac8d-47b1a046ef8b")]
public class GetFirstTag : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Get First Tag";
    public string GetVariableQualifiedName() => "getFirstTag";
}