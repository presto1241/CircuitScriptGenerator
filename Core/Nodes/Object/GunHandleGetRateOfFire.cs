/*
 * Filename: GunHandleGetRateOfFire.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Return the rate of fire of the target gun handle
 * Types: 
 * 
 * INPUTS: 
 * Target (Gun Handle)
 *
 * OUTPUTS: 
 * Rate Of Fire (float)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("a06ad097-0666-42ff-ab3d-0f00c383e9a1")]
public class GunHandleGetRateOfFire : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Gun Handle Get Rate Of Fire";
    public string GetVariableQualifiedName() => "gunHandleGetRateOfFire";
}