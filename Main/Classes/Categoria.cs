using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Main.Classes
{
    internal class Categoria:Tabela
    {
        private static string[] fields = {"idCategoria", "categoria"};
        
        public static string[] Fields
        {
            get => Fields;
        }

        public override bool Insert(string[] inputFields, string[] values)
        {
            if (inputFields[0] == "*")
                inputFields = fields;
            else
               if (!ValidField(inputFields))
                return false;

            DBConnect dBConnect = new DBConnect();

            dBConnect.Insert("Categoria", inputFields, values);
            return true;
        }

        public override bool Update(string[] changes)
        {
            DBConnect dBConnect = new DBConnect();

            dBConnect.Update("Categoria", changes);
            return true;
        }

        public override bool Delete(string condition = null)
        {
            DBConnect dBConnect = new DBConnect();
            dBConnect.Delete("Categoria", condition);
            return true;

        }
        public override List<string>[] Select(string[] inputFields, string condition = null)
        {
            if (inputFields[0] == "*")
                inputFields = fields;
            else
                if (!ValidField(inputFields))
                return null;
            
            DBConnect dBConnect = new DBConnect();

            return dBConnect.Select("Categoria", inputFields, condition);
        }

        public override int Count(string inputField)
        {
            if (!ValidField(inputField))
                return -2;
               
            DBConnect dBConnect = new DBConnect();

            return dBConnect.Count("Categoria", inputField);
            
        }

    }
}
