/*
 * Filename: Self.cs
 * Category: Utilities
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Outputs the object of the current context. For example, a self node inside a light outputs that specific light of the light type. This can only be placed inside an object board of a specific object or a player or object definition board.
 * Types: 
 * 
 * INPUTS: 
 * 
 *
 * OUTPUTS: 
 * (unnamed) (int)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Utilities;

[Node("3d7d40d6-885a-4fa5-bbaa-b19057291ddb")]
public class Self : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Self";
    public string GetVariableQualifiedName() => "self";
}