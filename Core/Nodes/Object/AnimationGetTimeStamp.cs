/*
 * Filename: AnimationGetTimeStamp.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the current time stamp of the given animation controller. The value is not impacted by the animation speed.
 * Types: 
 * 
 * INPUTS: 
 * Animator (Animation Controller)
 *
 * OUTPUTS: 
 * Time Stamp (float)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("19a1867b-8322-45b5-9971-c91b246663f3")]
public class AnimationGetTimeStamp : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Animation Get Time Stamp";
    public string GetVariableQualifiedName() => "animationGetTimeStamp";
}