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
using System.Data.Entity;

namespace ReserveringssysteemWF
{
    public partial class Form_Mainscreen : Form
    {
        public Form_Mainscreen()
        {
            InitializeComponent();
            this.MinimumSize = new Size(600, 300);
            tabControl1.TabPages.Remove(tab_Reservations);
            tabControl1.TabPages.Remove(tab_Profiles);
            tabControl1.TabPages.Remove(tab_Members);
            tabControl1.TabPages.Remove(tab_Teams);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowBoatsTable();
            ShowMembersTable();
        }

        private void Bt_AddBoat_Click(object sender, EventArgs e)
        {
            ShowCreateBoatDialog();
        }

        private void ShowCreateBoatDialog()
        {
            Form_AddBoat CreateBoatDialog = new Form_AddBoat();
            CreateBoatDialog.ShowDialog();
            ShowBoatsTable();
        }

        public void ShowBoatsTable()
        {
            Datagrid_Boats.Rows.Clear();

            string hasCoxswain = "";
            using (var db = new ReserveringssysteemContext())
            {
                var sortBoats = (from b in db.Boats
                                 orderby b.BoatType.Size, b.BoatType.HasCoxswain, b.BoatType.Name
                                 select b);

                foreach (var b in sortBoats.Include(b => b.BoatType))
                {
                    if (b.BoatType.HasCoxswain)
                        hasCoxswain = "Ja";
                    else
                        hasCoxswain = "Nee";

                    for (int i = 0; i < Datagrid_Boats.Rows.Count; i++)
                    {
                        if ((string)Datagrid_Boats.Rows[i].Cells[0].Value == b.BoatType.Name)
                        {
                            Datagrid_Boats.Rows.RemoveAt(i);
                        }
                    }
                    if (b.BoatStatus == BoatStatus.Whole)
                        Datagrid_Boats.Rows.Add(b.BoatType.Name, b.BoatType.Size, hasCoxswain, AmountOfBoats(b));
                }
            }
        }

        public void ShowMembersTable()
        {
            Datagrid_Members.Rows.Clear();
            using (var db = new ReserveringssysteemContext())
            {
                var sortMembers = (from member in db.Members
                                   orderby member.Name
                                   select member);

                foreach (var m in sortMembers.Include(m => m.Address))
                {
                    Datagrid_Members.Rows.Add(m.Name, m.Email, m.Organisation);
                }
            }
        }

        private int AmountOfBoats(Boat boat)
        {
            return boat.BoatType.Boats.Count;
        }

        private void Bt_DeleteBoat_Click(object sender, EventArgs e)
        {
            using (var db = new ReserveringssysteemContext())
            {
                foreach (DataGridViewRow row in Datagrid_Boats.SelectedRows)
                {
                    string typeName = (string)row.Cells[0].Value;

                    db.Boats.Remove(
                        db.Boats.Include(b => b.BoatType).Where(b => b.BoatType.Name == typeName).First()
                        );

                    db.SaveChanges();
                    ShowBoatsTable();
                }
            }
        }

        private void Bt_RemoveBoatFromUse_Click(object sender, EventArgs e)
        {
            Form_RemoveBoatFromUse Dialog_RemoveBoatFromUse = new Form_RemoveBoatFromUse(this);
            Dialog_RemoveBoatFromUse.ShowDialog();
        }

        private void Bt_ReportDamage_Click(object sender, EventArgs e)
        {
            Form_ReportDamage Dialog_ReportDamage = new Form_ReportDamage();
            Dialog_ReportDamage.ShowDialog();
        }

        private void Login_AccountMenuItem_Click(object sender, EventArgs e)
        {
            Form_Login LoginForm = new Form_Login(this);
            LoginForm.ShowDialog();
        }

        private void Logout_AccountMenuItem_Click(object sender, EventArgs e)
        {
            if (Member.CurrentMember.HasRole(RoleType.ChiefOfEquipment))
            {
                ChiefOfEquipmentActions();
            }
            if (Member.CurrentMember.HasRole(RoleType.TournamentOrganiser))
            {
                TournamantOrganizerActions();
            }
            if (Member.CurrentMember.HasRole(RoleType.Admin))
            {
                AdminActions();
            }
            Member.Logout();
            MemberActions();

        }

        public void LoginScreen()
        {
            MemberActions();
            if (Member.CurrentMember.HasRole(RoleType.ChiefOfEquipment))
            {
                ChiefOfEquipmentActions();
            }
            if (Member.CurrentMember.HasRole(RoleType.TournamentOrganiser))
            {
                TournamantOrganizerActions();
            }
            if (Member.CurrentMember.HasRole(RoleType.Admin))
            {
                AdminActions();
            }
        }

        public void MemberActions()
        {

            if (Member.CurrentMember == null)
            {
                Lb_WelcomeMessage.Text = "";
                Login_AccountMenuItem.Visible = true;
                Logout_AccountMenuItem.Visible = false;
            }
            else
            {
                Lb_WelcomeMessage.Text = $"Welkom, {Member.CurrentMember.Name}";
                Logout_AccountMenuItem.Visible = true;
                Login_AccountMenuItem.Visible = false;
            }

            if (tabControl1.Contains(tab_Reservations))
            {
                tabControl1.TabPages.Remove(tab_Reservations);
            }
            else
            {
                tabControl1.TabPages.Add(tab_Reservations);
            }

            Bt_ReportDamage.Visible = !Bt_ReportDamage.Visible;
            Bt_AddReservation.Visible = !Bt_AddReservation.Visible;
            Bt_ModifyReservation.Visible = !Bt_ModifyReservation.Visible;
            Bt_RemoveReservation.Visible = !Bt_RemoveReservation.Visible;
        }

        public void ChiefOfEquipmentActions()
        {
            Bt_RemoveBoatFromUse.Visible = !Bt_RemoveBoatFromUse.Visible;
            Bt_AddBoat.Visible = !Bt_AddBoat.Visible;
            Bt_DeleteBoat.Visible = !Bt_DeleteBoat.Visible;
        }

        public void TournamantOrganizerActions()
        {
            Bt_AddGame.Visible = !Bt_AddGame.Visible;
            Bt_RemoveGame.Visible = !Bt_RemoveGame.Visible;

            if (tabControl1.Contains(tab_Teams))
            {
                tabControl1.TabPages.Remove(tab_Teams);
            }
            else
            {
                tabControl1.TabPages.Add(tab_Teams);
            }

            Bt_CreateTeam.Visible = !Bt_CreateTeam.Visible;
            Bt_ModifyTeam.Visible = !Bt_ModifyTeam.Visible;
            Bt_RemoveTeam.Visible = !Bt_RemoveTeam.Visible;
        }

        public void AdminActions()
        {
            if (tabControl1.Contains(tab_Profiles))
            {
                tabControl1.TabPages.Remove(tab_Profiles);
            }
            else
            {
                tabControl1.TabPages.Add(tab_Profiles);
            }

            Bt_MakeProfile.Visible = !Bt_MakeProfile.Visible;
            Bt_ModifyProfile.Visible = !Bt_ModifyProfile.Visible;
            Bt_RemoveProfile.Visible = !Bt_RemoveProfile.Visible;

            if (tabControl1.Contains(tab_Members))
            {
                tabControl1.TabPages.Remove(tab_Members);
            }
            else
            {
                tabControl1.TabPages.Add(tab_Members);
            }

            Bt_AddMember.Visible = !Bt_AddMember.Visible;
            Bt_ModifyMember.Visible = !Bt_ModifyMember.Visible;
            Bt_RemoveMember.Visible = !Bt_RemoveMember.Visible;
            Bt_AddMember.Visible = !Bt_AddMember.Visible;
        }

        private void Lb_WelcomeMessage_Paint(object sender, PaintEventArgs e)
        {
            if (Member.CurrentMember != null)
            {
                Lb_WelcomeMessage.Text = "Welkom " + Member.CurrentMember.Name;
            }
            else
            {
                Lb_WelcomeMessage.Text = "";
            }
        }

        private void Bt_AddReservation_Click(object sender, EventArgs e)
        {
            new ReservationDialog().ShowDialog();
        }

        private void Bt_AddMember_Click(object sender, EventArgs e)
        {
            Form_Register RegisterForm = new Form_Register();
            RegisterForm.ShowDialog();
            ShowMembersTable();
        }

        private void Bt_ModifyMember_Click(object sender, EventArgs e)
        {
            Member selectedMember = null;
            using (var db = new ReserveringssysteemContext())
            {
                foreach (DataGridViewRow row in Datagrid_Members.SelectedRows)
                {
                    string EmailMember = (string)row.Cells[1].Value;

                    selectedMember = (from m in db.Members
                                          where EmailMember == m.Email
                                          select m).Single();
                }
            }

            new Form_ModifyMember(selectedMember.ID).ShowDialog();
            ShowMembersTable();
        }
    }
}
