/*
 * Filename: GunHandleGetContinuousFire.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns whether the given gun handle will fire continuously.
 * Types: 
 * 
 * INPUTS: 
 * Target (Gun Handle)
 *
 * OUTPUTS: 
 * Continuous Fire (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("bb9b601a-b501-434d-9df7-1b66c393fd8c")]
public class GunHandleGetContinuousFire : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Gun Handle Get Continuous Fire";
    public string GetVariableQualifiedName() => "gunHandleGetContinuousFire";
}