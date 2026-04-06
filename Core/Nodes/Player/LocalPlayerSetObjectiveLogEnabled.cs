/*
 * Filename: LocalPlayerSetObjectiveLogEnabled.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Set whether the Objective Log HUD UI is enabled
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Enable (bool)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("5013021c-3243-4cc2-bd39-06abddb38c9c")]
public class LocalPlayerSetObjectiveLogEnabled : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Local Player Set Objective Log Enabled";
    public string GetVariableQualifiedName() => "localPlayerSetObjectiveLogEnabled";
}