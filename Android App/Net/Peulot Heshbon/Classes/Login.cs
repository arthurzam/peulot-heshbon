namespace Peulot_Heshbon.Classes
{
    /// <summary>
    /// struct for saving login (password & username) with order
    /// </summary>
    internal struct Login
    {
        private string username;
        private string password;

        /// <summary>
        /// empty Login Struct
        /// </summary>
        public static readonly Login Empty = new Login("-", "-");

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        public Login(string username, string password)
        {
            this.password = password;
            this.username = username;
        }

        /// <summary>
        /// converts the string to "Login" object
        /// </summary>
        /// <param name="str">the string. format : [username]_[password]</param>
        /// <returns>the Login object</returns>
        public static Login Parse(string str)
        {
            Login r = new Login();
            r.username = str.Split('_')[0];
            r.password = str.Split('_')[1];
            return r;
        }

        /// <summary>
        /// converts the Login object to string
        /// </summary>
        /// <returns>the string. format : [username]_[password] </returns>
        public override string ToString()
        {
            return username + '_' + password;
        }

        /// <summary>
        /// the username
        /// </summary>
        public string Username
        {
            get { return username; }
            set { this.username = value; }
        }

        /// <summary>
        /// empty Login Struct
        /// </summary>
        public string Password
        {
            get { return password; }
            set { this.password = value; }
        }
    }
}