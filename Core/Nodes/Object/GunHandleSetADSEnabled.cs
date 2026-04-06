/*
 * Filename: GunHandleSetADSEnabled.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Set whether the target gun handle has "aim down sights" enabled
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Gun Handle)
 * Enabled (bool)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("eaab4d32-95ed-4c98-83bd-fa9d99300255")]
public class GunHandleSetADSEnabled : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Gun Handle Set ADS Enabled";
    public string GetVariableQualifiedName() => "gunHandleSetADSEnabled";
}