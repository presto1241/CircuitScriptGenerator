/*
 * Filename: LightTurnOn.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Turns on the point light or the spotlight.
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

[Node("5452c480-62f9-4d4e-b615-0f59e645d8db")]
public class LightTurnOn : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Light Turn On";
    public string GetVariableQualifiedName() => "lightTurnOn";
}