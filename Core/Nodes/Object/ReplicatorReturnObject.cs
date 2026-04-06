/*
 * Filename: ReplicatorReturnObject.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: If the target object was spawned by a replicator, it will be despawned and returned to the pool. If not, the chip will no-op.
 * Types: 
 * 
 * INPUTS: 
 * Run (exec)
 * Target (Rec Room Object)
 *
 * OUTPUTS: 
 * Run (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("c7d598f7-c8ea-4022-b0b3-a23356e71768")]
public class ReplicatorReturnObject : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Replicator Return Object";
    public string GetVariableQualifiedName() => "replicatorReturnObject";
}