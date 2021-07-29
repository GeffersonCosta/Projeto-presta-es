

namespace Curso.Services
{
    interface IOnlinePaymentService
    {
        double PaymentFee(double montante);
        double Interesse(double montante, int mes);
       
    }
}
