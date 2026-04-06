/*
 * Filename: StudioObjectGetPropertyString.cs
 * Category: Rec Room Studio
 * Created Date: 2026-04-05T23:55:26+00:00
 * Author: Preston
 * 
 * Description: Returns the value of a String type Property defined in Rec Room Studio on a Studio Object
 * Types: 
 * 
 * INPUTS: 
 * Studio Object (Studio Object)
 * Property (string)
 *
 * OUTPUTS: 
 * Value (string)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Rec Room Studio;

[Node("a0708f14-89b6-4ef7-97eb-38359a57422f")]
public class StudioObjectGetPropertyString : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Studio Object Get Property - String";
    public string GetVariableQualifiedName() => "studioObjectGetPropertyString";
}