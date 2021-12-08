﻿namespace HACC.Demo.Logging;

public class LoggingConfiguration
{
    public int EventId { get; set; }

    public Dictionary<LogLevel, ConsoleColor> LogLevels { get; set; } = new()
    {
        [key: LogLevel.Information] = ConsoleColor.Green
    };
}