public static class PlayAnalyzer
{
    public static string AnalyzeOnField(int shirtNum)
    {
        switch(shirtNum)
        {
            case 1:
                return "goalie";
            case 2:
                return "left back";
            case 3:
            case 4:
                return "center back";
            case 6:
            case 7:
            case 8:
                return "midfielder";
            case 10:
                return "striker";
            case 11: 
                return "right wing";
            default:
                return "UNKNOWN";
        }
    }

    public static string AnalyzeOffField(object report)
    {
        switch(report){
            case int supportersCount:
                return $"There are {supportersCount} supporters at the match.";
            case string reportAsText:
                return reportAsText;
            case Injury injury:
                return $"Oh no! {injury.GetDescription()} Medics are on the field.";
            case Incident incident: 
                return incident.GetDescription();
            case Manager manager:
                var club = manager.Club != null ? $"({manager.Club})" : "";
                return $"{manager.Name} {club}".Trim();
                
            default:
                return "";
        }
    }
}
