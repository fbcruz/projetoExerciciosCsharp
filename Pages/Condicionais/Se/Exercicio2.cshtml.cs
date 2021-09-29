using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercicios.Pages.Condicionais.Se
{
    public class Exercicio2Model : PageModel
    {
        public void OnGet()
        {
        }

        public void OnPost(double salario, double novosalario)
        {
           if(salario > 1000)
           {
                novosalario = (salario * 0.08) + salario;
                ViewData["Aumento"] = $"O novo salário do funcionário é R$ {novosalario:N2}"; 
           }
                else
                {
                    novosalario = (salario * 0.10) + salario;
                    ViewData["Aumento"] = $"O novo salário do funcionário é R$ {novosalario:N2}";
                    
                }
        }
    }
}
