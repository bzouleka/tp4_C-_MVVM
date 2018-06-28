using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_MVVM.Model;

namespace TP_MVVM.ViewModel
{
   public class ListUser
    {

        public List<User> Users { get; set; }

        public ListUser()
        {
            Users = new List<User>
            {
                new User
                {
                    Nom = "Bouhassoun",
                    Prenom = "Zouleka",
                    Age = 31,
                },

                new User
                {
                    Nom = "toto",
                    Prenom =  "titi",
                    Age = 20,
                },

                new User
                {
                    Nom = "L'éponge",
                    Prenom = "Bob",
                    Age = 25,
                },
            };
        }


    }
}
