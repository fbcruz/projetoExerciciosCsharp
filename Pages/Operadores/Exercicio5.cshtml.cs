using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercicios.Pages.Operadores
{
    public class Exercicio5Model : PageModel
    {
        public void OnGet()
        {
        }

        public void OnPost(double numero1, double numero2, double numero3)
        {
        var resultado = (numero1 + numero2) * numero3;
        ViewData["Resultado"] = $"O Resultado é {resultado:N2}";
    }
    }
}
