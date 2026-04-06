/*
 * Filename: StudioObjectGetPropertyBool.cs
 * Category: Rec Room Studio
 * Created Date: 2026-04-05T23:55:26+00:00
 * Author: Preston
 * 
 * Description: Returns the value of a Bool type Property defined in Rec Room Studio on a Studio Object
 * Types: 
 * 
 * INPUTS: 
 * Studio Object (Studio Object)
 * Property (string)
 *
 * OUTPUTS: 
 * Value (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Rec Room Studio;

[Node("7ab38485-8d7c-4c98-b8f3-55a11d4ab741")]
public class StudioObjectGetPropertyBool : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Studio Object Get Property - Bool";
    public string GetVariableQualifiedName() => "studioObjectGetPropertyBool";
}