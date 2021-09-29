using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercicios.Pages.Condicionais.Escolha
{
    public class Exercicio1Model : PageModel
    {
        public void OnGet()
        {
        }
        public void OnPost(double Peso, double Altura)
        {
            double imc = Peso / Math.Pow(Altura, 2);
            ViewData["Resultado"] = $"Seu IMC é {imc:N2}, você esta ";
            switch (imc)
            {
                case < 20:
                ViewData["Resultado"] += "Abaixo do Peso";
                break;

                 case < 25:
                ViewData["Resultado"] += "com Peso Normal";
                break;

                 case < 30:
                ViewData["Resultado"] += "com Sobre Peso";
                break;

                 case < 40:
                ViewData["Resultado"] += "Obeso";
                break;

                default:
                    ViewData["Resultado"] += "Com Obesidade Mórbida";
                    break;
            }
        }
    }
}
