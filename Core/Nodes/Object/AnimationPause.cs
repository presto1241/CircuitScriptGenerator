/*
 * Filename: AnimationPause.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Pauses the Animation Controller. The Animation Controller resumes at the same moment next time play is activated.
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

[Node("16144990-d5b0-4143-83f2-0df3cd30b3f2")]
public class AnimationPause : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Animation Pause";
    public string GetVariableQualifiedName() => "animationPause";
}