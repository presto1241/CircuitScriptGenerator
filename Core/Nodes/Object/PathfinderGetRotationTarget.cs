/*
 * Filename: PathfinderGetRotationTarget.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Gets the current pathing target (target direction, slowdown and arrival angles in degress) of the Pathfinder
 * Types: 
 * 
 * INPUTS: 
 * Pathfinder (Pathfinder)
 *
 * OUTPUTS: 
 * Target Direction (Vector3)
 * Slowdown Angle (float) - degrees
 * Arrival Angle (float) - degrees
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("0f6ac53c-d48b-4085-88b2-008a231c9716")]
public class PathfinderGetRotationTarget : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Pathfinder Get Rotation Target";
    public string GetVariableQualifiedName() => "pathfinderGetRotationTarget";
}