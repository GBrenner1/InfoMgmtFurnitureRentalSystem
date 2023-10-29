namespace InfoMgmtFurnitureRentalSystem.Model
{
    public class Member
    {
        /// <summary>
        /// the members id
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// the members first name
        /// </summary>
        public string Fname { get; set; }
        /// <summary>
        /// the members last name
        /// </summary>
        public string Lname { get; set; }
        /// <summary>
        /// the members gender
        /// </summary>
        public string Gender { get; set; }
        /// <summary>
        /// the members phone number
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// the members street address
        /// </summary>
        public string Street_addr { get; set; }
        /// <summary>
        /// the city the member lives in
        /// </summary>
        public string City { get; set; }
        /// <summary>
        /// the state the member lives in
        /// </summary>
        public string State { get; set; }
        /// <summary>
        /// the members Zipcode 
        /// </summary>
        public string Zip { get; set; }
        /// <summary>
        /// The members birthday
        /// </summary>
        public DateTime Birthday { get; set; }
        /// <summary>
        /// The date the member was registered
        /// </summary>
        public DateTime Regestration_date { get; set; }

        /// <summary>
        /// Creates a new member object
        /// </summary>
        /// <param name="id"> The customers ID</param>
        /// <param name="fname">the first name of the member</param>
        /// <param name="lname">the last name of the member</param>
        /// <param name="gender">the gender of the member</param>
        /// <param name="phone">the phone number of the member</param>
        /// <param name="street_addr"> the street address of the member</param>
        /// <param name="city">The city the member lives in</param>
        /// <param name="state">The state the member lives in</param>
        /// <param name="zip">The zip code of the member</param>
        /// <param name="birthday">the members birthday</param>
        /// <param name="regestration_date">the date the member was registered</param>
        public Member(string id,string fname, string lname, string gender, string phone, string street_addr, string city, string state, string zip, DateTime birthday, DateTime regestration_date)
        {
            this.id = id;
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