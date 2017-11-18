using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    interface IQuestion
    {
        void Display();
        Boolean CheckAnswer(String response);
    }
}
