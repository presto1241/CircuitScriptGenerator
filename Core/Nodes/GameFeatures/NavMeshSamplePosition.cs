/*
 * Filename: NavMeshSamplePosition.cs
 * Category: Game Features
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the nearest point on the navmesh to the SourcePosition, but stops searching at MaxDistance. Must have NavMesh enabled in Room Settings
 * Types: 
 * 
 * INPUTS: 
 * SourcePosition (Vector3)
 * MaxDistance (float)
 *
 * OUTPUTS: 
 * IsValid (bool)
 * HitPosition (Vector3)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.GameFeatures;

[Node("ebacb9b5-adb0-4f5b-94c4-973e89d30a65")]
public class NavMeshSamplePosition : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "NavMesh Sample Position";
    public string GetVariableQualifiedName() => "navMeshSamplePosition";
}