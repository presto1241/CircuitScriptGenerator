/*
 * Filename: HasTag.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Outputs True if the input object or player has the input tag.
 * Types: (Player | Rec Room Object)
 * 
 * INPUTS: 
 * Target (T)
 * Tag (string)
 *
 * OUTPUTS: 
 * Has Tag (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("bc3011d2-c085-490e-a450-195ff3a27009")]
public class HasTag : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Has Tag";
    public string GetVariableQualifiedName() => "hasTag";
}