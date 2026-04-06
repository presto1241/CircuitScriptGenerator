/*
 * Filename: AISetPatrolPoint.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Set an AIs Path Point.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * AI (AI)
 * Patrol Point (Patrol Point)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("6370b8d9-8c72-4e6b-a623-acb7202a3110")]
public class AISetPatrolPoint : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "AI Set Patrol Point";
    public string GetVariableQualifiedName() => "aISetPatrolPoint";
}