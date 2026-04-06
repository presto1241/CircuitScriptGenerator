/*
 * Filename: GrabberRelease.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: On execution, the target Grabber will release anything it’s holding. If an object is dropped, a reference to that object will be passed as an output. If nothing is dropped, it will return Invalid Object.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Grabber)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 * Object Dropped (Rec Room Object)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("051648c8-f13b-4e75-b5e0-33fc834485c6")]
public class GrabberRelease : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Grabber Release";
    public string GetVariableQualifiedName() => "grabberRelease";
}