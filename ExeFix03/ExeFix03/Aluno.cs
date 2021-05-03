using System;
using System.Collections.Generic;
using System.Text;

namespace ExeFix03
{
    class Aluno
    {
        public string Nome;
        public double Nota1, Nota2, Nota3;

        public double NotaFinal() {

            return Nota1  + Nota2 + Nota3;
        }

        public string VerificarAprovacao()
        {
            if ( NotaFinal() >= 60)
            {
                return "aprovado";

            }
            else
            {
                return "reprovado";
            }

        }

        public double PontosFaltando()
        {
            if (VerificarAprovacao() == "aprovado")
            {
                
                return 60 - NotaFinal();
            }
            else
            {
                return 0.0;
            }

        }



    }
}
