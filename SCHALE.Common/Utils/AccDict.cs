using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCHALE.Common.Utils
{
    public class AccDict<T> : Dictionary<T, int> where T : notnull
    {
        public new int this[T key]
        {
            get => TryGetValue(key, out var value) ? value : 0;
            set => base[key] = value;
        }
    }
}
