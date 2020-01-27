using LoginService.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace LoginService.Bussiness
{
    public class Products
    {
        public static List<Productos> GetProducts()
        {
            List<Productos> lista = new List<Productos>();

            string path = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Archivos/products.txt");

            using (StreamReader sr = new StreamReader(path))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    string[] infopro = line.Split(',');
                    Productos pro = new Productos(infopro[0], infopro[1], infopro[2], decimal.Parse(infopro[3]), int.Parse(infopro[4]), decimal.Parse(infopro[5]));
                    lista.Add(pro);
                }
            }

            return lista;

        }
    }
}