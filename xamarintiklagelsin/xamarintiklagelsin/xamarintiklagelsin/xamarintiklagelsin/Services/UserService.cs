using Firebase.Database;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using xamarintiklagelsin.Models;
using System.Threading.Tasks;
using Firebase.Database.Query;

namespace xamarintiklagelsin.Services
{
    public class UserService
    {
        FirebaseClient client;

        public UserService()
        {
            client = new FirebaseClient("https://xamarintiklagelsin-a4de1-default-rtdb.firebaseio.com/");
        }

        public async Task<bool> IsUserExists(string uname)
        {
            var user = (await client.Child("Users").OnceAsync<User>()).Where(u => u.Object.Username == uname).FirstOrDefault();

            return (user != null);
        }

        public async Task<bool> RegisterUser(string uname,string passwd,string email,string ad,string soyad,int phoneno)
        {
            if(await IsUserExists(uname) == false && await IsUserExists(email)==false)
            {
                await client.Child("Users").PostAsync(
                    new User()
                    {
                        Username = uname,
                        Password= passwd,
                        EMail = email,
                        Ad = ad,
                        Soyad = soyad,
                        PhoneNo = phoneno
                    }
                    );
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> LoginUser(string uname, string passwd)
        {
            var user = (await client.Child("Users").OnceAsync<User>()).Where(u => u.Object.Username == uname)
                .Where(u => u.Object.Password == passwd).FirstOrDefault();

            return (user != null);
        }
    }
}
