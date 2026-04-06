/*
 * Filename: GunHandleGetFiringDirection.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Return the firing direction of the target gun handle
 * Types: 
 * 
 * INPUTS: 
 * Target (Gun Handle)
 * Source (Rec Room Object)
 *
 * OUTPUTS: 
 * Direction (Vector3)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("1521eb32-29db-4708-81de-71398c29e76d")]
public class GunHandleGetFiringDirection : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Gun Handle Get Firing Direction";
    public string GetVariableQualifiedName() => "gunHandleGetFiringDirection";
}