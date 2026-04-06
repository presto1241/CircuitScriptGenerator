/*
 * Filename: DataTableGetRowCount.cs
 * Category: Game Features
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the number of rows in the given data table, set by configuring the chip.
 * Types: 
 * 
 * INPUTS: 
 * 
 *
 * OUTPUTS: 
 * Rows (int)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.GameFeatures;

[Node("e32052ce-0f54-4875-aa11-39e8c2761deb")]
public class DataTableGetRowCount : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Data Table Get Row Count";
    public string GetVariableQualifiedName() => "dataTableGetRowCount";
}