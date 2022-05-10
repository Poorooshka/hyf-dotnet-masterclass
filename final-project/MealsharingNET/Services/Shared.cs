
public class Shared
{
    public static string ConnectionString = string.IsNullOrEmpty(Environment.GetEnvironmentVariable("MYSQLCONNSTR_MealSharingDb")) ?
   "Server=localhost;Database=meal_sharing;Uid=root;Pwd=????????;Convert Zero Datetime=True" :
   Environment.GetEnvironmentVariable("MYSQLCONNSTR_MealSharingDb");
}