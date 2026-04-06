/*
 * Filename: AnimationPlay.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Tells the Animation Controller to play its animation using the Playback Mode set in the Animation Controller's configuration menu.
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

[Node("c2dc73dd-5317-45bf-892a-46864b468960")]
public class AnimationPlay : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Animation Play";
    public string GetVariableQualifiedName() => "animationPlay";
}