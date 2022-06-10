using Firebase.Database;
using Firebase.Database.Query;
using HealthSafetyAppLite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthSafetyAppLite.Services
{
  public  class UserService
    {
        FirebaseClient client;
        public UserService()
        {
            client = new FirebaseClient("https://healthandsafetyapp-1c06b-default-rtdb.firebaseio.com/");
        }

        public async Task<bool> IsUserExists(string email,string telephone)
        {
            var user = (await client.Child("Users").OnceAsync<User>()).Where(u => u.Object.Email == email&&u.Object.Telephone==telephone).FirstOrDefault();
            return (user != null);
        }
        public async Task<bool> RegisterUser(User user)
        {
            if(await IsUserExists(user.Email,user.Telephone) == false)
            {
                await client.Child("Users").PostAsync(user);
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> LoginUser(string email,string password)
        {
            var user = (await client.Child("Users").OnceAsync<User>()).Where(u => u.Object.Email == email && u.Object.Password == password).FirstOrDefault();
            return (user != null);
        }
    }
}
