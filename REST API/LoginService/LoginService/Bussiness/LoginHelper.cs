using LoginService.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace LoginService.Bussiness
{
    public class LoginHelper
    {
        public static List<Usuario> GetUsuarios()
        {
            List<Usuario> lista = new List<Usuario>();
            string path = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Archivos/users.txt");

            using (StreamReader sr = new StreamReader(path))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    string[] infousu = line.Split(',');
                    Usuario usu = new Usuario(infousu[0], infousu[1]);
                    lista.Add(usu);
                }
            }

            return lista;

        }

        public static bool Autenticar(string nombre, string password)
        {
            bool result = false;
            List<Usuario> lista = GetUsuarios();

            foreach (Usuario usu in lista)
            {
                if (usu.Nombre == nombre && usu.Password == password)
                {
                    result = true;
                    break;
                }

            }

            return result;
        }
    }
}