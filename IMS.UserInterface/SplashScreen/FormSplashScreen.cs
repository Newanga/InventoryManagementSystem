using IMS.Common.Cache;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS.UserInterface.SplashScreen
{
    public partial class FormSplashScreen : Form
    {
        public FormSplashScreen()
        {
            InitializeComponent();
            lblActiveUserFirstName.Text = Cache.FirstName;
        }
    }
}
