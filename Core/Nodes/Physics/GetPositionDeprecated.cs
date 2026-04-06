/*
 * Filename: GetPositionDeprecated.cs
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

[Node("a8c52ef2-17bf-47e6-9084-3e5623584b48")]
public class GetPositionDeprecated : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Get Position (Deprecated)";
    public string GetVariableQualifiedName() => "getPositionDeprecated";
}