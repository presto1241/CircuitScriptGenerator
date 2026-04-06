/*
 * Filename: NavMeshCanPathBetween.cs
 * Category: Game Features
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Checks if a path exists between two positions using the NavMesh. 

Use "Max Distance" to indicate how far away from the NavMesh the positions can be. Lower values increase precision and can cause valid paths to register false if the target positions are not close enough to the NavMesh, while higher values decrease precision and can return a false positive if the margin is wide enough to include points that are not near the NavMesh.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Start Position (Vector3)
 * End Position (Vector3)
 * Max Distance (float)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 * Path Exists (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.GameFeatures;

[Node("42a50b22-bc74-4c79-8bd6-00f021f721b0")]
public class NavMeshCanPathBetween : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "NavMesh Can Path Between";
    public string GetVariableQualifiedName() => "navMeshCanPathBetween";
}