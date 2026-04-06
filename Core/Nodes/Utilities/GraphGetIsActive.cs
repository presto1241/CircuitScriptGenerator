/*
 * Filename: GraphGetIsActive.cs
 * Category: Utilities
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns true if the current circuit graph is active. When inactive, circuit events will not run.
 * Types: 
 * 
 * INPUTS: 
 * 
 *
 * OUTPUTS: 
 * Is Active (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Utilities;

[Node("539cb9a4-39a4-4932-8f36-b249748cff9e")]
public class GraphGetIsActive : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Graph Get Is Active";
    public string GetVariableQualifiedName() => "graphGetIsActive";
}