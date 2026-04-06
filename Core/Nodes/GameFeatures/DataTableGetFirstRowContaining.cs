/*
 * Filename: DataTableGetFirstRowContaining.cs
 * Category: Game Features
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the first row containing the given value within a specified Data Table. Configure the chip to select the Data Table and column.
 * Types: 
 * 
 * INPUTS: 
 * 
 *
 * OUTPUTS: 
 * Row (int)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.GameFeatures;

[Node("699f2839-0742-4b3d-80ca-4394fb60e7e2")]
public class DataTableGetFirstRowContaining : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Data Table Get First Row Containing";
    public string GetVariableQualifiedName() => "dataTableGetFirstRowContaining";
}