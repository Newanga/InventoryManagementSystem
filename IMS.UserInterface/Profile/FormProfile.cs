using IMS.Core.ViewModels;
using IMS.DataAccess.FormProfileData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS.UserInterface.Profile
{
    public partial class FormProfile : Form
    {
        private readonly IFormProfileSql _db;

        private ProfileVM data;

        public FormProfile(IFormProfileSql db)
        {
            InitializeComponent();
            _db = db;
            LoadProfileData();
            PopulateProfileData();
        }

        private void LoadProfileData()
        {
            data = _db.GetProfileDetails();
        }

        private void PopulateProfileData()
        {
            txtBxAddress.Text = data.Address;
            txtBxDOB.Text = data.DateOfBirth.Date.ToShortDateString();
            txtBxEmailAddress.Text = data.EmailAddress;
            txtBxFirstName.Text = data.FirstName;
            txtBxLastName.Text = data.LastName;
            txtBxRole.Text = data.Role;
            txtBxStartDate.Text = data.StartDate.Date.ToShortDateString();
            txtBxUsername.Text = data.Username;

        }
    }
}
