/*
 * Filename: TouchpadComponentGetActiveTouch.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Get the active touch position from the local player's interaction
 * Types: 
 * 
 * INPUTS: 
 * Target (Touchpad)
 *
 * OUTPUTS: 
 * Is Touch Active (bool)
 * Touch Position (Vector3)
 * World Position (Vector3)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("b83d2e2f-61e8-4490-8a81-d38c88fff8d1")]
public class TouchpadComponentGetActiveTouch : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Touchpad Component Get Active Touch";
    public string GetVariableQualifiedName() => "touchpadComponentGetActiveTouch";
}