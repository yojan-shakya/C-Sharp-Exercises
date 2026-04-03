static class LogLine
{
    public static string Message(string logLine)
    {
        return logLine.Split(":")[1].Trim();
    }

    public static string LogLevel(string logLine)
    {
       return logLine.Split(":")[0].Replace("[", "").Replace("]", "").ToLower();
    }

    public static string Reformat(string logLine)
    {
        string logLevel = LogLine.LogLevel(logLine);
        string message = LogLine.Message(logLine);

        return $"{message} ({logLevel})";
    }
}
