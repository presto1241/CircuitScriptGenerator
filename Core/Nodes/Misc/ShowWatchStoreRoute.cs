/*
 * Filename: ShowWatchStoreRoute.cs
 * Category: Misc
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Shows the local player the given watch store route
 * Types: 
 * 
 * INPUTS: 
 * Run (exec)
 * Store Route (string)
 * Uri Keys (List<string>)
 * Uri Types (List<string>)
 * Uri Data (List<string>)
 *
 * OUTPUTS: 
 * Run (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Misc;

[Node("414720f5-5dd6-4639-a84e-1c1ff1beb54e")]
public class ShowWatchStoreRoute : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Show Watch Store Route";
    public string GetVariableQualifiedName() => "showWatchStoreRoute";
}