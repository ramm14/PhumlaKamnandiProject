using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PhumlaKamnandiProject.Business
{
    public enum IdentityDocument
    {
        NationalID = 1,
        PassportNo = 2
    }
    public class Guest
    {
        #region Data Members
        private string _guestID;
        private string _firstName;
        private string _lastName;
        private string _email;
        private string _phoneNo;
        private DateTime? _cardExpiry;
        private string _cardNo;
        private string _street;
        private string _suburb;
        private string _postalCode;
        private string _city;
        private string _country;
        private DateTime _createdDate;
        private string _identificationNumber; //  South African ID OR PassPort Number
        private IdentityDocument _identificationType;
        private string _cvv;



        #endregion




        #region Properties
        public string GuestID
        {
            set { _guestID = value; }
            get { return _guestID; }
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string PhoneNumber
        {
            get { return _phoneNo; }
            set { _phoneNo = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public IdentityDocument IdentificationType
        {
            get { return _identificationType; }
            set { _identificationType = value; }
        }

        public string IdentificationNumber
        {
            get { return _identificationNumber; }
            set { _identificationNumber = value; }
        }

        public DateTime CreatedDate
        {
            get { return _createdDate; }
            set { _createdDate = value; }
        }

        public DateTime? CardExpiry
        {
            get { return _cardExpiry; }
            set { _cardExpiry = value; }
        }

        public string CardNo
        {
            get { return _cardNo; }
            set { _cardNo = value; }
        }
        public string Street
        {
            get { return _street; }
            set { _street = value; }
        }

        public string Suburb
        {
            get { return _suburb; }
            set { _suburb = value; }
        }

        public string PostalCode
        {
            get { return _postalCode; }
            set { _postalCode = value; }
        }

        public string City
        {
            get { return _city; }
            set { _city = value; }
        }

        public string Country
        {
            get { return _country; }
            set { _country = value; }
        }

        
        public string CVV
        {
            get { return _cvv; }
            set { _cvv = value; }
        }


        #endregion
        public Guest(string firstName, string lastName, string email, string phoneNo, string idNo, IdentityDocument idType, string street, string suburb, string postalCode, string city, string country)
        {

            _firstName = firstName;
            _lastName = lastName;
            _email = email;
            _phoneNo = phoneNo;
            _street = street;
            _suburb = suburb;
            _postalCode = postalCode;
            _city = city;
            _country = country;
            _identificationNumber = idNo;
            _identificationType = idType;
            _createdDate = DateTime.Now;
            generateGuestID();


        }

        private void generateGuestID()
        {

            string alphaValues = _lastName.Substring(_lastName.Length - 2).ToUpper() + _firstName[0];
            Random rand = new Random();
            string digits = rand.Next(0, 1000).ToString("D3");
            string id = alphaValues + digits;
            _guestID = id;
        }

        public Guest()
        {

        }

        public string GetFullName()
        {
            return $"{_firstName} {_lastName}";
        }
        public string GetContactDetails()
        {
            return $"Email: {_email}, Phone: {_phoneNo}";
        }

        public void UpdatePaymentDetails(DateTime cardExpiry, string cardNumber)
        {
            _cardExpiry = cardExpiry;
            _cardNo = cardNumber;
        }
        public string GetFullAddress()
        {
            return $"{_street},{_suburb}, {_city}, {_postalCode}, {_country}";
        }
        public bool ValidateEmail()
        {
            if (string.IsNullOrEmpty(_email))
                return false;

            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(_email, pattern);

        }

        public bool ValidateIDNumber()
        {
            //    if (IdentificationType != GuestType.Local || string.IsNullOrEmpty(idNumber))
            //        return false;

            // SA ID must be 13 digits
            switch (_identificationType)
            {
                case (IdentityDocument.NationalID):
                    if(_identificationNumber.Length != 13)
                    {
                        return false;
                    }
                    break;
                case (IdentityDocument.PassportNo):
                    if (_identificationNumber.Length < 6 || _identificationNumber.Length > 20)
                    {
                        return false;

                    }
                    break;
             }


            // Check if all characters are digits
            foreach (char c in _identificationNumber)
            {
                if (!char.IsDigit(c))
                    return false;
            }

            return true;
        }


        public decimal payDeposit(decimal deposit, Booking booking)
        {
            return deposit;
        }


    }
}
