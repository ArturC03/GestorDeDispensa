using MySqlX.XDevAPI.Relational;
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
    internal sealed class Produto : Tabela
    {
        private static string[] fields = {"idProduto","idCategoria","nome","preco","quantidade","marca"};
        private static string[] type = { "int", "int", "varchar", "double", "int", "varchar" };
        public static string[] Fields
        {
            get => fields;
        }
        public static string[] Type
        {
            get => type;
        }


        public override bool Insert(string[] inputFields, string[] values)
        {
            if (!ValidField(inputFields, fields))
                return false;
            
            DBConnect dBConnect = new DBConnect();

            dBConnect.Insert("Produto", inputFields, values);
            return true;
        }
        public override bool Update(string change, string condition = null)
        {
            DBConnect dBConnect = new DBConnect();

            dBConnect.Update("Produto", change, condition);
            return true;
        }

        public override bool Update(string[] changes, string condition = null)
        {
            DBConnect dBConnect = new DBConnect();

            dBConnect.Update("Produto", changes, condition);
            return true;
        }
        
        public override bool Delete(string condition = null)
        {
            DBConnect dBConnect = new DBConnect();
            dBConnect.Delete("Produto", condition);
            return true;

        }

        public override List<string>[] Select(string[] inputFields, string condition = null, string order = null)
        {
            if (inputFields[0] == "*")
                inputFields = fields;
            else
                if (!ValidField(inputFields, fields))
                    return null;
            
            DBConnect dBConnect = new DBConnect();

            return dBConnect.Select("Produto", inputFields, condition, order);
        }

        public override int Count(string inputField, string condition = null, string order = null)
        {
            if (!ValidField(inputField, fields))
                return -2;
            
            DBConnect dBConnect = new DBConnect();  

            return dBConnect.Count("Produto", inputField,condition, order);
            
        }

        public override string Max(string inputField, string condition = null, string order = null)
        {
            if (!ValidField(inputField, fields))
                return null;

            DBConnect dBConnect = new DBConnect();

            return dBConnect.Max("Produto", inputField.Trim(), condition);
        }

    }
}
