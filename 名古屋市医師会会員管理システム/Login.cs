using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 名古屋市医師会会員管理システム;

namespace 名古屋市医師会会員管理システム
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void showMenu_Click(object sender, EventArgs e)
        {
            Menu window = new Menu();
            this.Hide();
            window.ShowDialog();
            this.Close();
        }
    }
}
