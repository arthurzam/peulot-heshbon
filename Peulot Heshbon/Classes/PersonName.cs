namespace Peulot_Heshbon.Classes
{
    /// <summary>
    /// struct for Person's name
    /// </summary>
    internal struct PersonName
    {
        private string firstName, lastName;

        /// <summary>
        /// An empty PersonName object
        /// </summary>
        public static readonly PersonName Empty = new PersonName("-", "-");

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="fn">first name</param>
        /// <param name="ln">last name</param>
        public PersonName(string fn, string ln)
        {
            firstName = fn;
            lastName = ln;
        }

        /// <summary>
        /// converts the string to PersonName object
        /// </summary>
        /// <param name="all">the string. format : [LastName]_[FirstName]</param>
        /// <returns>the PersonName object</returns>
        public static PersonName Parse(string all)
        {
            PersonName r = new PersonName();
            r.lastName = all.Split('_')[0];
            r.firstName = all.Split('_')[1];
            return r;
        }

        /// <summary>
        /// converts the PersonName to string
        /// </summary>
        /// <returns>the string. format : [LastName]_[FirstName]</returns>
        public override string ToString()
        {
            return lastName + '_' + firstName;
        }

        /// <summary>
        /// first name
        /// </summary>
        public string FirstName
        {
            get { return firstName; }
            set { this.firstName = value; }
        }

        /// <summary>
        /// last name
        /// </summary>
        public string LastName
        {
            get { return lastName; }
            set { this.lastName = value; }
        }
    }
}