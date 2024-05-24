using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    internal class Produto
    {
        private static string[] produtoFields = {"idProduto","idCategoria","nome","preco","quantidade","marca"};
        
        private bool ValidField(string[] fields = null, string field = null)
        {
            if (null == fields)
            {
                foreach (string produtoField in produtoFields)
                    if (0 == string.Compare(produtoField, field))
                        return true;
                return false;
            }
            else
            {
                int cont = 0;
                for (int i = 0; i < produtoFields.Length; i++)
                    foreach (string produtoField in produtoFields)
                        if (0 == string.Compare(produtoField, fields[i]))
                            cont++;
                if(fields.Length == cont)
                    return true;
                else
                    return false;
            }

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
            if (!ValidField(fields))
                return false;
            
            DBConnect dBConnect = new DBConnect();

            dBConnect.Update("Produto", changes);
            return true;
        }

        //Delete statement
        public void Delete()
        {
        }

        //Select statement
        public List<string>[] Select()
        {
        }

        //Count statement
        public int Count()
        {
        }
    }
}
