using InfoMgmtFurnitureRentalSystem.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfoMgmtFurnitureRentalSystem.View
{
    public partial class Mainpage : Form
    {
        public Mainpage(MainpageController MainpageController)
        {
            this.InitializeComponent();
            if (MainpageController.CurrentEmployee != null)
            {
                var employee = MainpageController.CurrentEmployee;
                this.EmployeeLabel.Text = employee.EmployeeName + Environment.NewLine + employee.Username + " " +
                                          employee.EmployeeId;
            }
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            var loginScreen = new LoginScreen();
            loginScreen.Show();
            loginScreen.Closed += (s, args) => Close();
            Hide();
        }

        private void AddMemberButton_Click(object sender, EventArgs e)
        {
            var MemberRegistrationController = new MemberRegistrationController();
            var MemberRegistration = new MemberRegistration(MemberRegistrationController);
            MemberRegistration.Show();
            MemberRegistration.Closed += (s, args) => Close();
        }
    }
}
