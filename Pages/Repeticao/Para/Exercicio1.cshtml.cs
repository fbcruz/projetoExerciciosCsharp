using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercicios.Pages.Repeticao.Para
{
    public class Exercicio1Model : PageModel
    {
        public void OnGet()
        {
        }
        public void OnPost(int Numero)
        {
            if ((Numero < 0) || (Numero > 10))
                ViewData["Erro"] = "Número inválido, informe apenas valores entre 0 e 10.";
            else
            {
                List<string> tabuada = new List<string>();
                for (int i = 0; i < 11; i++)
                    tabuada.Add($"{Numero} x {i} = {Numero * i}");
                    ViewData["Tabuada"] = tabuada;
            }    
        }
    }
}
