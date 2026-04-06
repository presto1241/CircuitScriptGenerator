/*
 * Filename: GrantReward.cs
 * Category: Game Features
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Grants the contents of a Reward to the specified Player.
 * Types: 
 * 
 * INPUTS: 
 * Run (exec)
 * Player (Player)
 * Reward (Reward)
 *
 * OUTPUTS: 
 * Run (exec)
 * On Award Complete (exec)
 * Success (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.GameFeatures;

[Node("8b38e01f-9c85-47bb-abda-85e354c15d41")]
public class GrantReward : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Grant Reward";
    public string GetVariableQualifiedName() => "grantReward";
}