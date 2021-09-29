using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercicios.Pages.Repeticao.Repita
{
    public class Exercicio1Model : PageModel
    {
        public void OnGet()
        {
        }

        public void OnPost(int Numero)
        {
            if ((Numero < 0) || (Numero > 10))
                ViewData["Erro"] = $"Informe um número entre 0 e 10";
            else
            {
                List<string> tabuada = new List<string>();
                int i = 0;
                do
                {
                    tabuada.Add($"{Numero} x {i} = {Numero * i} ");
                    i += 1;
                }
                while (i < 11);
                ViewData["Tabuada"] = tabuada;


            }
        }
    }
}
