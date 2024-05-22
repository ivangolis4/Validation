using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validation
{
    public class Person
    {
        String Username;
        String Password;
        String Email;
        String Gender;
        DateTime Birthdate;

        public void setUsername(String username)
        {
            this.Username = username;
        }
        public void setPassword(String password)
        {
            this.Password = password;
        }
        public void setEmail(String email)
        {
            this.Email = email;
        }
        public void setGender(String gender)
        {
            this.Gender = gender;
        }
        public void setBirthdate(DateTime Birthdate)
        {
            this.Birthdate = Birthdate;
        }
        public String getUsername()
        {
            return Username;
        }
        public String getPassword()
        {
            return Password;
        }
        public String getEmail()
        {
            return Email;
        }
        public String getGender()
        {
            return Gender;
        }
        public DateTime getBirthdate()
        {
            return Birthdate;
        }
    }
}
