/*
 * Filename: StudioObjectGetPropertyFloat.cs
 * Category: Rec Room Studio
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the value of a Float type Property defined in Rec Room Studio on a Studio Object
 * Types: 
 * 
 * INPUTS: 
 * Studio Object (Studio Object)
 * Property (string)
 *
 * OUTPUTS: 
 * Value (float)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.RecRoomStudio;

[Node("0dda9345-0211-4757-8fea-03e05fac89c3")]
public class StudioObjectGetPropertyFloat : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Studio Object Get Property - Float";
    public string GetVariableQualifiedName() => "studioObjectGetPropertyFloat";
}