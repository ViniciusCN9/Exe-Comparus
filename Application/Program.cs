using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application
{
    public class Program
    {
        static void Main(String[] args)
        {
            Presentation.Initial();
            Service.Menu();
            Presentation.Finish();
        }
    }
}