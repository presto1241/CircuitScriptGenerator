/*
 * Filename: LightGetSoftness.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the softness value of the target light.
 * Types: 
 * 
 * INPUTS: 
 * Target (Light)
 *
 * OUTPUTS: 
 * Softness (float)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("afc674dc-06b5-44fc-9d01-95d8ca56db41")]
public class LightGetSoftness : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Light Get Softness";
    public string GetVariableQualifiedName() => "lightGetSoftness";
}