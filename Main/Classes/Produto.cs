using MySqlX.XDevAPI.Relational;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Main.Classes
{
    internal class Produto : Tabela
    {
        private static string[] fields = {"idProduto","idCategoria","nome","preco","quantidade","marca"};
       
        public static string[] Fields
        {
            get => fields;
        }

        public override bool Insert(string[] inputFields, string[] values)
        {
            if (!ValidField(inputFields))
                return false;
            
            DBConnect dBConnect = new DBConnect();

            dBConnect.Insert("Produto", inputFields, values);
            return true;
        }

        public override bool Update(string[] changes)
        {
            DBConnect dBConnect = new DBConnect();

            dBConnect.Update("Produto", changes);
            return true;
        }
        
        public override bool Delete(string condition = null)
        {
            DBConnect dBConnect = new DBConnect();
            dBConnect.Delete("Produto", condition);
            return true;

        }

        public override List<string>[] Select(string[] inputFields, string condition = null)
        {
            if (fields[0] == "*")
                inputFields = fields;
            else
                if (!ValidField(inputFields))
                    return null;
            
            DBConnect dBConnect = new DBConnect();

            return dBConnect.Select("Produto", inputFields, condition);
        }

        public override int Count(string inputField)
        {
            if (!ValidField(inputField))
                return -2;
            
            DBConnect dBConnect = new DBConnect();

            return dBConnect.Count("Produto", inputField);
            
        }
    }
}
