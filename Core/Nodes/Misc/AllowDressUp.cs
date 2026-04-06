/*
 * Filename: AllowDressUp.cs
 * Category: Misc
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Allow the local player from trying on unowned avatar items in the current room
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Misc;

[Node("e6744dfb-fcba-4b8c-ad87-9fc639fb9153")]
public class AllowDressUp : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Allow Dress-Up";
    public string GetVariableQualifiedName() => "allowDressUp";
}