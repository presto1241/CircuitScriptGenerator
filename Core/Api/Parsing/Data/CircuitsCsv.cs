/*
 * Filename: CircuitsCsv.cs
 * Path: /home/presto/Github/CircuitScriptGenerator/Core/Api/Parsing/Data
 * Created Date: Thursday, April 9th 2026, 7:45:30 pm
 * Author: Preston
 * 
 * Description: A class definition to parse circuits csv
 */
using CsvHelper.Configuration.Attributes;

namespace CircuitScriptGenerator.Core.Api.Parsing.Data;

public class CircuitsCsv
{
    [Index(0)]
    public string Guid { get; set; } = string.Empty;

    [Index(1)]
    public string Base64Guid { get; set; } = string.Empty;

    [Index(2)]
    public string Type { get; set; } = string.Empty;
}