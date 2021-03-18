namespace TestAutomation
{
    public class Config
    {
        public static string BaseUrl = "http://trello.com";

        public static class Credentials
        {

            public static class Valid
            {
                public static string Email = "test.automation@op.pl";
                public static string Password = "Automation123";

            }

            public static class Invalid
            {
                public static string Email = "wasdasdpwpwpw@gmail.com";
                public static string Password = "Test123";
            }

        }

        public static class BoardNames 
        {
            public static string NazwaTablicy = "Test123";
        }
    }
}
