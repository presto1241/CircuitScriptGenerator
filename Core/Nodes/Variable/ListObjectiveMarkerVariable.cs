/*
 * Filename: ListObjectiveMarkerVariable.cs
 * Category: Variable
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Reads or writes a variable in the current scope based on the name.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * (unnamed) (List<Objective Marker>)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 * (unnamed) (List<Objective Marker>)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Variable;

[Node("2aa2fe68-18bf-4f63-9ed9-2fc237b60df9")]
public class ListObjectiveMarkerVariable : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "List<Objective Marker> Variable";
    public string GetVariableQualifiedName() => "listObjectiveMarkerVariable";
}