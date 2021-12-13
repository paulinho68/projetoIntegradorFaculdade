using ReversoBD.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversoForm.GlobalContext
{
    static class UserInfo
    {
        public static string Email;
        public static string Senha;
        public static int Id;

        public static string GetEmail()
        {
            return Email;
        }
        public static void SetEmail(string email)
        {
            Email = email;
        }

        public static string GetSenha()
        {
            return Senha;
        }
        public static void SetSenha(string senha)
        {
            Senha = senha;
        }

        public static int GetId()
        {
            return Id;
        }
        public static void SetId(int id)
        {
            Id = id;
        }
    }
}
