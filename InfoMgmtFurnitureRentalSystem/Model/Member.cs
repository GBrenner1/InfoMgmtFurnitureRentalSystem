namespace InfoMgmtFurnitureRentalSystem.Model
{
    public class Member
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string Street_addr { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public DateTime Birthday { get; set; }
        public DateTime Regestration_date { get; set; }

        /**
         * creates a new member object
         */
        public Member(string fname, string lname, string gender, string phone, string street_addr, string city, string state, string zip, DateTime birthday, DateTime regestration_date)
        {
            this.Fname = fname;
            this.Lname = lname;
            this.Gender = gender;
            this.Phone = phone;
            this.Street_addr = street_addr;
            this.City = city;
            this.State = state;
            this.Zip = zip;
            this.Birthday = birthday;
            this.Regestration_date = regestration_date;
        }
    }
}