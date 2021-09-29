using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercicios.Pages.Operadores
{
    public class Exercicio6Model : PageModel
    {
        public void OnGet()
        {
        }

        public void OnPost(double numero1, double numero2)
        {
            var soma = numero1 + numero2;
            ViewData["soma"] = $"A soma dos numeros é {soma}";

            var subtracao = numero1 - numero2;
            ViewData["subtracao"] = $"A subtracao dos numeros é {subtracao}";

            var multiplicacao = numero1 * numero2;
            ViewData["multiplicacao"] = $"A multriplicacao dos numeros é {multiplicacao}";

            var divisao = numero1 / numero2;
            ViewData["divisao"] = $"A divisao dos numeros é {divisao}";
        }
    }
}
