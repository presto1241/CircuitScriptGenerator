/*
 * Filename: ObjectiveMarkerGetTargetObject.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Objective Marker Get Target Object returns the object targeted by target Objective Marker, if it’s tracking an object. If target Objective Marker is not tracking an object, returns Invalid Object.
 * Types: 
 * 
 * INPUTS: 
 * Target (Objective Marker)
 *
 * OUTPUTS: 
 * Object (Rec Room Object)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("0a9761e3-44df-4ede-a1dd-6a8f4eb6a7c1")]
public class ObjectiveMarkerGetTargetObject : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Objective Marker Get Target Object";
    public string GetVariableQualifiedName() => "objectiveMarkerGetTargetObject";
}