/*
 * Filename: GunHandleGetReloadDuration.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Return the reload duration of the target gun handle
 * Types: 
 * 
 * INPUTS: 
 * Target (Gun Handle)
 *
 * OUTPUTS: 
 * Reload Duration (float)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("ce696294-0c85-4823-8fe3-5fd6a41df2c9")]
public class GunHandleGetReloadDuration : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Gun Handle Get Reload Duration";
    public string GetVariableQualifiedName() => "gunHandleGetReloadDuration";
}