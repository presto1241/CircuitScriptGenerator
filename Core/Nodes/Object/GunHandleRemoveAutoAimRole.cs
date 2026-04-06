/*
 * Filename: GunHandleRemoveAutoAimRole.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Remove the specified role from the target Gun Handle's auto-aim list, dependent on Gun Handle's settings.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Gun Handle)
 * Role (string)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("16e9da8d-137b-4b51-bc8c-12b32314363b")]
public class GunHandleRemoveAutoAimRole : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Gun Handle Remove Auto Aim Role";
    public string GetVariableQualifiedName() => "gunHandleRemoveAutoAimRole";
}