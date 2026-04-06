/*
 * Filename: AnimationGetFrame.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the current frame of the given animation controller component.
 * Types: 
 * 
 * INPUTS: 
 * Animator (Animation Controller)
 *
 * OUTPUTS: 
 * Frame (int)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("5460ad14-4d51-4925-bd27-1ced46f10cb4")]
public class AnimationGetFrame : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Animation Get Frame";
    public string GetVariableQualifiedName() => "animationGetFrame";
}