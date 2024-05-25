using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Classes
{
    internal abstract class Tabela
    {
        private static string[] fields;
        

        protected static bool ValidField(string inputField)
        {
                foreach (string field in fields )
                    if (0 == string.Compare(field,inputField) || 0 == string.Compare("*", inputField))
                        return true;
                return false;

        }
        protected static bool ValidField(string[] inputFields)
        {
            int cont = 0;
            if (1 == inputFields.Length)
                return ValidField(inputFields[0]);
            for (int i = 0; i < fields.Length; i++)
                foreach (string field in fields)
                    if (0 == string.Compare(field, inputFields[i]))
                        cont++;
            if(fields.Length == cont)
                return true;
            else
                return false;

        }

        public abstract bool Insert(string[] inputFields, string[] values);
        public abstract bool Update(string[] changes);
        public abstract bool Delete(string condition = null);
        public abstract List<string>[] Select(string[] inputFields, string condition = null);
        public abstract int Count(string inputField);

    }
}
