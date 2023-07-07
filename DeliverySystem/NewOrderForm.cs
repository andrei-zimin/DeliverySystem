using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeliverySystem
{
    public partial class NewOrderForm : Form
    {
        MainController mainController;

        public NewOrderForm(MainController mainController)
        {
            InitializeComponent();

            this.mainController = mainController;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            double weight = (double)numericUpDownMaxWeight.Value;
            GeoCoordinate start = new GeoCoordinate((double)numericUpDownLat.Value, (double)numericUpDownLong.Value);
            GeoCoordinate end = new GeoCoordinate((double)numericUpDown2.Value, (double)numericUpDown1.Value);

            mainController.AddOrder(weight, start, end);
            DialogResult = DialogResult.OK;
        }
    }
}
