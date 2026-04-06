/*
 * Filename: LightGetColor.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the color of the target light.
 * Types: 
 * 
 * INPUTS: 
 * Target (Light)
 *
 * OUTPUTS: 
 * Color (Color)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("bc45bb9f-619a-48c4-a3ed-14596c83424f")]
public class LightGetColor : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Light Get Color";
    public string GetVariableQualifiedName() => "lightGetColor";
}