/*
 * Filename: GunHandleGetSupportsReload.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Return whether reload is enabled for the current gun handle
 * Types: 
 * 
 * INPUTS: 
 * Target (Gun Handle)
 *
 * OUTPUTS: 
 * Can Reload (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("ec1f7c92-8484-4d00-b820-32726299f67a")]
public class GunHandleGetSupportsReload : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Gun Handle Get Supports Reload";
    public string GetVariableQualifiedName() => "gunHandleGetSupportsReload";
}