/*
 * Filename: CollisionDataGetObject.cs
 * Category: Physics
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Gets object of a collision data (or null for players) returned from "Overlap Sphere" chip.
 * Types: 
 * 
 * INPUTS: 
 * Target (Collision Data)
 *
 * OUTPUTS: 
 * Object (Rec Room Object)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Physics;

[Node("8c8931da-1a8e-4164-a3a5-0f68db8cafb5")]
public class CollisionDataGetObject : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Collision Data Get Object";
    public string GetVariableQualifiedName() => "collisionDataGetObject";
}