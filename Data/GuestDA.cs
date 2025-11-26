using PhumlaKamnandiProject.Business;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PhumlaKamnandiProject.Data
{
    public class GuestDA:BaseDA
    {
        // Already inherits from BaseDA 

        #region Constructor
        public GuestDA() : base()
        {

        }
        //public GuestDA(string connString)
        //{
        //    //connectionString = connString;
        //    //connection = new SqlConnection(connectionString);
        //}
        #endregion

        #region CreateReadUpdateDelete(CRUD) Operations
        public bool CreateNewGuest(Guest guest)
        {
            
            bool success = false;
            string query = @"INSERT INTO Guest 
                (GuestID, FirstName, LastName, PhoneNumber, Email, CardNumber, CardExpiry,IdentificationNumber, 
                IdentificationDocument, Street, Suburb, PostalCode, City, Country)
                VALUES 
                (@GuestID, @FirstName, @LastName, @PhoneNumber, @Email, @CardNumber, @CardExpiry,@IdentificationNumber, 
                @IdentificationDocument, @Street, @Suburb, @PostalCode, @City, @Country);
                ";

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@GuestID", guest.GuestID);
                command.Parameters.AddWithValue("@FirstName", guest.FirstName);
                command.Parameters.AddWithValue("@LastName", guest.LastName);
                command.Parameters.AddWithValue("@PhoneNumber",guest.PhoneNumber);
                command.Parameters.AddWithValue("@Email", guest.Email);
                command.Parameters.AddWithValue("@CardNumber", DBNull.Value);
                command.Parameters.AddWithValue("@CardExpiry", DBNull.Value);
                command.Parameters.AddWithValue("@IdentificationNumber", guest.IdentificationNumber);
                switch (guest.IdentificationType)
                {
                    case (IdentityDocument.NationalID):
                        command.Parameters.AddWithValue("@IdentificationDocument", 1);
                        break;
                    case (IdentityDocument.PassportNo):
                        command.Parameters.AddWithValue("@IdentificationDocument",2);
                        break;
                }
                command.Parameters.AddWithValue("@Street", guest.Street);
                command.Parameters.AddWithValue("@Suburb", guest.Suburb);
                command.Parameters.AddWithValue("@PostalCode", guest.PostalCode);
                command.Parameters.AddWithValue("@City", guest.City);
                command.Parameters.AddWithValue("@Country", guest.Country);
                int rowsAffected = command.ExecuteNonQuery();
                success = rowsAffected > 0;
            }
            catch (SqlException ex)
            {
                throw new Exception("Error creating guest: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }

            return success;
        }

        public bool insertGuestCardDetails(Guest guest)
        {
            bool success = false;
            string query = @"UPDATE Guest SET 
                        CardNumber = @CardNo,
                        CardExpiry = @CardExpiry,
                        CVV = @CVV
                     WHERE GuestID = @GuestID;";
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                // Add GuestID parameter
                command.Parameters.AddWithValue("@GuestID", guest.GuestID);

                // Card 1 parameters
                command.Parameters.AddWithValue("@CardNo",
                    string.IsNullOrEmpty(guest.CardNo) ? (object)DBNull.Value : guest.CardNo);
                command.Parameters.AddWithValue("@CardExpiry",
                    guest.CardExpiry.HasValue ? (object)guest.CardExpiry.Value : DBNull.Value);
                command.Parameters.AddWithValue("@CVV",
                    string.IsNullOrEmpty(guest.CVV) ? (object)DBNull.Value : guest.CVV);
                int rowsAffected = command.ExecuteNonQuery();
                success = rowsAffected > 0;

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Payment information saved successfully.");
                }
                else
                {
                    MessageBox.Show("No guest record was updated. Check Guest ID.");
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error updating guest payment details: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
            return success;

        }

        public Guest ReadGuest(string guestID)
        {
            Guest guest = new Guest();
            string query = @"SELECT GuestID, FirstName, LastName, PhoneNumber, Email, CardNumber,CardExpiry,CVV,CreatedDate,IdentificationNumber, 
                IdentificationDocument, Street, Suburb, PostalCode, City, Country
                FROM Guest WHERE GuestID = @GuestID";
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@GuestID",guestID);
                SqlDataReader reader = command.ExecuteReader();


                if (reader.Read())
                {
                    IdentityDocument idType = 0; // fix this later
                    if (Convert.ToInt32(reader["IdentificationDocument"]) == 1)
                    {
                        idType = IdentityDocument.NationalID;
                    }
                    else if(reader.GetInt32(9) == 2)
                    {
                        idType = IdentityDocument.PassportNo;
                    }
                    guest.GuestID = reader["GuestID"].ToString().Trim();
                    guest.FirstName = reader["FirstName"].ToString().Trim();
                    guest.LastName = reader["LastName"].ToString().Trim();
                    guest.PhoneNumber = reader["PhoneNumber"].ToString().Trim();
                    guest.Email = reader["Email"].ToString().Trim();
                    guest.CardNo = reader["CardNumber"] == DBNull.Value ? "None":reader["CardNumber"].ToString().Trim();
                    guest.CardExpiry = reader["CardExpiry"] == DBNull.Value ? DateTime.MinValue :Convert.ToDateTime(reader["CardExpiry"]);
                    guest.CVV = reader["CVV"] == DBNull.Value ? "None" : Convert.ToString(reader["CVV"]);
                    guest.CreatedDate = Convert.ToDateTime(reader["CreatedDate"]);
                    guest.IdentificationNumber = reader["IdentificationNumber"].ToString().Trim();
                    guest.IdentificationType = idType; // Assuming this is set elsewhere
                    guest.Street = reader["Street"].ToString().Trim();
                    guest.Suburb = reader["Suburb"].ToString().Trim();
                    guest.PostalCode = reader["PostalCode"].ToString().Trim();
                    guest.City = reader["City"].ToString().Trim();
                    guest.Country = reader["Country"].ToString().Trim();

                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error reading guest: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }

            return guest;
        }
        public bool UpdateGuest(Guest guest)
        {
            bool success = false;

            string query = @"UPDATE Guest SET 
                FirstName = @FirstName,
                LastName = @LastName,
                PhoneNumber = @PhoneNumber,
                Email = @Email,
                Street = @Street,
                Suburb = @Suburb,
                PostalCode = @PostalCode,
                City = @City,
                Country = @Country
                WHERE GuestID = @GuestID";

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@GuestID", guest.GuestID);
                command.Parameters.AddWithValue("@FirstName", guest.FirstName);
                command.Parameters.AddWithValue("@LastName", guest.LastName);
                command.Parameters.AddWithValue("@PhoneNumber", guest.PhoneNumber);
                command.Parameters.AddWithValue("@Email", guest.Email);
                command.Parameters.AddWithValue("@Street", guest.Street);
                command.Parameters.AddWithValue("@Suburb", guest.Suburb);
                command.Parameters.AddWithValue("@PostalCode", guest.PostalCode);
                command.Parameters.AddWithValue("@City", guest.City); 
                command.Parameters.AddWithValue("@Country", guest.Country);
                int rowsAffected = command.ExecuteNonQuery();
                success = rowsAffected > 0;
            }
            catch (SqlException ex)
            {
                throw new Exception("Error updating guest: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }

            return success;
        }
        public bool DeleteGuest(string guestID)
        {
            bool success = false;

            string query = "DELETE FROM Guest WHERE GuestID = @GuestID";

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@GuestID", guestID);

                int rowsAffected = command.ExecuteNonQuery();
                success = rowsAffected > 0;
            }
            catch (SqlException ex)
            {
                throw new Exception("Error deleting guest: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }

            return success;
        }
        #endregion
        #region Methods
        public Guest SearchByID(string idNo)
        {
            Guest guest = new Guest();

            string query = @"SELECT *
            FROM Guest WHERE IdentificationNumber = @IdentificationNumber";

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdentificationNumber", idNo);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IdentityDocument idType = IdentityDocument.NationalID; 
                    if (reader["IdentificationDocument"] != DBNull.Value)
                    {
                        int docType = Convert.ToInt32(reader["IdentificationDocument"]);
                        if (docType == 1)
                        {
                            idType = IdentityDocument.NationalID;
                        }
                        else if (docType == 2)
                        {
                            idType = IdentityDocument.PassportNo;
                        }
                    }

                    guest.GuestID = reader["GuestID"].ToString().Trim();
                    guest.FirstName = reader["FirstName"].ToString().Trim();
                    guest.LastName = reader["LastName"].ToString().Trim();
                    guest.PhoneNumber = reader["PhoneNumber"].ToString().Trim();
                    guest.Email = reader["Email"].ToString().Trim();

                    if (reader["CreatedDate"] != DBNull.Value)
                        guest.CreatedDate = Convert.ToDateTime(reader["CreatedDate"]);

                    // Card 1 details
                    if (reader["CardNumber"] != DBNull.Value)
                        guest.CardNo = Convert.ToString(reader["CardNumber"]);
                    if (reader["CardExpiry"] != DBNull.Value)
                        guest.CardExpiry = Convert.ToDateTime(reader["CardExpiry"]);
                    if (reader["CVV"] != DBNull.Value)
                        guest.CVV = Convert.ToString(reader["CVV"]);

                    guest.IdentificationNumber = reader["IdentificationNumber"].ToString().Trim();
                    guest.IdentificationType = idType;
                    guest.Street = reader["Street"].ToString().Trim();
                    guest.Suburb = reader["Suburb"].ToString().Trim();
                    guest.PostalCode = reader["PostalCode"].ToString().Trim();
                    guest.City = reader["City"].ToString().Trim();
                    guest.Country = reader["Country"].ToString().Trim();
                }

                reader.Close();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error searching guest: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }

            return guest;
        }

        public List<Guest> GetAllGuests()
        {
            List<Guest> guests = new List<Guest>();

            string query = @"SELECT GuestID, FirstName, LastName, Address, City, PostalCode, 
                PhoneNumber, Email, GuestType, IDNumber, PassportNumber, PassportCountry, 
                PassportExpiryDate, CardNumber, CardExpiry, CreatedDate
                FROM Guest ORDER BY LastName, FirstName";

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Guest guest = new Guest();
                    IdentityDocument idType = 0; // fix this later
                    if (reader["IdentificationDocument"] != DBNull.Value)
                    {
                        int docType = Convert.ToInt32(reader["IdentificationDocument"]);
                        if (docType == 1)
                        {
                            idType = IdentityDocument.NationalID;
                        }
                        else if (docType == 2)
                        {
                            idType = IdentityDocument.PassportNo;
                        }
                    }
                    guest.GuestID = reader.GetString(0).TrimStart().TrimEnd(); // GuestID
                    guest.FirstName = reader.GetString(1).TrimStart().TrimEnd();  // FirstName
                    guest.LastName = reader.GetString(2).TrimStart().TrimEnd(); // LastName
                    guest.PhoneNumber = reader.GetString(3).TrimStart().TrimEnd();  //PhoneNumber                        
                    guest.Email = reader.GetString(4).TrimStart().TrimEnd(); //Email
                    guest.CardNo = reader.GetString(5).TrimStart().TrimEnd();//CardNo
                    guest.CardExpiry = reader.GetDateTime(6); //CardExpiry
                    guest.CreatedDate = reader.GetDateTime(7); //Created Date
                    guest.IdentificationNumber = reader.GetString(8).TrimStart().TrimEnd(); //ID NO
                    guest.IdentificationType = idType; //Document Used
                    guest.Street = reader.GetString(10).TrimStart().TrimEnd(); //Street
                    guest.Suburb = reader.GetString(11).TrimStart().TrimEnd(); //Suburb
                    guest.PostalCode = reader.GetString(12).TrimStart().TrimEnd(); //PostalCode
                    guest.City = reader.GetString(13).TrimStart().TrimEnd(); //City
                    guest.Country = reader.GetString(14).TrimStart().TrimEnd(); //Country
                    guests.Add(guest);
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error reading guest: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }

            return guests;
        }
        #endregion
    }
}
