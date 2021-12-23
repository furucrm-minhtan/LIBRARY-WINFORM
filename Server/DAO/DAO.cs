using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Server.Core.Provider;

namespace Server.DAO
{
    public abstract class DAO<T>
    {
        public abstract string table
        {
            get;
        }

        public abstract List<T> getAll();

        public abstract bool insert(T data);

        public abstract bool update(T data);

        public abstract bool delete(string key);
    }
}
