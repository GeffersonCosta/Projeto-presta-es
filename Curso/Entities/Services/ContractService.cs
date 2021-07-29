using System;
using System.Collections.Generic;
using System.Text;
using Curso.Entities;

namespace Curso.Services
{
    class ContractService
    {
        private IOnlinePaymentService _onlinePaymentService;

        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
          
            _onlinePaymentService = onlinePaymentService;
        }

       

       
        public void ProcessContract(Contract contract, int mes)
        {
         
            for (int i = 1; i <= mes; i++)
            {
              
                double soma = 0.0;
                soma = contract.ValorTotal / mes;
                soma = _onlinePaymentService.PaymentFee(soma);
                soma = _onlinePaymentService.Interesse(soma,i);
                contract.Prestacoes.Add(new Prestacoes(contract.Data.AddMonths(i), soma));
             
            }
        }
    }

}


