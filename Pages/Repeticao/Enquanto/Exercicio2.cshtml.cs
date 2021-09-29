using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercicios.Pages.Repeticao.Enquanto
{
    public class Exercicio2Model : PageModel
    {
        public void OnGet()
        {
        }

        public void OnPost(int Numero, int Inteiro = 1)
        {
            List<string> inteiros = new List<string>();

            while(Inteiro <= Numero)
            {
                
                inteiros.Add($"{Inteiro}");
                ViewData["Inteiros"] = inteiros;
                Inteiro ++;
            }
        }
    
    }
}
