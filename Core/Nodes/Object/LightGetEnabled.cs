/*
 * Filename: LightGetEnabled.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns True if the target light is emitting light.
 * Types: 
 * 
 * INPUTS: 
 * Target (Light)
 *
 * OUTPUTS: 
 * Enabled (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("d5eafcf1-1762-4ece-bc31-7e2eddac253e")]
public class LightGetEnabled : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Light Get Enabled";
    public string GetVariableQualifiedName() => "lightGetEnabled";
}