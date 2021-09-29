using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercicios.Pages.Condicionais.Se
{
    public class Exercicio1Model : PageModel
    {
        public void OnGet()
        {
        }

        public void OnPost(string Time1, int Gols1, string Time2, int Gols2)
        {
            if (Gols1 > Gols2)
                ViewData["Resultado"] = $"Vitória do {Time1} por {Gols1}x{Gols2}";
                else 
                    if (Gols2 > Gols1)
                    ViewData["Resultado"] = $"Vitória do {Time2} por {Gols2}x{Gols1}";
                    else
                        ViewData["Resultado"] = $"Empate de {Gols1}x{Gols2}";
                    
                
        }
    }
}
