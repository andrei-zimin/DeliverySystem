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
    public partial class NewCourierForm : Form
    {
        private MainController mainController;

        public NewCourierForm(MainController mainController)
        {
            InitializeComponent();

            this.mainController = mainController;
        }

        private void checkBoxWithCar_CheckedChanged(object sender, EventArgs e)
        {
            txtBxNumberCar.Enabled = checkBoxWithCar.Checked;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string fio = txtBxFIO.Text;
            string phone = txtBxPhone.Text;
            int maxWeight = (int)numericUpDownMaxWeight.Value;
            double latitude = (double)numericUpDownLat.Value;
            double longitude = (double)numericUpDownLong.Value;

            Courier courier;

            if (checkBoxWithCar.Checked)
                courier = new CarCourier(fio, phone, txtBxNumberCar.Text, maxWeight);
            else
                courier = new FootCourier(fio, phone, maxWeight);

            courier.Location = new GeoCoordinate(latitude, longitude);

            mainController.AddCourier(courier);

            DialogResult = DialogResult.OK;
        }
    }
}
