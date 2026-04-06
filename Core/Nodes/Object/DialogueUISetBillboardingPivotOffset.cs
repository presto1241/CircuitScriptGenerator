/*
 * Filename: DialogueUISetBillboardingPivotOffset.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets the Billboarding Pivot Offset on the target Dialogue.UI. This is used to allow a dialogue to billboard but also have it be placed next to a character and pivot around them.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (DialogueUI)
 * Offset (Vector3)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("beeef46e-fdb0-4842-ad97-be5271efe837")]
public class DialogueUISetBillboardingPivotOffset : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Dialogue UI Set Billboarding Pivot Offset";
    public string GetVariableQualifiedName() => "dialogueUISetBillboardingPivotOffset";
}