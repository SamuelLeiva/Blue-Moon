using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace SolucionBlueMoon
{
    public partial class LoginForm : MaterialForm
    {
        public LoginForm()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager manager = MaterialSkin.MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            manager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Blue300,MaterialSkin.Primary.Blue500, MaterialSkin.Primary.Blue500, MaterialSkin.Accent.LightBlue400, MaterialSkin.TextShade.WHITE);

            txtPassword.PasswordChar = '*';
        }
    }
}
