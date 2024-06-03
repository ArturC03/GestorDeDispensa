using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    internal class Historico : Tabela
    {
        private static string[] fields = { "idHistorico", "idProduto","acao","nome","preco","quantidade","dataTransacao"};
        private static string[] type = { "int", "int","varchar", "varchar", "decimal", "int", "timestamp"};
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

            dBConnect.Insert("HistoricoTransacoes", inputFields, values);
            return true;
        }
        public override bool Update(string change, string condition = null)
        {
            DBConnect dBConnect = new DBConnect();

            dBConnect.Update("HistoricoTransacoes", change, condition);
            return true;
        }

        public override bool Update(string[] changes, string condition = null)
        {
            DBConnect dBConnect = new DBConnect();

            dBConnect.Update("HistoricoTransacoes", changes, condition);
            return true;
        }

        public override bool Delete(string condition = null)
        {
            DBConnect dBConnect = new DBConnect();
            dBConnect.Delete("HistoricoTransacoes", condition);
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
            
            return dBConnect.Select("HistoricoTransacoes", inputFields, condition, order);
        }

        public override int Count(string inputField, string condition = null, string order = null)
        {
            if (!ValidField(inputField, fields))
                return -2;
               
            DBConnect dBConnect = new DBConnect();

            return dBConnect.Count("HistoricoTransacoes", inputField, condition, order);
        }

        public override string Max(string inputField, string condition = null, string order = null)
        {
            if (!ValidField(inputField, fields))
                return null;

            DBConnect dBConnect = new DBConnect();

            return dBConnect.Max("HistoricoTransacoes", inputField.Trim(), condition);
        }

    }

}
