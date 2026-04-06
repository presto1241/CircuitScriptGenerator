/*
 * Filename: QuickChatTableSetEnabled.cs
 * Category: Game Features
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Enable or disable the specified Quick Chat Table for the specified player. If a different set of custom Quick Chat phrases is already enabled, this will overwrite it.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Quick Chat Table)
 * Player (Player)
 * Enabled (bool)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.GameFeatures;

[Node("e148e9c2-2fb9-4b80-9996-d07a2b7c0a01")]
public class QuickChatTableSetEnabled : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Quick Chat Table Set Enabled";
    public string GetVariableQualifiedName() => "quickChatTableSetEnabled";
}