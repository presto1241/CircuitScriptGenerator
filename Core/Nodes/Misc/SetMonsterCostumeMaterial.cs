/*
 * Filename: SetMonsterCostumeMaterial.cs
 * Category: Misc
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: 
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Costume (Costume)
 * Material Name (string)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Misc;

[Node("dd845d84-bac5-417e-8f15-ae63d0b2e7ae")]
public class SetMonsterCostumeMaterial : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Set Monster Costume Material";
    public string GetVariableQualifiedName() => "setMonsterCostumeMaterial";
}