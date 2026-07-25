static class LogLine
{
    public static string Message(string logLine)
    {
        int index = logLine.IndexOf(": ") + 2;
        string message = logLine.Substring(index).Trim();
        return message;
    }

    public static string LogLevel(string logLine)
    {
        int start = logLine.IndexOf('[') + 1;
        int end = logLine.IndexOf(']');
        string level = logLine.Substring(start, end - start).ToLower();
        return level;
    }

    public static string Reformat(string logLine)
    {
        string level = LogLevel(logLine);
        string message = Message(logLine);
        string modified = $"{message} ({level})";
        return modified;
    }
}
