static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
       if(department != null){
           department = department.ToUpper();
       } else{
           department = "OWNER";
       }

        if(id == null){
            return $"{name} - {department}";
        }
        
        return $"[{id}] - {name} - {department}";
    }
}
