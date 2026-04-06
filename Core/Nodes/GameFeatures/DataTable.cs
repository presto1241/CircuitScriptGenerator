/*
 * Filename: DataTable.cs
 * Category: Game Features
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: A single data table. Edit the data table through the configuration menu on this chip. Specify the data type of each column and use Data Table Read Cell to extract the contents for use in circuit graphs. Must save room to commit changes.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (any)
 *
 * OUTPUTS: 
 * 
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.GameFeatures;

[Node("cf314640-805c-4ebc-958c-d10ed65ca9b8")]
public class DataTable : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Data Table";
    public string GetVariableQualifiedName() => "dataTable";
}