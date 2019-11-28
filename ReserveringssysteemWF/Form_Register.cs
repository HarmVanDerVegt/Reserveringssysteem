using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Reserveringssysteem;

namespace ReserveringssysteemWF
{
    public partial class Form_Register : Form
    {
        public Form_Register()
        {
            InitializeComponent();
        }

        public static bool Validation(ErrorProvider errorProvider, TextBox textBox, string inputTextBox)
        {
            if (String.IsNullOrWhiteSpace(textBox.Text))
            {
                errorProvider.SetError(textBox, inputTextBox);
                return false;
            }
            else
            {
                errorProvider.SetError(textBox, "");
                return true;
            }
        }

        public static bool ValidatePassword(ErrorProvider errorProvider, TextBox textBox)
        {
            if (String.IsNullOrWhiteSpace(textBox.Text))
            {
                errorProvider.SetError(textBox, "Wachtwoord is verplicht");
                return false;
            }
            if (textBox.Text.Length < 6 || textBox.Text.Length > 99)
            {
                errorProvider.SetError(textBox, "Wachtwoord moet minimaal 6 characters bevatten");
                return false;
            }
            else
            {
                errorProvider.SetError(textBox, "");
                return true;
            }
        }

        public static bool ValidatePassword2(ErrorProvider errorProvider, TextBox textBox)
        {
            if (String.IsNullOrWhiteSpace(textBox.Text))
            {
                errorProvider.SetError(textBox, "Wachtwoord is verplicht");
                return false;
            }
            if (textBox.Text != textBox.Text)
            {
                errorProvider.SetError(textBox, "Wachtwoorden zijn niet gelijk aan elkaar");
                return false;
            }
            else
            {
                errorProvider.SetError(textBox, "");
                return true;
            }
        }

        public static bool ValidateHouseNumber(ErrorProvider errorProvider, TextBox textBox)
        {
            if (String.IsNullOrWhiteSpace(textBox.Text))
            {
                errorProvider.SetError(textBox, "Huisnummer is verplicht");
                return false;
            }
            if (!int.TryParse(textBox.Text, out int n))
            {
                errorProvider.SetError(textBox, "Huisnummer moet een nummer zijn");
                return false;
            }
            else
            {
                errorProvider.SetError(textBox, "");
                return true;
            }
        }

        public static bool ValidateZipCode(ErrorProvider errorProvider, TextBox textBox)
        {
            if (String.IsNullOrWhiteSpace(textBox.Text))
            {
                errorProvider.SetError(textBox, "Postcode is verplicht");
                return false;
            }
            if (!IsZipCode(textBox.Text))
            {
                errorProvider.SetError(textBox, "Postcode moet bestaan als volgt \"8000AA\"");
                return false;
            }
            else
            {
                errorProvider.SetError(textBox, "");
                return true;
            }
        }

        private bool ValidateGender()
        {
            bool check = (Rb_MaleGender.Checked || Rb_FemaleGender.Checked);

            errorProvider1.SetIconAlignment(Rb_MaleGender, ErrorIconAlignment.BottomRight);

            if (check)
            {
                errorProvider1.SetError(Rb_MaleGender, "");
                return true;
            }
            else
            {
                errorProvider1.SetError(Rb_MaleGender, "Geslacht is verplicht");
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Valid())
            {
                Gender gender;

                if (Rb_MaleGender.Checked)
                {
                    gender = Gender.Male;
                }
                else
                {
                    gender = Gender.Female;
                }
                Address address;
                if (String.IsNullOrWhiteSpace(Tb_AnnexRegister.Text))
                {
                    address = new Address(Tb_StreetRegister.Text, Convert.ToInt32(Tb_HousenumberRegister.Text), Tb_ZipcodeRegister.Text, Tb_CityRegister.Text);
                }
                else
                {
                    address = new Address(Tb_StreetRegister.Text, Convert.ToInt32(Tb_HousenumberRegister.Text), Tb_AnnexRegister.Text, Tb_ZipcodeRegister.Text, Tb_CityRegister.Text);
                }

                bool result = Member.Register(Tb_NameRegister.Text, DTP_DateRegister.Value, gender, Tb_OrganisationRegister.Text, Tb_EmailRegister.Text, Tb_PasswordRegister.Text, address);

                FinalCheck(result);
            }
        }

        private bool Valid()
        {
            return
                Validation(errorProvider1, Tb_EmailRegister, "Email is verplicht") &&
                ValidatePassword(errorProvider1, Tb_PasswordRegister) &&
                ValidatePassword2(errorProvider1, Tb_Password2Register) &&
                Validation(errorProvider1, Tb_NameRegister, "Naam is verplicht") &&
                Validation(errorProvider1, Tb_OrganisationRegister, "Organisatie is verplicht") &&
                Validation(errorProvider1, Tb_StreetRegister, "Straat is verplicht") &&
                ValidateHouseNumber(errorProvider1, Tb_HousenumberRegister) &&
                ValidateZipCode(errorProvider1, Tb_ZipcodeRegister) &&
                Validation(errorProvider1, Tb_CityRegister, "Stad is verplicht");

                
        }

        private static bool IsZipCode(string str)
        {
            int i = 0;
 
            if (str.Trim().Length != 6)
            {
                return false;
            }

            while (i < 4)
            {
                if (!Char.IsDigit(str[i]))
                {
                    return false;
                }
                i++;
            }

            if (!Char.IsLetter(str[4]) || !Char.IsLetter(str[5]))
            {
                return false;
            }
            return true;
        }

        private void FinalCheck(bool result)
        {
            if (result == false)
            {
                LB_ErrorMessageRegister.Text = "Het Emailadres is niet uniek";
            }
            else
            {
                Dispose();
            }
        }
    }
}
