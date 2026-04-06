/*
 * Filename: GunHandleGetIsReloading.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Return whether the target gun handle is in the process of reloading
 * Types: 
 * 
 * INPUTS: 
 * Target (Gun Handle)
 *
 * OUTPUTS: 
 * Is Reloading (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("f3ef0346-e593-47c9-85f0-f551efe0a9b6")]
public class GunHandleGetIsReloading : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Gun Handle Get Is Reloading";
    public string GetVariableQualifiedName() => "gunHandleGetIsReloading";
}