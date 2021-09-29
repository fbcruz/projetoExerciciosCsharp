using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercicios.Pages.Repeticao.Repita
{
    public class Exercicio4Model : PageModel
    {
        public void OnGet()
        {
        }

        public void OnPost(int Numero)
        {
            int inteiro = 0;
            List<string> inteiros = new List<string>();

            do
            {
                inteiros.Add($"{inteiro}");
                ViewData["Inteiros"] = inteiros;
                inteiro++;
            }
            while (inteiro <= Numero);

        }
    }
}
