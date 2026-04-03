public static class LogAnalysis 
{
    public static string SubstringAfter(this string str, string separator){
        return str.Split(separator)[1];
    }

    public static string SubstringBetween(this string str, string separator1, string separator2){
        return str.Split(separator1)[1].Split(separator2)[0];
    }

    public static string Message(this string str){
        return str.Split(":")[1].Trim();
    }

    public static string LogLevel(this string str){
        return str.SubstringBetween("[", "]");
    }
}