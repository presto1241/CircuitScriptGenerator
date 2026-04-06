/*
 * Filename: GunHandleGetMaxAmmo.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Return the max ammo count of the target gun handle
 * Types: 
 * 
 * INPUTS: 
 * Target (Gun Handle)
 *
 * OUTPUTS: 
 * Max Ammo (int)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("0d6de11b-5487-4e61-9b4b-d6719b3aeb0f")]
public class GunHandleGetMaxAmmo : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Gun Handle Get Max Ammo";
    public string GetVariableQualifiedName() => "gunHandleGetMaxAmmo";
}