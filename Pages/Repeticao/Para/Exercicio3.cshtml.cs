using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercicios.Pages.Repeticao.Para
{
    public class Exercicio3Model : PageModel
    {
        public void OnGet()
        {
        }

        public void OnPost(int Numero)
        {

            var soma = 0;

            for (int i = 0; i <= Numero; i++)
                soma += i ;
            ViewData["Soma"] = $"A soma dos números é {soma}";

        }

    }

}
