using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness.Modell
{
    public class ValueWrapper<T>
    {
        public T Value { get; set; }
        public ValueWrapper() { }
        public ValueWrapper(T Value)
        {
            this.Value = Value;
        }
        public static implicit operator T(ValueWrapper<T> wrapper)
        {
            if (wrapper == null)
                return default(T);
            else
                return wrapper.Value;
        }
    }
}
