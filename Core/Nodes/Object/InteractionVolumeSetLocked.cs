/*
 * Filename: InteractionVolumeSetLocked.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Disables or enables an Interaction Volume (but reversed).
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Interaction Volume)
 * Locked (bool)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("a1e57113-f0b5-45c5-b1e0-95163674daa4")]
public class InteractionVolumeSetLocked : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Interaction Volume Set Locked";
    public string GetVariableQualifiedName() => "interactionVolumeSetLocked";
}