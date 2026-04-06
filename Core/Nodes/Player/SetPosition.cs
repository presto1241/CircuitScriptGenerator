/*
 * Filename: SetPosition.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets the position of the target player or object. Will fail in the following cases: If the target object is currently held, select/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
 * Types: (Player | Rec Room Object)
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (T)
 * Position (Vector3)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 * Success (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("6e68ede8-32de-455f-9449-83951b4e4f73")]
public class SetPosition : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Set Position";
    public string GetVariableQualifiedName() => "setPosition";
}