namespace DAL
{
    public class EServer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Ip { get; set; }
        public string Port { get; set; }
    }

    public class ELog
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string DateInserted { get; set; }
    }

    public class EUser
    {
        public int Id { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
    }

    public class EConfig
    {
        public int Type { get; set; }
        //0 means mode Client-Server
        //1 means mode Server only
        //2 means mode Client only
        public string Port { get; set; }
    }
}
