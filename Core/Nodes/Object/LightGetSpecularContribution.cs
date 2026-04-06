/*
 * Filename: LightGetSpecularContribution.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the specular contribution of the target light.
 * Types: 
 * 
 * INPUTS: 
 * Target (Light)
 *
 * OUTPUTS: 
 * Specular Contribution (float)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("b7e74ebc-9ed7-4302-abf1-d2fe42b92a6d")]
public class LightGetSpecularContribution : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Light Get Specular Contribution";
    public string GetVariableQualifiedName() => "lightGetSpecularContribution";
}