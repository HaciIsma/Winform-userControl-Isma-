using System;
using System.Windows.Forms;

namespace usercontrol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            table.TableTitle = "Hakuna";

            table.TableClicked += Table_TableClicked;
            table2.TableTitle = "Matata";
            table2.TableClicked += Table_TableClicked;
        }

        private void Table_TableClicked(object sender, EventArgs e)
        {
            MessageBox.Show((sender as Button).Text);
        }
    }
}
