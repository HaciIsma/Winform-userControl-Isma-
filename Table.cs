using System;
using System.Windows.Forms;

namespace usercontrol
{
    public partial class Table : UserControl
    {

        public string TableTitle { get => tableBtn.Text; set => tableBtn.Text = value; }

        public event EventHandler<EventArgs> TableClicked = delegate { };

        public Table()
        {
            InitializeComponent();
        }

        private void tableBtn_Click(object sender, EventArgs e)
        {
            TableClicked.Invoke(sender, e);
        }
    }
}
