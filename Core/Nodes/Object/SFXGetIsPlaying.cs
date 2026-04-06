/*
 * Filename: SFXGetIsPlaying.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns whether the target SFX component is currently playing
 * Types: 
 * 
 * INPUTS: 
 * Target (SFX)
 *
 * OUTPUTS: 
 * Value (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("a0a17fe1-bdb0-4687-81de-141ce97710ed")]
public class SFXGetIsPlaying : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "SFX Get Is Playing";
    public string GetVariableQualifiedName() => "sFXGetIsPlaying";
}