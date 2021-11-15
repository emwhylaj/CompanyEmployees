using System;

namespace CompanyEmployees.Constants
{
    public class Constants
    {
        public static string SECRET_KEY => Environment.GetEnvironmentVariable("SECRET_KEY");
        public static string IV_KEY => Environment.GetEnvironmentVariable("IV_KEY");
    }
}
