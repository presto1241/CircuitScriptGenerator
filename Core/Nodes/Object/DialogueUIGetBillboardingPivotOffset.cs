/*
 * Filename: DialogueUIGetBillboardingPivotOffset.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the current Billboarding Pivot Offset on the target Dialogue.UI. This is used to allow a dialogue to billboard but also have it be placed next to a character and pivot around them.
 * Types: 
 * 
 * INPUTS: 
 * Target (DialogueUI)
 *
 * OUTPUTS: 
 * Billboarding Offset (Vector3)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("e0065ec4-332b-4b5d-8f60-70daa3a4af03")]
public class DialogueUIGetBillboardingPivotOffset : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Dialogue UI Get Billboarding Pivot Offset";
    public string GetVariableQualifiedName() => "dialogueUIGetBillboardingPivotOffset";
}