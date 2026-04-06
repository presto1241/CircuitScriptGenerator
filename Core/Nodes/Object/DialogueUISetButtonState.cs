/*
 * Filename: DialogueUISetButtonState.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Set the visibility and text of up to four buttons on the target Dialogue UI for the local player. Text will truncate after 512 characters. Buttons are automatically interactive when enabled. Each button will fire a Button Pressed event in the Dialogue UI’s board scope when pressed. Button visibility is dependent on the Dialogue UI being enabled.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (DialogueUI)
 * Button 1 Enabled (bool)
 * Button 1 Text (string)
 * Button 2 Enabled (bool)
 * Button 2 Text (string)
 * Button 3 Enabled (bool)
 * Button 3 Text (string)
 * Button 4 Enabled (bool)
 * Button 4 Text (string)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("f4772dae-d4e3-489c-8943-8fe88160ab5c")]
public class DialogueUISetButtonState : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Dialogue UI Set Button State";
    public string GetVariableQualifiedName() => "dialogueUISetButtonState";
}