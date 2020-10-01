

namespace MyNs
{
    public class Person
    {
        private string Id;

        public string ID
        {
            get { return Id; }
            set { Id = value; }
        }
        private string _firstName;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
    }
}