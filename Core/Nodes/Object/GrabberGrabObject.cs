/*
 * Filename: GrabberGrabObject.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: On execution, the target Grabber will attempt to grab the specified object. If Steal From Player is true, it will steal the object from a player who has it held or holstered. If Snap to Grabber is true, the object will be moved to the Grabber’s position. If Snap to Grabber is false, the distance between Grabber and object at the moment of execution will be maintained until the object is released.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Grabber)
 * Object (Rec Room Object)
 * Steal from Player (bool)
 * Snap to Grabber (bool)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 * Success (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("36668004-5384-44df-901e-bd3324675838")]
public class GrabberGrabObject : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Grabber Grab Object";
    public string GetVariableQualifiedName() => "grabberGrabObject";
}