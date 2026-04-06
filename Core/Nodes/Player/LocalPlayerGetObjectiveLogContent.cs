/*
 * Filename: LocalPlayerGetObjectiveLogContent.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Get the current displayed content on the Objective Log HUD UI
 * Types: 
 * 
 * INPUTS: 
 * 
 *
 * OUTPUTS: 
 * Header Text (string)
 * Header Text Color (Color)
 * Body Text (string)
 * Body Text Color (Color)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("809ba66c-8877-4d74-ac4b-2d0730a1b576")]
public class LocalPlayerGetObjectiveLogContent : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Local Player Get Objective Log Content";
    public string GetVariableQualifiedName() => "localPlayerGetObjectiveLogContent";
}