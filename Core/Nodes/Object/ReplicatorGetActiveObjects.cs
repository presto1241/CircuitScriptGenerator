/*
 * Filename: ReplicatorGetActiveObjects.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the list of objects that have been spawned by the target replicator and are currently active.
 * Types: 
 * 
 * INPUTS: 
 * Target (Replicator)
 *
 * OUTPUTS: 
 * Active Objects (List<Rec Room Object>)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("8cb80c1a-3b88-4fc0-a1ff-8c069a57e726")]
public class ReplicatorGetActiveObjects : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Replicator Get Active Objects";
    public string GetVariableQualifiedName() => "replicatorGetActiveObjects";
}