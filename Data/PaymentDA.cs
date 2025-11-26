using PhumlaKamnandiProject.Business;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhumlaKamnandiProject.Data
{
    public class Payment
    {
        public string PaymentID { get; set; }
        public Booking Booking { get; set; }
        public Guest Guest{ get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal Amount { get; set; }
        public string PaymentStatus { get; set; }

        public Payment()
        {
            PaymentDate = DateTime.Now;
            Random rng = new Random();
            PaymentID = "PAY" + rng.Next(100,999).ToString("D3") + PaymentDate.ToString("yyyyMMdd");
        }

        public Payment(Guest guest , Booking booking)
        {
            PaymentDate = DateTime.Now;
            Random rng = new Random();
            PaymentID = "PAY" + rng.Next(100, 999).ToString("D3") + PaymentDate.ToString("yyyyMMdd");
            Booking = booking;
            Amount = booking.DepositAmount;
            Guest = guest;
            PaymentStatus = "Pending";
            VerifyPayment();
        }

        private void VerifyPayment()
        {
            PaymentStatus = "Verified";
            MessageBox.Show("Payment has been verified");
        }

    }

    public class PaymentDA : BaseDA
    {
        #region Constructors
        public PaymentDA() : base() { }

        public PaymentDA(string connString) : base(connString) { }
        #endregion

        #region CRUD Operations

        public bool InsertPayment(Payment payment) {
            bool success = false;
        
            string query = @"INSERT INTO Payment 
                (PaymentID, Guest, Amount, PaymentDate , PaymentStatus)
                VALUES 
                (@PaymentID,@Guest, @Amount, @PaymentDate , @PaymentStatus)
                ;";

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PaymentID", payment.PaymentID);
                command.Parameters.AddWithValue("@Guest",payment.Guest.GuestID);
                command.Parameters.AddWithValue("@Amount",payment.Booking.DepositAmount);
                command.Parameters.AddWithValue("@PaymentDate",payment.PaymentDate);
                command.Parameters.AddWithValue("@PaymentStatus", payment.PaymentStatus);
                // Add other parametesrs when columns are added
                int rowsAffected = command.ExecuteNonQuery();
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Payment Insertion :" + ex.Message);
            }
            return success;

        }

        //public Payment Read(int paymentID)
        //{
        //    string query = @"SELECT PaymentID, BookingID, PaymentDate, Amount, 
        //        PaymentMethod, PaymentStatus, TransactionReference, CreatedDate
        //        FROM Payments WHERE PaymentID = @PaymentID";

        //    SqlParameter[] parameters = { CreateParameter("@PaymentID", paymentID) };

        //    return ExecuteQuery(query, cmd =>
        //    {
        //        using (SqlDataReader reader = cmd.ExecuteReader())
        //        {
        //            if (reader.Read())
        //            {
        //                return MapPayment(reader);
        //            }
        //        }
        //        return null;
        //    }, parameters);
        //}

        //public bool Update(Payment payment)
        //{
        //    string query = @"UPDATE Payments SET 
        //        PaymentStatus = @Status,
        //        TransactionReference = @TransRef
        //        WHERE PaymentID = @PaymentID";

        //    SqlParameter[] parameters = {
        //        CreateParameter("@PaymentID", payment.PaymentID),
        //        CreateParameter("@Status", payment.PaymentStatus),
        //        CreateParameter("@TransRef", payment.TransactionReference)
        //    };

        //    return ExecuteQuery(query, cmd => cmd.ExecuteNonQuery() > 0, parameters);
        //}

        //public List<Payment> GetPaymentsByBooking(int bookingID)
        //{
        //    string query = @"SELECT PaymentID, BookingID, PaymentDate, Amount, 
        //        PaymentMethod, PaymentStatus, TransactionReference, CreatedDate
        //        FROM Payments WHERE BookingID = @BookingID 
        //        ORDER BY PaymentDate DESC";

        //    SqlParameter[] parameters = { CreateParameter("@BookingID", bookingID) };

        //    return ExecuteQuery(query, cmd =>
        //    {
        //        List<Payment> payments = new List<Payment>();
        //        using (SqlDataReader reader = cmd.ExecuteReader())
        //        {
        //            while (reader.Read())
        //            {
        //                payments.Add(MapPayment(reader));
        //            }
        //        }
        //        return payments;
        //    }, parameters);
        //}
        #endregion

        #region Helper Methods

        //private Payment MapPayment(SqlDataReader r)
        //{
        //    return new Payment
        //    {
        //        PaymentID = r.GetInt32(0),
        //        BookingID = r.GetInt32(1),
        //        PaymentDate = r.GetDateTime(2),
        //        Amount = r.GetDecimal(3),
        //        PaymentMethod = r.GetString(4),
        //        PaymentStatus = r.GetString(5),
        //        TransactionReference = r.IsDBNull(6) ? "" : r.GetString(6),
        //        CreatedDate = r.GetDateTime(7)
        //    };
        //}
        #endregion
    }
}
