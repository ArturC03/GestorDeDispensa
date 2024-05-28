using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    internal class Categoria:Tabela
    {
        private static string[] fields = {"idCategoria", "categoria"};
        
        public static string[] Fields
        {
            get => fields;
        }

        public override bool Insert(string[] inputFields, string[] values)
        {
            if (inputFields[0] == "*")
                inputFields = fields;
            else
               if (!ValidField(inputFields , fields))
                return false;

            DBConnect dBConnect = new DBConnect();

            dBConnect.Insert("Categoria", inputFields, values);
            return true;
        }
        public override bool Update(string change, string condition = null)
        {
            DBConnect dBConnect = new DBConnect();

            dBConnect.Update("Categoria", change, condition);
            return true;
        }


        public override bool Update(string[] changes, string condition = null)
        {
            DBConnect dBConnect = new DBConnect();

            dBConnect.Update("Categoria", changes, condition);
            return true;
        }

        public override bool Delete(string condition = null)
        {
            DBConnect dBConnect = new DBConnect();
            dBConnect.Delete("Categoria", condition);
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
            
            return dBConnect.Select("Categoria", inputFields, condition, order);
        }

        public override int Count(string inputField, string condition = null, string order = null)
        {
            if (!ValidField(inputField, fields))
                return -2;
               
            DBConnect dBConnect = new DBConnect();

            return dBConnect.Count("Categoria", inputField,condition, order);
        }

        public override string Max(string inputField, string condition = null, string order = null)
        {
            if (!ValidField(inputField, fields))
                return null;

            DBConnect dBConnect = new DBConnect();

            return dBConnect.Max("Categoria", inputField.Trim(), condition);
        }


    }
}
