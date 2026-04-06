/*
 * Filename: GunHandleGetCurrentAmmo.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Return the current ammo count of the target gun handle
 * Types: 
 * 
 * INPUTS: 
 * Target (Gun Handle)
 *
 * OUTPUTS: 
 * Ammo (int)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("9e2bb0fe-6179-4ffc-92df-6f3b43bca52d")]
public class GunHandleGetCurrentAmmo : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Gun Handle Get Current Ammo";
    public string GetVariableQualifiedName() => "gunHandleGetCurrentAmmo";
}