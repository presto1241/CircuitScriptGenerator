/*
 * Filename: TextSetColorId.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets the color for a Text object.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Text)
 * Color (int)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("20b2528d-96a9-4be8-9782-aa75959f5232")]
public class TextSetColorId : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Text Set Color Id";
    public string GetVariableQualifiedName() => "textSetColorId";
}