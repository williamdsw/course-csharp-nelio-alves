
using System;

namespace Entities
{
    public class LogEntry
    {
        public string UserName { get; set; }
        public DateTime Instant { get; set; }

        public LogEntry(string userName, DateTime instant)
        {
            UserName = userName;
            Instant = instant;
        }

        public override int GetHashCode()
        {
            return UserName.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is LogEntry))
            {
                return false;
            }

            LogEntry logEntry = obj as LogEntry;
            return UserName.Equals(logEntry.UserName);
        }
    }
}
