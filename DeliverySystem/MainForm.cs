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
    public partial class MainForm : Form
    {
        private MainController mainController;

        public MainForm()
        {
            InitializeComponent();

            mainController = new MainController(new MinimalDistanceStrategy());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;

            UpdateGridCouries();
            UpdateGridOrders();
        }

        private void UpdateGridCouries()
        {
            dataGridView1.DataSource = null;
            if (mainController.Couriers.Count > 0)
            {
                if (comboBox1.SelectedIndex == 0)
                    dataGridView1.DataSource = mainController.Couriers;
                else if (comboBox1.SelectedIndex == 1)
                    dataGridView1.DataSource = mainController.Couriers.Where(t=>t.IsAvailable).ToList();
                else
                    dataGridView1.DataSource = mainController.Couriers.Where(t => !t.IsAvailable).ToList();
            }
        }

        private void UpdateGridOrders()
        {
            dataGridView2.DataSource = null;
            if (mainController.Orders.Count > 0)
            {
                if (comboBox2.SelectedIndex == 0)
                    dataGridView2.DataSource = mainController.Orders;
                else if (comboBox2.SelectedIndex == 1)
                    dataGridView2.DataSource = mainController.Orders.Where(t => t.Courier == null).ToList();
                else if (comboBox2.SelectedIndex == 2)
                    dataGridView2.DataSource = mainController.Orders.Where(t => t.Courier != null && t.FinishDateDelivery == DateTime.MinValue).ToList();
                else 
                    dataGridView2.DataSource = mainController.Orders.Where(t => t.Courier != null && t.FinishDateDelivery != DateTime.MinValue).ToList();
            }
        }

        private void btnAddCourier_Click(object sender, EventArgs e)
        {
            NewCourierForm form = new NewCourierForm(mainController);
            if (form.ShowDialog() == DialogResult.OK)
            {
                UpdateGridCouries();
            }
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            NewOrderForm form = new NewOrderForm(mainController);
            if (form.ShowDialog() == DialogResult.OK)
            {
                UpdateGridOrders();
            }
        }

        private void btnAssignCourier_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                Order order = dataGridView2.SelectedRows[0].DataBoundItem as Order;
                if (order.Courier != null)
                {
                    MessageBox.Show("Курьер уже назначен. Ожидайте!");
                    return;
                }

                bool res = mainController.AssignCourier(order);
                if (res)
                {
                    MessageBox.Show("Курьер назначен");
                    UpdateGridOrders();
                }
                else
                {
                    MessageBox.Show("Курьер не назначен");
                }
            }
        }

        private void btnCompleteOrder_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                Order order = dataGridView2.SelectedRows[0].DataBoundItem as Order;

                mainController.CompleteOrder(order);
                UpdateGridOrders();
            }
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                Order order = dataGridView2.SelectedRows[0].DataBoundItem as Order;
                if (order.Courier != null && order.FinishDateDelivery == DateTime.MinValue)
                    btnCompleteOrder.Enabled = true;
               else
                    btnCompleteOrder.Enabled = false;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateGridCouries();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateGridOrders();
        }
    }
}
