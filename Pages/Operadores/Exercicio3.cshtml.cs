using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercicios.Pages.Operadores
{
    public class Exercicio3Model : PageModel
    {
        public void OnGet()
        {
        }

        public void OnPost(double custo)
        {
        var valorfinal = custo + (custo * 0.45) + (custo * 0.25);
        ViewData["Resultado"] = $"O valor final do automóvel para o consumidor é de R$ {valorfinal:N2}";
        }
    }
}
