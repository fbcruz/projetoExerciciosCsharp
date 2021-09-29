using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercicios.Pages.Operadores
{
    public class Exercicio2Model : PageModel
    {
        public void OnGet()
        {
        }

        public void OnPost(string Nome, double salariofixo, double vendas)
        {
        var salariofinal = (vendas * 0.15) + salariofixo;
        ViewData["Resultado"] = $"O salário final do vendedor {Nome} é R$ {salariofinal:N2}";
        }
    }
}
