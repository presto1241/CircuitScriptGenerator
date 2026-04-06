/*
 * Filename: LightSetEnabled.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets whether or not a Light is enabled and will emit light.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Light)
 * Enabled (bool)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("e30a20e6-8c98-4c9c-b0bc-bf8b0e11a74f")]
public class LightSetEnabled : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Light Set Enabled";
    public string GetVariableQualifiedName() => "lightSetEnabled";
}