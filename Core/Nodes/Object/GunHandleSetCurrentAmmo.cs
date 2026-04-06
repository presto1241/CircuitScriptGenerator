/*
 * Filename: GunHandleSetCurrentAmmo.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Set the current ammo count of the target gun handle
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Gun Handle)
 * Ammo (int)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("75c94e14-2fd9-4097-93c4-ee5b56a27b64")]
public class GunHandleSetCurrentAmmo : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Gun Handle Set Current Ammo";
    public string GetVariableQualifiedName() => "gunHandleSetCurrentAmmo";
}