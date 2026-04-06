/*
 * Filename: LocalPlayerSetObjectiveLogContent.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Set the content to be displayed on the Objective Log HUD UI
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Header Text (string)
 * Header Text Color (Color)
 * Body Text (string)
 * Body Text Color (Color)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("a060bad3-3111-4b9d-add3-5e6af3a4a151")]
public class LocalPlayerSetObjectiveLogContent : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Local Player Set Objective Log Content";
    public string GetVariableQualifiedName() => "localPlayerSetObjectiveLogContent";
}