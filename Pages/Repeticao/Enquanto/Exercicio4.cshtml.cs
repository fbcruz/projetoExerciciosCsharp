using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercicios.Pages.Repeticao.Enquanto
{
    public class Exercicio4Model : PageModel
    {
        public void OnGet()
        {
        }

        public void OnPost(int Numero)
        {
            int fatorial = Numero, i = (Numero - 1);

            if (Numero < 0)
                ViewData["Erro"] = $"N�mero inv�lido! Informe apenas n�meros positivos.";
            if (Numero == 0 || Numero == 1)
            {
                ViewData["Resultado"] = $"O fatorial de {Numero} � 1.";
            }
            else
            {
                while (i > 1)
                {
                    fatorial = fatorial * i;
                    i--;
                }
                ViewData["Resultado"] = $"O fatorial de {Numero} � {fatorial}";
            }
        }
    }
}

//fatorial = 10
// i = 9
// 


