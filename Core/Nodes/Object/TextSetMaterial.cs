/*
 * Filename: TextSetMaterial.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets the material for a Text object.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Text)
 * Material (int)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("ef6fcf56-1b3f-42bc-af50-019ff0a9cfc5")]
public class TextSetMaterial : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Text Set Material";
    public string GetVariableQualifiedName() => "textSetMaterial";
}