using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample01
{
    // Sample class that contains a function pointer field.
    public unsafe class UClass
    {
        public delegate* unmanaged[Cdecl, SuppressGCTransition]<in int, void> _fp;
    }

}
