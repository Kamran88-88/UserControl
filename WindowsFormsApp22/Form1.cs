using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> list = new List<string>() { "A","B","C","D","E"};
        ComboboxUserControl userControl = new ComboboxUserControl();

        private void Form1_Load(object sender, EventArgs e)
        {            
            userControl.SetCombobox(list);
            Controls.Add(userControl);
        }
    }
}
