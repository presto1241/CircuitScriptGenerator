/*
 * Filename: AILookAt.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Command an AI to look at the input target. If you want the AI to look in a passed in vector as a direction, set the “Look Target Is Direction” parameter to True. To make an AI stop looking, use the AI Stop Looking node.
 * Types: (AI | Combatant | Rec Room Object | Patrol Point | Player | Vector3)
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * AI (AI)
 * Look Target (T)
 * Look Target is Direction (bool)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("b5badf49-acfe-4a42-80e2-5262878e2d89")]
public class AILookAt : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "AI Look At";
    public string GetVariableQualifiedName() => "aILookAt";
}