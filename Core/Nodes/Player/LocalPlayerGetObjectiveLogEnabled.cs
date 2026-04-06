/*
 * Filename: LocalPlayerGetObjectiveLogEnabled.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Get if the Objective Log HUD UI is currently enabled
 * Types: 
 * 
 * INPUTS: 
 * 
 *
 * OUTPUTS: 
 * Is Enabled (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("ab20a5af-2d16-494c-b376-0fb5d2c59258")]
public class LocalPlayerGetObjectiveLogEnabled : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Local Player Get Objective Log Enabled";
    public string GetVariableQualifiedName() => "localPlayerGetObjectiveLogEnabled";
}