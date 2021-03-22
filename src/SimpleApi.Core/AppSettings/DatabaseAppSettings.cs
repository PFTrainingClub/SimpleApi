namespace SimpleApi.Core.AppSettings
{
    public class DatabaseAppSettings
    {
        public DatabaseConfiguration CoreDb { get; set; }
    }

    public class DatabaseConfiguration
    {
        public string ConnectionString { get; set; }
    }
}
