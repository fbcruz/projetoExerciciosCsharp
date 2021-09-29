using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercicios.Pages.Repeticao.Enquanto
{
    public class Exercicio5Model : PageModel
    {
        public void OnGet()
        {
        }

        public void OnPost()
        {
            int i = 1, fibo1 = 0, fibo2 = 1, fibon = 1;

            List<string> fibonacci = new List<string>();
            while (i < 20)
            {
                ViewData["fibonacci"] = fibonacci;
                fibonacci.Add($"{fibon}");

                fibon = fibo1 + fibo2;
                 fibo2 = fibon; 
                fibo1 = fibon - fibo1; 
                i++;



            }
        }
    }
}


