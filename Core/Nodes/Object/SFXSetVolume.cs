/*
 * Filename: SFXSetVolume.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets the volume for an SFX object.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (SFX)
 * Value (int)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("d2df4993-d858-4df1-aca2-fc0e7f479668")]
public class SFXSetVolume : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "SFX Set Volume";
    public string GetVariableQualifiedName() => "sFXSetVolume";
}