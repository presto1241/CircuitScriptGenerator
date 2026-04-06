/*
 * Filename: IfHasTag.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Runs Has Tag if the input object or player has the input tag, otherwise runs Does Not Have Tag
 * Types: (Player | Rec Room Object)
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (T)
 * Tag (string)
 *
 * OUTPUTS: 
 * Has Tag (exec)
 * Does Not Have Tag (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("f64272d9-4aca-4170-8dee-bb711d97921c")]
public class IfHasTag : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "If Has Tag";
    public string GetVariableQualifiedName() => "ifHasTag";
}