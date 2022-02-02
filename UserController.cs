using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CouplageExemple
{
    class UserController
    {
        public void addUser(UserModel us)

        {
            us.Nom = "x";
            us.prenom = "y";
            Console.WriteLine(us.Nom + " " + us.prenom + " ajouté");
                                          

        }
        public void UpdateUser(UserModel us)

        {
            us.Nom = "x";
            us.prenom = "y";
            us.Id = 1;
            Console.WriteLine(us.Nom + " " + us.prenom + " ajouté");


        }
    }
}
