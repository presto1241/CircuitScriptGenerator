/*
 * Filename: SnapPointSnapToSnapPoint.cs
 * Category: Snap Point
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Snaps one snap point to another. Returns true if the snap was successful, or false if not.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Snap From (Snap Point)
 * Snap To (Snap Point)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 * Snap Successful (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.SnapPoint;

[Node("0acec3ca-294c-4851-b5b9-6314aebc8a4e")]
public class SnapPointSnapToSnapPoint : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Snap Point Snap To Snap Point";
    public string GetVariableQualifiedName() => "snapPointSnapToSnapPoint";
}