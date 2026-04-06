/*
 * Filename: SwingHandleGetIsSwinging.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns whether the target Swing Handle is currently being swung
 * Types: 
 * 
 * INPUTS: 
 * Target (Swing Handle)
 *
 * OUTPUTS: 
 * Is Swinging (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("cdebca62-2e6c-4353-8691-d1daae868f5f")]
public class SwingHandleGetIsSwinging : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Swing Handle Get Is Swinging";
    public string GetVariableQualifiedName() => "swingHandleGetIsSwinging";
}