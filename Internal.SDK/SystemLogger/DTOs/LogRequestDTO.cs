using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internal.SDK.SystemLogger.DTOs
{
    public enum LogType
    {   
        ALERT,
        INFO,
        ERROR,
        REQUEST
    }

    public class LogRequestDTO
    {
        public required LogType Type { get; init; } 

        public required string Message { get; init; }

        public string? Details { get; init; }

        public DateTime? Timestamp{ get; internal set; } 

        public string? ApplicationName { get; internal set; } 
    }
}
