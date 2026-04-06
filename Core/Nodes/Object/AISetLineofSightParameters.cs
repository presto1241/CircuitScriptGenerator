/*
 * Filename: AISetLineofSightParameters.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets an AI’s various LoS paramters. The “Cone” setting acts like a vision cone that sits in front of AIs like eyes, where the “Circle” setting acts like a radius around the AI. The Require LoS For Targetting parameter defines if AIs can see you through walls.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * AI (AI)
 * Vision Type (Cone/Circle) (string)
 * Vision Range (m) (float)
 * Vision Cone Angle (Cone Type Only) (float)
 * Hearing Range (m) (float)
 * Require LoS for targeting (bool)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("02557d1f-2265-4b6d-8177-92f1802dc106")]
public class AISetLineofSightParameters : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "AI Set Line of Sight Parameters";
    public string GetVariableQualifiedName() => "aISetLineofSightParameters";
}