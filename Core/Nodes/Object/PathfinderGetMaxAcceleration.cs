/*
 * Filename: PathfinderGetMaxAcceleration.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Gets the maximum acceleration of the Pathfinder, in meters per second squared
 * Types: 
 * 
 * INPUTS: 
 * Pathfinder (Pathfinder)
 *
 * OUTPUTS: 
 * Max Acceleration (float)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("af786307-3e91-4321-af54-6d2da29b070e")]
public class PathfinderGetMaxAcceleration : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Pathfinder Get Max Acceleration";
    public string GetVariableQualifiedName() => "pathfinderGetMaxAcceleration";
}