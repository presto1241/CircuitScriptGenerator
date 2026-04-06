/*
 * Filename: DialogueUISetIsEnabled.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Toggles whether or not the target Dialogue UI is enabled for the local player.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (DialogueUI)
 * Is Enabled (bool)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("a348af16-bd74-4da6-a3e1-1bf1e2456eba")]
public class DialogueUISetIsEnabled : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Dialogue UI Set Is Enabled";
    public string GetVariableQualifiedName() => "dialogueUISetIsEnabled";
}