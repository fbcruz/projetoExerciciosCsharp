using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercicios.Pages.Operadores
{
    public class Exercicio4Model : PageModel
    {
        public void OnGet()
        {
        }
        public void OnPost(double valor_prestacao, int nr_pagas, int nr_prestacoes)
        {
        var valortotalpago = valor_prestacao * nr_pagas;
        ViewData["Resultado"] = $"O Valor total pago até o momento é R$ {valortotalpago:N2}";

        var saldodevedor = (nr_prestacoes * valor_prestacao) - valortotalpago;
        ViewData["Resultado1"] = $"O saldo devedor é R$ {saldodevedor:N2}";
        }

    }
}
