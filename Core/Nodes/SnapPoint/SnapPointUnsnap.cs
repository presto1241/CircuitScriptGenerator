/*
 * Filename: SnapPointUnsnap.cs
 * Category: Snap Point
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Unsnaps a snap point from whatever it is snapped to. Returns true if an unsnap occured.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Snap Point (Snap Point)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 * Snap Successful (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.SnapPoint;

[Node("8ce5df0a-afee-4e1c-841e-57d7773cba93")]
public class SnapPointUnsnap : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Snap Point Unsnap";
    public string GetVariableQualifiedName() => "snapPointUnsnap";
}