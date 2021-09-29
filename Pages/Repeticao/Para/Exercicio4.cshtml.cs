using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercicios.Pages.Repeticao.Para
{
    public class Exercicio4Model : PageModel
    {
        public void OnGet()
        {
        }

        public void OnPost()
        {
            int fibon = 1, fibo1 = 0, fibo2 = 1, i = 0;

            List<string> fibonacci = new List<string>();

            for (i = 1; i <= 20; i++)
            {
                ViewData["fibonacci"] = fibonacci;
                fibonacci.Add($"{fibon}");

                fibon = fibo1 + fibo2;
                fibo2 = fibon; 
                fibo1 = fibon - fibo1; 
            }
        }
    }
}
