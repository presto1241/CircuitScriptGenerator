/*
 * Filename: DataTableGetColumnCount.cs
 * Category: Game Features
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the number of columns in the given data table, set by configuring the chip.
 * Types: 
 * 
 * INPUTS: 
 * 
 *
 * OUTPUTS: 
 * Columns (int)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.GameFeatures;

[Node("bf05749e-c89e-4aa2-97f8-31c105f45b49")]
public class DataTableGetColumnCount : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Data Table Get Column Count";
    public string GetVariableQualifiedName() => "dataTableGetColumnCount";
}