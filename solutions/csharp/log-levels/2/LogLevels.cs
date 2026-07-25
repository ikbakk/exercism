static class LogLine
{
    public static string Message(string logLine)
    {
        int index = logLine.IndexOf(": ") + 2;
        return logLine.Substring(index).Trim();
    }

    public static string LogLevel(string logLine)
    {
        int start = logLine.IndexOf('[') + 1;
        int end = logLine.IndexOf(']');
        return logLine.Substring(start, end - start).ToLower();
    }

    public static string Reformat(string logLine)
    {
        string level = LogLevel(logLine);
        string message = Message(logLine);
        return $"{message} ({level})";
    }
}
