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

        private bool ValidateEmail()
        {
            if (String.IsNullOrWhiteSpace(Tb_EmailRegister.Text))
            {
                errorProvider1.SetError(Tb_EmailRegister, "Email is verplicht");
                return false;
            }
            else
            {
                errorProvider1.SetError(Tb_EmailRegister, "");
                return true;
            }
        }

        private bool ValidatePassword()
        {
            if (String.IsNullOrWhiteSpace(Tb_PasswordRegister.Text))
            {
                errorProvider1.SetError(Tb_PasswordRegister, "Wachtwoord is verplicht");
                return false;
            }
            else
            {
                errorProvider1.SetError(Tb_PasswordRegister, "");
                return true;
            }
        }

        private bool ValidatePassword2()
        {
            if (String.IsNullOrWhiteSpace(Tb_Password2Register.Text))
            {
                errorProvider1.SetError(Tb_Password2Register, "Wachtwoord is verplicht");
                return false;
            }
            else
            {
                errorProvider1.SetError(Tb_Password2Register, "");
                return true;
            }
        }

        private bool ValidateName()
        {
            if (String.IsNullOrWhiteSpace(Tb_NameRegister.Text))
            {
                errorProvider1.SetError(Tb_NameRegister, "Naam is verplicht");
                return false;
            }
            else
            {
                errorProvider1.SetError(Tb_NameRegister, "");
                return true;
            }
        }

        private bool ValidateOrganisation()
        {
            if (String.IsNullOrWhiteSpace(Tb_OrganisationRegister.Text))
            {
                errorProvider1.SetError(Tb_OrganisationRegister, "Organisatie is verplicht");
                return false;
            }
            else
            {
                errorProvider1.SetError(Tb_OrganisationRegister, "");
                return true;
            }
        }

        private bool ValidateStreet()
        {
            if (String.IsNullOrWhiteSpace(Tb_StreetRegister.Text))
            {
                errorProvider1.SetError(Tb_StreetRegister, "Straat is verplicht");
                return false;
            }
            else
            {
                errorProvider1.SetError(Tb_StreetRegister, "");
                return true;
            }
        }

        private bool ValidateHouseNumber()
        {
            if (String.IsNullOrWhiteSpace(Tb_HousenumberRegister.Text))
            {
                errorProvider1.SetError(Tb_HousenumberRegister, "Huisnummer is verplicht");
                return false;
            }
            else
            {
                errorProvider1.SetError(Tb_HousenumberRegister, "");
                return true;
            }
        }

        private bool ValidateZipCode()
        {
            if (String.IsNullOrWhiteSpace(Tb_ZipcodeRegister.Text))
            {
                errorProvider1.SetError(Tb_ZipcodeRegister, "Postcode is verplicht");
                return false;
            }
            else
            {
                errorProvider1.SetError(Tb_ZipcodeRegister, "");
                return true;
            }
        }

        private bool ValidateCity()
        {
            if (String.IsNullOrWhiteSpace(Tb_CityRegister.Text))
            {
                errorProvider1.SetError(Tb_CityRegister, "Wachtwoord is verplicht");
                return false;
            }
            else
            {
                errorProvider1.SetError(Tb_CityRegister, "");
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
            bool valid =
                ValidateEmail() &&
                ValidatePassword() &&
                ValidatePassword2() &&
                ValidateName() &&
                ValidateOrganisation() &&
                ValidateGender() &&
                ValidateStreet() &&
                ValidateHouseNumber() &&
                ValidateZipCode() &&
                ValidateCity();

            if (valid)
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
                if (Tb_PasswordRegister.Text.Length < 6 || Tb_PasswordRegister.Text.Length > 99)
                {
                    LB_ErrorMessageRegister.Text = "Wachtwoord moet minimaal 6 characters hebben";
                }
                else if (!int.TryParse(Tb_HousenumberRegister.Text, out int n))
                {
                    LB_ErrorMessageRegister.Text = "Huisnummer moet een nummer zijn";
                }
                else if (!IsZipCode(Tb_ZipcodeRegister.Text))
                {
                    LB_ErrorMessageRegister.Text = "Postcode moet bestaan als volgt \"8000AA\"";
                }
                else
                {
                    if (Tb_PasswordRegister.Text != Tb_Password2Register.Text)
                    {
                        LB_ErrorMessageRegister.Text = "Wachtwoorden zijn niet gelijk aan elkaar";
                    }
                    else
                    {
                        if (String.IsNullOrWhiteSpace(Tb_AnnexRegister.Text))
                        {
                            address = new Address(Tb_StreetRegister.Text, Convert.ToInt32(Tb_HousenumberRegister.Text), Tb_ZipcodeRegister.Text, Tb_CityRegister.Text);
                        }
                        else
                        {
                            address = new Address(Tb_StreetRegister.Text, Convert.ToInt32(Tb_HousenumberRegister.Text), Tb_AnnexRegister.Text, Tb_ZipcodeRegister.Text, Tb_CityRegister.Text);
                        }

                        bool result = Member.Register(Tb_NameRegister.Text, DTP_DateRegister.Value, gender, Tb_OrganisationRegister.Text, Tb_EmailRegister.Text, Tb_PasswordRegister.Text, address);

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
        }

        public static bool IsZipCode(string str)
        {
            int i = 0;

            if (str.Length != 6)
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
    }
}
