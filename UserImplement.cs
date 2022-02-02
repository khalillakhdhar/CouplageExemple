using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CouplageExemple
{
    class UserImplement : UserInterface
    {
        public void ajout(UserModel user)
        {
            Console.WriteLine(user.Nom + " ajouté");
        }

        public void updateUser(UserModel user)
        {
            Console.WriteLine(user.Nom + " modifié");
        }
    }
}
