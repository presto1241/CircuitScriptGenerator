/*
 * Filename: GetPosition.cs
 * Category: Physics
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Outputs the position of the input object as a vector3.
 * Types: (AI | Combatant | Rec Room Object | Player)
 * 
 * INPUTS: 
 * Target (T)
 *
 * OUTPUTS: 
 * Position (Vector3)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Physics;

[Node("5f6a8ee8-8a87-4da2-851f-fda89cc62344")]
public class GetPosition : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Get Position";
    public string GetVariableQualifiedName() => "getPosition";
}