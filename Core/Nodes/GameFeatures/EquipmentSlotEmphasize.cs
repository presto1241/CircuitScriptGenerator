/*
 * Filename: EquipmentSlotEmphasize.cs
 * Category: Game Features
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Play an emphasize animation for equipment slot for local player. In VR,this will also trigger a controller haptics and a notification visual effect on your watch.
 * Types: 
 * 
 * INPUTS: 
 * Run (exec)
 * Equipment Slot (Equipment Slot)
 *
 * OUTPUTS: 
 * Run (exec)
 * On Complete (exec)
 * Success (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.GameFeatures;

[Node("c8cbba6f-dcec-4283-b601-e98edd40da36")]
public class EquipmentSlotEmphasize : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Equipment Slot Emphasize";
    public string GetVariableQualifiedName() => "equipmentSlotEmphasize";
}