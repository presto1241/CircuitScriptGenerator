/*
 * Filename: QuickChatTable.cs
 * Category: Game Features
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Configure this constant to add a set of custom Quick Chat phrases to your room, and enable them per-player with Quick Chat Table Set Enabled. Chat options will appear in the Quick Chat > This Room category.
 * Types: 
 * 
 * INPUTS: 
 * 
 *
 * OUTPUTS: 
 * (unnamed) (Quick Chat Table)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.GameFeatures;

[Node("ac6e433a-503a-4a18-a591-1fe2a2f276bb")]
public class QuickChatTable : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Quick Chat Table";
    public string GetVariableQualifiedName() => "quickChatTable";
}