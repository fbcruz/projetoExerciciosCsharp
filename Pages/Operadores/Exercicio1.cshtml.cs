using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercicios.Pages.Operadores
{
    public class Exercicio1Model : PageModel
    {
        public void OnGet()
        {
        }

        public void OnPost(string Nome, double Nota1, double Nota2, double Nota3)
        {
        var media = (Nota1 + Nota2 + Nota3)/3;
        ViewData["Resultado"] = $"O Aluno {Nome} obteve média {media:N2}";
        }
    }
}
