using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample01_OldVersion
{
    public interface IBase
    {
        public int Base { get; set; }
    }

    public interface IDerived : IBase
    {
        public int Derived { get; set; }
    }

    public class DerivedImplement : IDerived
    {
        public int Base { get; set; }
        public int Derived { get; set; }
    }

}
