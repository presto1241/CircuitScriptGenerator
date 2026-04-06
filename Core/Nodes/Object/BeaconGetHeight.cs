/*
 * Filename: BeaconGetHeight.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the height of the target Beacon object.
 * Types: 
 * 
 * INPUTS: 
 * Target (Beacon)
 *
 * OUTPUTS: 
 * Height (float)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("dbadcaaa-d673-4e35-bb29-c9c2a5c3d93e")]
public class BeaconGetHeight : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Beacon Get Height";
    public string GetVariableQualifiedName() => "beaconGetHeight";
}