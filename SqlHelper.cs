using System.Configuration;

namespace StuDataManagementSystem
{
    public class SqlHelper
    {
        public static string GetSqlConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
        }
    }
}
