/*
 * Filename: TrailSetColor.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets the color of the target Motion Trail object.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Motion Trail)
 * Color (Color)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("d326ebc4-1653-4c1d-886c-c1bd4c06db86")]
public class TrailSetColor : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Trail Set Color";
    public string GetVariableQualifiedName() => "trailSetColor";
}