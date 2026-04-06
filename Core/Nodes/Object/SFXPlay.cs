/*
 * Filename: SFXPlay.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Plays a sound from an SFX object.
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

[Node("5f8991bb-d1b8-4c74-a54a-86e7033b53a0")]
public class SFXPlay : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "SFX Play";
    public string GetVariableQualifiedName() => "sFXPlay";
}