/*
 * Filename: SetHUDElementValue.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets the current value of the target HUD Element
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (HUD Constant)
 * Value (int)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("61efbc78-9ddf-42bb-814a-3758a34f5faf")]
public class SetHUDElementValue : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Set HUD Element Value";
    public string GetVariableQualifiedName() => "setHUDElementValue";
}