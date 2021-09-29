using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercicios.Pages.Repeticao.Enquanto
{
    public class Exercicio3Model : PageModel
    {
        public void OnGet()
        {
        }

        public void OnPost(int Numero, int Inteiro)
        {
            Inteiro = 1;
            var soma = 0;

            while(Inteiro <= Numero)
            {
                soma += Inteiro;
                Inteiro++;
                ViewData["Soma"] = $"A soma dos números é {soma}";
            }
           // ViewData["Soma"] = $"A soma dos números é {soma}";
        }
    }
}