using System;

namespace CurrencyExchanger.packages.model
{
    public class User
    {
        private enum Genders
        {
            Male,
            Female
        }

        public enum States
        {
            Alabama,
            Alaska,
            Arizona,
            Arkansas,
            California,
            Colorado,
            Connecticut,
            Delaware,
            Florida,
            Georgia,
            Hawaii,
            Idaho,
            Illinois,
            Indiana,
            Iowa,
            Kansas,
            Kentucky,
            Louisiana,
            Maine,
            Maryland,
            Massachusetts,
            Michigan,
            Minnesota,
            Mississippi,
            Missouri,
            Montana,
            Nebraska,
            Nevada,
            NewHampshire,
            NewJersey,
            NewMexico,
            NewYork,
            NorthCarolina,
            NorthDakota,
            Ohio,
            Oklahoma,
            Oregon,
            Pennsylvania,
            RhodeIsland,
            SouthCarolina,
            SouthDakota,
            Tennessee,
            Texas,
            Utah,
            Vermont,
            Virginia,
            Washington,
            WestVirginia,
            Wisconsin,
            Wyoming
        }

        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public int ZipCode { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public  States State { get; set; }
        private Genders Gender { get; set; }
    }
}