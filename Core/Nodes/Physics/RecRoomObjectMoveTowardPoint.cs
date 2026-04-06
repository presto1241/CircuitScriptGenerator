/*
 * Filename: RecRoomObjectMoveTowardPoint.cs
 * Category: Physics
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Move this Rec Room Object toward a given point, until within the close enough distance, using physics forces while maintaining an upright orientation.


Must be executed continuously in order to work, usually with Update or Update 30Hz.  It is recommended you pass in Delta Time from Update or Update 30Hz.


Useful for moving characters, creatures, enemies, NPCs, etc - any kind of object that should move like a player.


When the object comes in contact with the ground it will hover above the ground at a given hover height.  Low values like 0 or 0.1 will make the object appear to slide along the ground while higher values like 0.5 or 1.0 will make the object appear to fly.


Can either move along the ground or through the air based on depending on whether stick to ground is true or not.


Can either turn to face the direction it's moving or not depending on whether turn to face move direction is true or not.
 * Types: 
 * 
 * INPUTS: 
 * Move Toward Point (exec)
 * Target Object (Rec Room Object)
 * Target Point (Vector3)
 * Close Enough Distance (float)
 * Max Speed (float)
 * Acceleration Time (float)
 * Hover Height (float)
 * Delta Time (float)
 * Stick To Ground (bool)
 * Turn To Face Move Direction (bool)
 * Turn Speed Multiplier (float)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 * Has Arrived At Target Point (bool)
 * Is Near Ground (bool)
 * Ground Normal (Vector3)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Physics;

[Node("39325711-c419-4a32-8fd7-04c9bf43d512")]
public class RecRoomObjectMoveTowardPoint : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Rec Room Object Move (Toward Point)";
    public string GetVariableQualifiedName() => "recRoomObjectMoveTowardPoint";
}