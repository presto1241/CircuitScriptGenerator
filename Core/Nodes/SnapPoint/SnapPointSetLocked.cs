/*
 * Filename: SnapPointSetLocked.cs
 * Category: Snap Point
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets a snap point locked or unlocked. This means connections can't be made or broken.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Snap Point (Snap Point)
 * Locked (bool)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.SnapPoint;

[Node("322242e4-d953-4cde-9a4f-59dc605b4adc")]
public class SnapPointSetLocked : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Snap Point Set Locked";
    public string GetVariableQualifiedName() => "snapPointSetLocked";
}