/*
 * Filename: DoorSetLocked.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Set whether the target Door prop is locked or not
 * Types: 
 * 
 * INPUTS: 
 * Set Locked (exec)
 * Target (Room Door)
 * Locked (bool)
 *
 * OUTPUTS: 
 * Set Locked (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("7ca4abb2-d705-4c17-b713-7525122ef286")]
public class DoorSetLocked : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Door Set Locked";
    public string GetVariableQualifiedName() => "doorSetLocked";
}