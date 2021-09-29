using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercicios.Pages.Repeticao.Para
{
    public class Exercicio2Model : PageModel
    {
        public void OnGet()
        {
        }

        public void OnPost(int Numero)
        {
                    List<string> inteiros = new List<string>();
                    for (int i = 1; i <= Numero; i++)
                    inteiros.Add($"{i}");
                    ViewData["Inteiros"] = inteiros;
        }
    }
}
