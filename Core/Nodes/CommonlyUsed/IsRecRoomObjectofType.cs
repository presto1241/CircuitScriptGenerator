/*
 * Filename: IsRecRoomObjectofType.cs
 * Category: Commonly Used
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns true if the object is of the selected Rec Room object type; otherwise, returns false.
 * Types: 
 * 
 * INPUTS: 
 * Target (Rec Room Object)
 *
 * OUTPUTS: 
 * Is Type (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.CommonlyUsed;

[Node("20d2d51a-f2ec-4d98-9044-eb8381fb3fe5")]
public class IsRecRoomObjectofType : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Is Rec Room Object of Type";
    public string GetVariableQualifiedName() => "isRecRoomObjectofType";
}