/*
 * Filename: GunHandleApplyRecoil.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Apply immediate recoil to the target gun handle
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Gun Handle)
 * Angle X (float)
 * Angle Y (float)
 * Duration (float)
 * Return Duration (float)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("dca5d998-4ce5-4121-9915-bc4f54df595d")]
public class GunHandleApplyRecoil : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Gun Handle Apply Recoil";
    public string GetVariableQualifiedName() => "gunHandleApplyRecoil";
}