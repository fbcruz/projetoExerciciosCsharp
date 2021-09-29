using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercicios.Pages.Condicionais.Escolha
{
    public class Exercicio2Model : PageModel
    {
        public void OnGet()
        {
        }
         public void OnPost(int Produto, double Quantidade)
        {
            double valor = 0;
            
            try
            { 
              // ViewData["Valor"] = $"O valor total do pedido é";

                switch (Produto)
                {
                    case 100:
                        valor =( 5.50 * Quantidade);
                        ViewData["Valor"] = $"O valor total do pedido é {valor:N2}";
                        break;

                    case 101:
                        valor = 6.50 * Quantidade;
                        ViewData["Valor"] = $"O valor total do pedido é {valor:N2}";
                        break;
                
                    case 102:
                        valor = 7.50 * Quantidade;
                        ViewData["Valor"] = $"O valor total do pedido é {valor:N2}";
                        break;
                
                    case 103:
                        valor = 6.00 * Quantidade;
                        ViewData["Valor"] = $"O valor total do pedido é {valor:N2}";
                        break;
                
                    case 104:
                        valor = 6.30 * Quantidade;
                        ViewData["Valor"] = $"O valor total do pedido é {valor:N2}";
                        break; 
                
                    case 105:
                        valor = 5.00 * Quantidade;
                        ViewData["Valor"] = $"O valor total do pedido é {valor:N2}";
                        break; 
                }


            }
            catch
            {
               throw new Exception ($"Informe um código válido!");
            }
                    
        }
    }
}
