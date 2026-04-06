/*
 * Filename: SFXStop.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Stops the sound currently playing from an SFX object.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (SFX)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("3ad57fda-1fab-4b00-81b3-71d61af37c65")]
public class SFXStop : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "SFX Stop";
    public string GetVariableQualifiedName() => "sFXStop";
}