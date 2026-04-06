/*
 * Filename: AnimationSetTimeStamp.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets the time stamp of the given animation controller to the given time in seconds. The time stamp is not impacted by the animation speed.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Animator (Animation Controller)
 * Time Stamp (float)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("2cee5b7c-d9d1-455d-913c-10441527c798")]
public class AnimationSetTimeStamp : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Animation Set Time Stamp";
    public string GetVariableQualifiedName() => "animationSetTimeStamp";
}