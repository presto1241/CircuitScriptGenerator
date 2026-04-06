/*
 * Filename: DataTableGetAllRowsContaining.cs
 * Category: Game Features
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns a list of row indices containing the given value within a specified Data Table. Configure the chip to select the data table and column.
 * Types: 
 * 
 * INPUTS: 
 * 
 *
 * OUTPUTS: 
 * Rows (List<int>)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.GameFeatures;

[Node("0a04aa3b-22bd-44a8-8613-9c02db855e88")]
public class DataTableGetAllRowsContaining : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Data Table Get All Rows Containing";
    public string GetVariableQualifiedName() => "dataTableGetAllRowsContaining";
}