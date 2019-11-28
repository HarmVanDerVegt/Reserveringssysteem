﻿using Reserveringssysteem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace ReserveringssysteemWF
{
    public partial class Form_ModifyMember : Form
    {
        Member member = null;
        List<Certificate> certificatesList = null;
        List<Role> roles = null;
        public Form_ModifyMember(int ID)
        {
            InitializeComponent();

            using (var db = new ReserveringssysteemContext())
            {
                member = (from m in db.Members.Include(m => m.Address).Include(m => m.Levels)
                          where m.ID == ID
                          select m).Single();

                certificatesList = (from c in member.Levels
                                    select c).ToList();

                roles = (from r in member.Roles
                         select r).ToList();
            }
            ShowMemberInformation();
        }

        private void ShowMemberInformation()
        {
            Tb_Email.Text = member.Email;
            Tb_Name.Text = member.Name;
            DTP_Date.Value = member.DateOfBirth;
            Tb_Organisation.Text = member.Organisation;
            Tb_Street.Text = member.Address.Street;
            Tb_Housenumber.Text = Convert.ToString(member.Address.HouseNumber);
            Tb_Annex.Text = member.Address.Suffix;
            Tb_Zipcode.Text = member.Address.ZIP;
            Tb_City.Text = member.Address.City;

            if (member.Gender == Gender.Male)
            {
                Rb_MaleGender.Checked = true;
                Rb_FemaleGender.Checked = false;
            }
            else
            {
                Rb_FemaleGender.Checked = true;
                Rb_MaleGender.Checked = false;
            }

            foreach (var c in certificatesList)
            {
                Lb_Certificaat.Items.Add(c.Name);
            }

            foreach (var r in roles)
            {
                Lb_Roles.Items.Add(r.Type);
            }
        }
        private void MemberCredentialsValidation()
        {
            //Field checks
            Form_Register.Validation(errorProvider1, Tb_Email, "Email is verplicht");
            //Form_Register.ValidatePassword(errorProvider1, Tb_Password);
            Form_Register.Validation(errorProvider1, Tb_Name, "Naam is verplicht");
            Form_Register.Validation(errorProvider1, Tb_Organisation, "Organisatie is verplicht");
            Form_Register.Validation(errorProvider1, Tb_Street, "Straat is verplicht");
            Form_Register.ValidateHouseNumber(errorProvider1, Tb_Housenumber);
            Form_Register.ValidateZipCode(errorProvider1, Tb_Zipcode);
            Form_Register.Validation(errorProvider1, Tb_City, "Stad is verplicht");
        }

        private void ChangeMemberInformation()
        {
            member.Email = Tb_Email.Text;
            member.Name = Tb_Name.Text;
            member.DateOfBirth = DTP_Date.Value;
            member.Organisation = Tb_Organisation.Text;
            member.Address.Street = Tb_Street.Text;
            member.Address.HouseNumber = Convert.ToInt32(Tb_Housenumber.Text);
            member.Address.Suffix = Tb_Annex.Text;
            member.Address.ZIP = Tb_Zipcode.Text;
            member.Address.City = Tb_City.Text;


        }
        private void Bt_ChangeMember_Click(object sender, EventArgs e)
        {
            MemberCredentialsValidation();
            //Change credentials
            using (var db = new ReserveringssysteemContext())
            {
                ChangeMemberInformation();

                if (Rb_MaleGender.Checked)
                {
                    member.Gender = Gender.Male;
                }
                else
                {
                    member.Gender = Gender.Female;
                }

                db.Members.AddOrUpdate(member);
                db.Addresses.AddOrUpdate(member.Address);
                db.SaveChanges();


            }

        }
    }
}

