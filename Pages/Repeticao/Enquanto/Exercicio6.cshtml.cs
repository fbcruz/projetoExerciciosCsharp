using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercicios.Pages.Repeticao.Enquanto
{
    public class Exercicio6Model : PageModel
    {
        public void OnGet()
        {
        }
        public void OnPost()
        {
            int i = 1, impar = 0;

            List<string> impares = new List<string>();

            while (i < 16)
            {
                impar = i;
                impares.Add($"{impar}");
                ViewData["impares"] = impares;

                i += 2;


            }


        }
    }
}
