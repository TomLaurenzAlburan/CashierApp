namespace CashierApplication
{
    internal class Cashier
    {
        private string username;
        private string password;
        private string v1;
        private string v2;

        public Cashier(string username, string password, string v1, string v2)
        {
            this.username = username;
            this.password = password;
            this.v1 = v1;
            this.v2 = v2;
        }

        public string FullName { get; internal set; }
    }
}