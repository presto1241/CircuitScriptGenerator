/*
 * Filename: GunHandleSetMaxAmmo.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Set the max ammo count of the target gun handle
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Gun Handle)
 * Max Ammo (int)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("d0ace61e-9d6f-440a-839c-65a3e6aa1e9b")]
public class GunHandleSetMaxAmmo : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Gun Handle Set Max Ammo";
    public string GetVariableQualifiedName() => "gunHandleSetMaxAmmo";
}