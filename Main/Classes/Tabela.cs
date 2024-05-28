using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    internal abstract class Tabela
    {
        
        protected static bool ValidField(string inputField, string[] fields)
        {
                foreach (string field in fields)
                    if (0 == string.Compare(field,inputField) || 0 == string.Compare("*", inputField))
                        return true;
                return false;

        }
        protected static bool ValidField(string[] inputFields, string[] fields)
        {
            int cont = 0;
            if (1 == inputFields.Length)
                return ValidField(inputFields[0], fields);
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
        public abstract bool Update(string[] changes, string condition = null);
        public abstract bool Update(string change, string condition = null);
        public abstract bool Delete(string condition = null);
        public abstract List<string>[] Select(string[] inputFields, string condition = null);
        public abstract int Count(string inputField);

    }
}
