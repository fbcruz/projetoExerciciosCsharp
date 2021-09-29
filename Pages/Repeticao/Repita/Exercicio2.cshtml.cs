using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercicios.Pages.Repeticao.Repita
{
    public class Exercicio2Model : PageModel
    {
        public void OnGet()
        {
        }

        public void OnPost(int Numero)
        {
            int fatorial = Numero, i = (Numero - 1);


            if (Numero < 0)
                ViewData["Erro"] = $"Número inválido! Informe apenas números positivos.";
            if (Numero == 0 || Numero == 1)
            {
                ViewData["Resultado"] = $"O fatorial de {Numero} é 1.";
            }
            else
            {
                do
                {
                   fatorial = fatorial * i;
                    i--;

                }
                while (i > 1);
                
            }
            ViewData["Resultado"] = $"O fatorial de {Numero} é {fatorial}";
        }
    }
}
