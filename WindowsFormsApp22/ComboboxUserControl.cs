using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp22
{
    public partial class ComboboxUserControl : UserControl
    {
        public ComboboxUserControl()
        {
            InitializeComponent();
        }

        public void SetCombobox(List<string> list)
        {
            comboBox1.Items.AddRange(list.ToArray());
        }
    }
}
