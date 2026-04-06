/*
 * Filename: StudioObjectGetPropertyColor.cs
 * Category: Misc
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the value of a Color type Property defined in Rec Room Studio on a Studio Object
 * Types: 
 * 
 * INPUTS: 
 * Studio Object (Studio Object)
 * Property (string)
 *
 * OUTPUTS: 
 * Value (Color)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Misc;

[Node("a7f4e64d-41cf-4000-ab55-efbf0ea5d777")]
public class StudioObjectGetPropertyColor : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Studio Object Get Property - Color";
    public string GetVariableQualifiedName() => "studioObjectGetPropertyColor";
}