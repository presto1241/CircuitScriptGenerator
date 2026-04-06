/*
 * Filename: LightSetColorId.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets the color for a point light or a spotlight.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Light)
 * Color (int)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("2b6d9368-2ddc-41fb-ac14-b1a3561b19fc")]
public class LightSetColorId : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Light Set Color Id";
    public string GetVariableQualifiedName() => "lightSetColorId";
}