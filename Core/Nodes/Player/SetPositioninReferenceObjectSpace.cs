/*
 * Filename: SetPositioninReferenceObjectSpace.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets the position of the target player or object in the coordinate space defined by the reference object. Will fail in the following cases: If the target object is currently held, select/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
 * Types: (Player | Rec Room Object)
 * 
 * INPUTS: 
 * Run (exec)
 * Target (T)
 * Position (Vector3)
 * Reference Object (R)
 *
 * OUTPUTS: 
 * Run (exec)
 * Success (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("aae0e3a1-96d3-44df-816c-ce1e2ed34f56")]
public class SetPositioninReferenceObjectSpace : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Set Position in Reference Object Space";
    public string GetVariableQualifiedName() => "setPositioninReferenceObjectSpace";
}