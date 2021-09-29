using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercicios.Pages.Condicionais.Se
{
    public class Exercicio3Model : PageModel
    {
        public void OnGet()
        {
        }

        public void OnPost(int atual, int maxima, int minima, double media)
        {
            media = (maxima + minima)/2;

            if (atual >= media)
                ViewData["Resultado"] = $"A quantidade média é {media}. Não efetuar compra!";
                else
                {
                    ViewData["Resultado"] = $"A quantidade média é {media}. Efetuar compra!";
                }

        }
    }
}
