/*
 * Filename: AnimationStop.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Stops the Animation Controller. The Animation Controller restarts from the beginning next time play is activated.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Animator (Animation Controller)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("454c3ee3-5030-4a63-8ae9-1a0c61568f8c")]
public class AnimationStop : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Animation Stop";
    public string GetVariableQualifiedName() => "animationStop";
}