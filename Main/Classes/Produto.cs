using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    internal class Produto
    {
        private static string[] produtoFields = {"idProduto","idCategoria","nome","preco","quantidade","marca"};
       
        public static string[] ProdutoFields
        {
            get => produtoFields;
        }
        private bool ValidField(string field)
        {
                foreach (string produtoField in produtoFields)
                    if (0 == string.Compare(produtoField, field) || 0 == string.Compare("*", field))
                        return true;
                return false;

        }
        private bool ValidField(string[] fields)
        {
            int cont = 0;
            if (1 == fields.Length)
                return ValidField(fields[0]);
            for (int i = 0; i < produtoFields.Length; i++)
                foreach (string produtoField in produtoFields)
                    if (0 == string.Compare(produtoField, fields[i]))
                        cont++;
            if(fields.Length == cont)
                return true;
            else
                return false;

        }

        public bool Insert(string[] fields, string[] values)
        {
            if (!ValidField(fields))
                return false;
            
            DBConnect dBConnect = new DBConnect();

            dBConnect.Insert("Produto", fields, values);
            return true;
        }

        //Update statement
        public bool Update(string[] changes)
        {
            DBConnect dBConnect = new DBConnect();

            dBConnect.Update("Produto", changes);
            return true;
        }

        //Delete statement
        public bool Delete(string condition = null)
        {
            DBConnect dBConnect = new DBConnect();
            dBConnect.Delete("Produto", condition);
            return true;

        }

        //Select statement
        public List<string>[] Select(string[] fields, string condition = null)
        {
            if (fields[0] == "*")
                fields = ProdutoFields;
            else
                if (!ValidField(fields))
                    return null;
            
            DBConnect dBConnect = new DBConnect();

            return dBConnect.Select("Produto", fields, condition);
        }

        //Count statement
        public int Count(string field)
        {
            if (!ValidField(field))
                return -2;
            
            DBConnect dBConnect = new DBConnect();

            return dBConnect.Count("Produto", field);
            
        }
    }
}
