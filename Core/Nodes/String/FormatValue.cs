/*
 * Filename: FormatValue.cs
 * Category: String
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Use this chip to format values and convert them to a string. It can combine multiple inputs together into a single string result. 

The "Format" input forms the base of the “Result” output and can include other inputs using this syntax: {input pin # starting at 0}. For example, a "Format" input with a default value of “Hello, {0}!” with a single additional input pin with the string value "World" is fully output as "Hello, World!". If you had another input pin you would use {1} to denote the 2nd pin. You can add more inputs by configuring the chip and pressing "Add Input".

You can format the values provided to this chip using the following syntax: {index[,alignment][:formatString]}
Index determines which input value will be used. 
Alignment is an optional argument that controls the minimum number of characters that will be used to display the input. Alignment’s sign controls the left/right justification of the value.
FormatString is another optional argument that activates input type specific formatting options e.g. C for currency.

String:
FormatValue(“Hello {0}!”, “World”) = “Hello World!”

Int:
FormatValue(“Testing {0}!”, 123) = “Testing 123!”

Float:
FormatValue(“Value: {0}”, 1234.5678) = “Value: 1234.5678”

Multiple values:
FormatValue(“{0} {1}!”, “Hello”, “there”) = “Hello there!”

Repeated value:
FormatValue(“{0} {0}”, “Hello!”) = “Hello! Hello!”

Alignment:
FormatValue(“|{0,5}|”, 15) = “|   15|”
FormatValue(“|{0,-5}|”, 15) = “|15   |”

Padding with zeros (Int Only):
FormatNumber(“|{0:D5}|”, 1) = “|00001|”
FormatNumber(“|{0:D-5}|”, 1) = “|10000|”

Number:
FormatNumber(“{0:N2}”, 123.321) = “123.32”

Currency:
FormatNumber(“{0:C}”, 1234.4321) = “$1234.43”

Exponential:
FormatNumber(“{0:E2}”, 123456789) = “1.23E+008”

Percentage:
FormatNumber(“{0:P0}”, 0.50) = “50 %”

Hexadecimal (Int Only):
FormatNumber(“{0:X}”, 123456789) = “75BCD15”

Format:
FormatNumber({0:000.000}, 1234.4321) = “1234.432”

For further formatting information you can look up C# composite formatting.
 * Types: (int | float | string)
 * 
 * INPUTS: 
 * Format (string)
 * Value (T)
 *
 * OUTPUTS: 
 * Result (string)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.String;

[Node("be40fe16-796d-4070-b7b6-2226eaf5cf88")]
public class FormatValue : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Format Value";
    public string GetVariableQualifiedName() => "formatValue";
}