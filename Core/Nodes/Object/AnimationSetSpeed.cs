/*
 * Filename: AnimationSetSpeed.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets the Animation Controller's play speed. Default value is 1. Negative values play the animation in reverse.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Animator (Animation Controller)
 * Speed (float)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("ca4d8318-ff8a-4c05-8628-2573d3c0ab4b")]
public class AnimationSetSpeed : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Animation Set Speed";
    public string GetVariableQualifiedName() => "animationSetSpeed";
}