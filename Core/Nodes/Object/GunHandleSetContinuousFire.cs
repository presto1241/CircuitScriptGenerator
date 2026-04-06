/*
 * Filename: GunHandleSetContinuousFire.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets whether the given gun handle will fire continuously.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Gun Handle)
 * Continuous Fire (bool)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("d539bb9a-5e64-43df-a8f9-16839ede0027")]
public class GunHandleSetContinuousFire : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Gun Handle Set Continuous Fire";
    public string GetVariableQualifiedName() => "gunHandleSetContinuousFire";
}