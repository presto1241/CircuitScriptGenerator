/*
 * Filename: GetHUDElementMaxValue.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the max value of the target HUD Element
 * Types: 
 * 
 * INPUTS: 
 * Target (HUD Constant)
 *
 * OUTPUTS: 
 * Max Value (int)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("f59d4537-e8b4-4d19-b29f-d5203ce562af")]
public class GetHUDElementMaxValue : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Get HUD Element Max Value";
    public string GetVariableQualifiedName() => "getHUDElementMaxValue";
}