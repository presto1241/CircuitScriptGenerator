/*
 * Filename: InstanceGetLifetime.cs
 * Category: Game Features
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the number of seconds since the current room instance was created.
 * Types: 
 * 
 * INPUTS: 
 * 
 *
 * OUTPUTS: 
 * Lifetime (float)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.GameFeatures;

[Node("e05bd0b5-bbcd-46d2-827c-063020bd9f1b")]
public class InstanceGetLifetime : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Instance Get Lifetime";
    public string GetVariableQualifiedName() => "instanceGetLifetime";
}