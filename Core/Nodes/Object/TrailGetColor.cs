/*
 * Filename: TrailGetColor.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the color of the target Motion Trail object.
 * Types: 
 * 
 * INPUTS: 
 * Target (Motion Trail)
 *
 * OUTPUTS: 
 * Color (Color)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("f8c16cc7-ceaf-471a-b196-5d46ec7ab72a")]
public class TrailGetColor : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Trail Get Color";
    public string GetVariableQualifiedName() => "trailGetColor";
}