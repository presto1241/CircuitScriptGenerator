/*
 * Filename: LightTurnOff.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Turns off the point light or the spotlight.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Light)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("0f96406e-af69-4f6c-a430-c6b004457ef4")]
public class LightTurnOff : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Light Turn Off";
    public string GetVariableQualifiedName() => "lightTurnOff";
}