using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Text.RegularExpressions;

namespace DoJoSaque.Classes
{
    public class Saque
    {
        private decimal[] arrNotas = {100.0M, 50.0M, 20.0M, 10.0M};
        
        public string RetornarNotas(decimal valorSaque)
        {
            StringBuilder retorno = new StringBuilder();
            int contagemNota = 0;
            
            foreach(decimal nota in arrNotas)
            {
                contagemNota = 0;

                while (valorSaque >= nota)
                {
                    valorSaque = valorSaque - nota;
                    contagemNota++;
                }

                if (contagemNota > 0)
                    retorno.Append(" " + contagemNota.ToString() + " notas de " + nota.ToString() + ". ");
            }

            return retorno.ToString();
        }

        public static decimal Parse(string input)
        {
            return decimal.Parse(Regex.Match(input, @"-?\d{1,3}(,\d{3})*(\.\d+)?").Value);
        }

    }
}
