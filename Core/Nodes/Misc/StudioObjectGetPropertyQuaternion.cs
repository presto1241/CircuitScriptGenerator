/*
 * Filename: StudioObjectGetPropertyQuaternion.cs
 * Category: Misc
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the value of a Quaternion type Property defined in Rec Room Studio on a Studio Object
 * Types: 
 * 
 * INPUTS: 
 * Studio Object (Studio Object)
 * Property (string)
 *
 * OUTPUTS: 
 * Value (Quaternion)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Misc;

[Node("4ea0cf52-729d-459b-b70c-93306246da2c")]
public class StudioObjectGetPropertyQuaternion : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Studio Object Get Property - Quaternion";
    public string GetVariableQualifiedName() => "studioObjectGetPropertyQuaternion";
}