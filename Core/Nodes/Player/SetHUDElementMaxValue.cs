/*
 * Filename: SetHUDElementMaxValue.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets the max value of the target HUD Element, if applicable
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

[Node("f258d689-3341-4383-a8f1-73ab7b2f37a1")]
public class SetHUDElementMaxValue : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Set HUD Element Max Value";
    public string GetVariableQualifiedName() => "setHUDElementMaxValue";
}