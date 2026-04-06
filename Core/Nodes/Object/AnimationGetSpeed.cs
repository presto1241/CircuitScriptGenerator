/*
 * Filename: AnimationGetSpeed.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the normalized speed of the given Animation Controller.
 * Types: 
 * 
 * INPUTS: 
 * Animator (Animation Controller)
 *
 * OUTPUTS: 
 * Speed (float)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("e73794bd-fd60-4284-90ca-f5169700fa23")]
public class AnimationGetSpeed : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Animation Get Speed";
    public string GetVariableQualifiedName() => "animationGetSpeed";
}