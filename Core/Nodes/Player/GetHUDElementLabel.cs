/*
 * Filename: GetHUDElementLabel.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the label of the target HUD Element
 * Types: 
 * 
 * INPUTS: 
 * Target (HUD Constant)
 *
 * OUTPUTS: 
 * Label (string)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("98ef89de-7a1b-4043-8071-b5cda41030cd")]
public class GetHUDElementLabel : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Get HUD Element Label";
    public string GetVariableQualifiedName() => "getHUDElementLabel";
}