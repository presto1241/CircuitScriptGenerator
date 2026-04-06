/*
 * Filename: DataTableReadCell.cs
 * Category: Game Features
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the value in the specified row from the specified column. Use the configuration menu to set which Data Table and Column to read from, which will also determine the output pin type.
 * Types: 
 * 
 * INPUTS: 
 * Row (int)
 *
 * OUTPUTS: 
 * 
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.GameFeatures;

[Node("4b6cff3d-0ead-43cd-bfa7-a22c87b31b0a")]
public class DataTableReadCell : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Data Table Read Cell";
    public string GetVariableQualifiedName() => "dataTableReadCell";
}