/*
 * Filename: GetHUDElementValue.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the current value of the target HUD Element
 * Types: 
 * 
 * INPUTS: 
 * Target (HUD Constant)
 *
 * OUTPUTS: 
 * Value (int)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("d9cbf25f-01c6-468f-8607-d1dd8317bb2f")]
public class GetHUDElementValue : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Get HUD Element Value";
    public string GetVariableQualifiedName() => "getHUDElementValue";
}