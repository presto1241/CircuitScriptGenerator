/*
 * Filename: StudioObjectGetPropertyVector3.cs
 * Category: Misc
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the value of a Vector3 type Property defined in Rec Room Studio on a Studio Object
 * Types: 
 * 
 * INPUTS: 
 * Studio Object (Studio Object)
 * Property (string)
 *
 * OUTPUTS: 
 * Value (Vector3)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Misc;

[Node("b96ed765-58d1-46f1-afa8-1b85a40fba50")]
public class StudioObjectGetPropertyVector3 : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Studio Object Get Property - Vector3";
    public string GetVariableQualifiedName() => "studioObjectGetPropertyVector3";
}