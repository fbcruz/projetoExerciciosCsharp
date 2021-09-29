using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercicios.Pages.Repeticao.Enquanto
{
    public class Exercicio1Model : PageModel
    {
        public void OnGet()
        {
        }

        public void OnPost(int Numero)
        {
            if ((Numero < 0) || (Numero > 10))
                ViewData["Erro"] = "Número inválido, informe apenas valores entre 0 e 10";
                else
                {
                    List<string> tabuada = new List<string>();
                    int i = 0;
                    while (i < 11)
                    {
                        tabuada.Add($"{Numero} x {i} = {Numero * i}");
                        i +=1;
                    }
                    ViewData["Tabuada"] = tabuada;
                }
        }

    }
}
