/*
 * Filename: GetPlayerSeasonLeagueName.cs
 * Category: Misc
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the name of the target player's Season League (The league feature has been deprecated)
 * Types: 
 * 
 * INPUTS: 
 * Player (Player)
 *
 * OUTPUTS: 
 * Season League Name (string)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Misc;

[Node("288083ac-338d-410f-9395-fbd7c6e41207")]
public class GetPlayerSeasonLeagueName : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Get Player Season League Name";
    public string GetVariableQualifiedName() => "getPlayerSeasonLeagueName";
}