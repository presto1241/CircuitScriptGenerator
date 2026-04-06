/*
 * Filename: BeaconGetEnabled.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Outputs True if the target Beacon object is enabled.
 * Types: 
 * 
 * INPUTS: 
 * Target (Beacon)
 *
 * OUTPUTS: 
 * Enabled (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("5646ab78-1388-44de-84a7-8c50f28cc88e")]
public class BeaconGetEnabled : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Beacon Get Enabled";
    public string GetVariableQualifiedName() => "beaconGetEnabled";
}