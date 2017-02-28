using System;
using System.Diagnostics;

namespace PeopleSearch
{
    /// <summary>
    /// Utils class to centralize commonly used functions.
    /// </summary>
    public static class Utils
    {
        /// <summary>
        /// Method to write errors to the Event Log
        /// </summary>
        /// <param name="e">Exception to write to the Event Log</param>
        public static void WriteExceptionToEventLog(Exception e)
        {
            string log = "Application";
            string source = "PeopleSearch";

            if (!EventLog.SourceExists(source))
            {
                EventLog.CreateEventSource(source, log);
            }

            EventLog.WriteEntry(source, string.Format("Message:\n{0}\n\nStackTrace:\n{1}", e.Message, e.StackTrace), EventLogEntryType.Error);
        }
    }
}