using PhumlaKamnandiProject.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PhumlaKamnandiProject.Business
{
    internal class PaymentController
    {
        private PaymentDA paymentDA;

        public PaymentController()
        {
            paymentDA = new PaymentDA();
        }

        public Payment MakePayment(Guest guest , Booking booking)
        {
            Payment payment = new Payment(guest , booking);
            paymentDA.InsertPayment(payment);
            return payment;
        }
    }
}
