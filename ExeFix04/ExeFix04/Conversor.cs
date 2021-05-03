using System;
using System.Collections.Generic;
using System.Text;

namespace ExeFix04
{
    class Conversor
    {

        public static double Converter(double qtd, double cotacao)
        {
            return ((qtd * cotacao) + ((qtd * cotacao) * 0.06));

        }

    }
}
