/*
 * Filename: GrabberSetPlayerCanStealFromGrabber.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: On execution, the target grabber will lock or unlock the object being held. If true, the held object will interactable for a player to steal.  If false, the held object will not be interactable for a player to steal.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Grabber)
 * Enabled (bool)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("a02cf9d4-fa6b-41c7-bcbb-262489fa52ad")]
public class GrabberSetPlayerCanStealFromGrabber : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Grabber Set Player Can Steal From Grabber";
    public string GetVariableQualifiedName() => "grabberSetPlayerCanStealFromGrabber";
}