using Server.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.BUS
{
    public abstract class BUS<T>
    {
        public abstract bool store(T data);
        public abstract bool update(T data);
        public abstract bool delete(string key);
    }
}
