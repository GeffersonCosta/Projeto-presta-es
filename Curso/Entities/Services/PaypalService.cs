using System;
using Curso.Entities;

namespace Curso.Services
{
    class PaypalService : IOnlinePaymentService

    {
      public double PaymentFee(double montante)
        {

            return montante += montante * 0.02;
        }
      public double Interesse(double montante, int mes)
        {
            return montante += montante *= (0.01 * mes);
        }
    }
}
