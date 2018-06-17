using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeKullanmak
{
    class Program
    {
        static void Main(string[] args)
        {

            DebugMethod();
            //OldMethod();

            Console.ReadKey();

        }

        [Obsolete("Bu metod artık kullanılmıyor. Bunun yerine ... metodunu kullanın.", true)]
        public static void OldMethod()
        {
            Console.WriteLine("OldMethod çalıştırıldı");
        }

        [Conditional("DEBUG")]
        public static void DebugMethod()
        {
            Console.WriteLine("Debug Metod Çalıştı");
        }

    }
}
