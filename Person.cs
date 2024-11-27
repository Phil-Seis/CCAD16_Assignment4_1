namespace CCAD16_Assignment4_1
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobilePhone { get; set; }
        public string WorkPhone { get; set; }
        public string Address { get; set; }

        // Computed property for FullName
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
    }
}
