/*
 * Filename: DoorGetLocked.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns whether the target Door prop is set to Locked 
 * Types: 
 * 
 * INPUTS: 
 * Target (Room Door)
 *
 * OUTPUTS: 
 * Locked (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("f2918d8a-444c-429d-ab79-e2d445695a57")]
public class DoorGetLocked : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Door Get Locked";
    public string GetVariableQualifiedName() => "doorGetLocked";
}