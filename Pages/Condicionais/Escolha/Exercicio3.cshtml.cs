using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercicios.Pages.Condicionais.Escolha
{
    public class Exercicio3Model : PageModel
    {
        public void OnGet()
        {
        }

        public void OnPost(double saldo, double credito)
        { 
            switch (saldo)
            {
                case <= 200:
                    ViewData["Resultado"] = $"O saldo médio do cliente é R$ " + saldo + " o mesmo não possui nenhum crédito. ";
                    break;

                case <= 400:
                    credito = saldo * 0.20;
                    ViewData["Resultado"] = $"O saldo médio do cliente é R$ " + saldo + " Crédito de R$" + credito;
                    break;

                case <= 600:
                    credito = saldo * 0.30;
                    ViewData["Resultado"] = $"O saldo médio do cliente é R$ " + saldo + " Crédito de R$" + credito;
                    break;

                default:
                    credito = saldo * 0.40;
                    ViewData["Resultado"] = $"O saldo médio do cliente é R$ " + saldo + " Crédito de R$" + credito;
                    break;
            
            }
        }

    }
}
