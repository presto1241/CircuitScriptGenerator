/*
 * Filename: DiscoverySectionGetPlayerAccountList.cs
 * Category: Discovery
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: This chip gets a list of Player Accounts from an Accounts Discovery Section
 * Types: 
 * 
 * INPUTS: 
 * Run (exec)
 * Discovery Section (Discovery Section)
 *
 * OUTPUTS: 
 * Run (exec)
 * Complete (exec)
 * Player Accounts (List<Player Account>)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Discovery;

[Node("81052b8e-0f8d-46c5-be28-deefa2f569ad")]
public class DiscoverySectionGetPlayerAccountList : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Discovery Section Get Player Account List";
    public string GetVariableQualifiedName() => "discoverySectionGetPlayerAccountList";
}