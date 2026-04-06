/*
 * Filename: AnimationGetIsPlaying.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns whether or not the Animation Controller is currently playing.
 * Types: 
 * 
 * INPUTS: 
 * Animator (Animation Controller)
 *
 * OUTPUTS: 
 * Playing (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("b45a0e10-189e-4211-b152-f04863d36e8c")]
public class AnimationGetIsPlaying : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Animation Get Is Playing";
    public string GetVariableQualifiedName() => "animationGetIsPlaying";
}