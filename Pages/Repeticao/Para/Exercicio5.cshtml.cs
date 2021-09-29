using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercicios.Pages.Repeticao.Para
{
    public class Exercicio5Model : PageModel
    {
        public void OnGet()
        {
        }

        public void OnPost()
        {
            int impar = 0, i = 1;

            List<string> impares = new List<string>();

            for (i = 1; i <= 15; i+=2) ;
               impar = i;  
                impares.Add($"{impar}");
                ViewData["impares"] = impares;
  
        }
    }
}
