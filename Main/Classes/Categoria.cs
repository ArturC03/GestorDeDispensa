using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    internal class Categoria
    {
        private static string[] categoriaFields= {"idCategoria","categoria"};
        
        public static string[] CategoriaFields
        {
            get => categoriaFields;
        }

        private bool ValidField(string field)
        {
                foreach (string categoriaField in categoriaFields)
                    if (0 == string.Compare(categoriaField, field) || 0 == string.Compare("*", field))
                        return true;
                return false;

        }
        private bool ValidField(string[] fields)
        {
            int cont = 0;
            if(fields.Length == 1)
                return ValidField(fields[0]);
            for (int i = 0; i < categoriaFields.Length; i++)
                foreach (string categoriaField in categoriaFields)
                    if (0 == string.Compare(categoriaField, fields[i]))
                        cont++;
            if(fields.Length == cont)
                return true;
            else
                return false;

        }

        public bool Insert(string[] fields, string[] values)
        {
            if (fields[0] == "*")
                fields = categoriaFields;
            else
               if (!ValidField(fields))
                return false;

            DBConnect dBConnect = new DBConnect();

            dBConnect.Insert("Categoria", fields, values);
            return true;
        }

        //Update statement
        public bool Update(string[] changes)
        {
            DBConnect dBConnect = new DBConnect();

            dBConnect.Update("Categoria", changes);
            return true;
        }

        //Delete statement
        public bool Delete(string condition = null)
        {
            DBConnect dBConnect = new DBConnect();
            dBConnect.Delete("Categoria", condition);
            return true;

        }

        //Select statement
        public List<string>[] Select(string[] fields, string condition = null)
        {
            if (fields[0] == "*")
                fields = categoriaFields;
            else
                if (!ValidField(fields))
                return null;
            
            DBConnect dBConnect = new DBConnect();

            return dBConnect.Select("Categoria", fields, condition);
        }

        //Count statement
        public int Count(string field)
        {
            if (!ValidField(field))
                return -2;
               
            DBConnect dBConnect = new DBConnect();

            return dBConnect.Count("Categoria", field);
            
        }

    }
}
