
public class Shared
{
    public static string ConnectionString = string.IsNullOrEmpty(Environment.GetEnvironmentVariable("MYSQLCONNSTR_MealSharingDb")) ?
   "Server=localhost;Database=final-semih;Uid=root;Pwd=compl3xPassWrd;Convert Zero Datetime=True" :
   Environment.GetEnvironmentVariable("MYSQLCONNSTR_MealSharingDb");
}