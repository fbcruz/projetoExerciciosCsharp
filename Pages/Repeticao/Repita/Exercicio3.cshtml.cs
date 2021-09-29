using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercicios.Pages.Repeticao.Repita
{
    public class Exercicio3Model : PageModel
    {
        public void OnGet()
        {
        }

        public void OnPost(int Numero)
        {
            int i = 1;
            int soma = 0;
            do
            {
                soma += i;
                i++;
            }
            while (i <= Numero);

            ViewData["Soma"] = soma;
        }

    }
}

