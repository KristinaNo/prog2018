using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ДизайнерскоеБюроDLL;

namespace ДизайнерскоеБюро
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //получить модель заказа на основании введенных данных
        Order GetModelFromUI()
        {
            return new Order()
            {
                dtOrder = dtDateOrder.Value,
                numOrder = txNumOrder.Text,
                customer = new Customer
                {
                    nameCustomer = txNameCustomer.Text,
                    address = txAddress.Text,
                    phone = mtxbPhone.Text
                },
                orderRequirements = lbOrderRequirements.Items.OfType<OrderRequirements>().ToList(),
                peopleExec = lbPeopleExec.Items.OfType<PeopleExec>().ToList(),
                price = Convert.ToDecimal(txPrice.Text)
            };
        }
        //загрузить данные по заказу на форму
        private void SetModelToUI(Order ord)
        {
            dtDateOrder.Value = ord.dtOrder;
            txNumOrder.Text = ord.numOrder;
            txNameCustomer.Text = ord.customer.nameCustomer;
            txAddress.Text = ord.customer.address;
            mtxbPhone.Text = ord.customer.phone;
            lbOrderRequirements.Items.Clear();
            foreach (var e in ord.orderRequirements)
            {
                lbOrderRequirements.Items.Add(e);
            }
            lbPeopleExec.Items.Clear();
            foreach (var e in ord.peopleExec)
            {
                lbPeopleExec.Items.Add(e);
            }
            txPrice.Text = ord.price.ToString();
        }

        //добавить требование
        private void btAddRequirement_Click(object sender, EventArgs e)
        {
            var form = new FormRequirement(new OrderRequirements());
            var res = form.ShowDialog(this);
            if (res == DialogResult.OK)
            {
                lbOrderRequirements.Items.Add(form.or);
                RecalculatePrice();
            }
        }

        //добавить исполнителя
        private void btAddPeople_Click(object sender, EventArgs e)
        {
            var form = new FormPeople(new PeopleExec());
            var res = form.ShowDialog(this);
            if (res == DialogResult.OK)
            {
                lbPeopleExec.Items.Add(form.people);
                RecalculatePrice();
            }
        }

        //удалить требование
        private void btDelRequirement_Click(object sender, EventArgs e)
        {
            var si = lbOrderRequirements.SelectedIndex;
            lbOrderRequirements.Items.RemoveAt(si);
            RecalculatePrice();
        }

        //удалить исполнителя
        private void btDelPeople_Click(object sender, EventArgs e)
        {
            var si = lbPeopleExec.SelectedIndex;
            lbPeopleExec.Items.RemoveAt(si);
        }

        //сохранить в файл
        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                var sfd = new SaveFileDialog() { Filter = "Файлы заказов|*.desbur" };
                var result = sfd.ShowDialog(this);
                if (result == DialogResult.OK)
                {
                    var dto = GetModelFromUI();
                    OrderHelper.WriteToFile(sfd.FileName, dto);
                }
            }
            catch
            {
                MessageBox.Show("Проверьте корректность заполнения данных", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //загрузить из файла
        private void btLoad_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog() { Filter = "Файл заказа|*.desbur" };
            var result = ofd.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                var dto = OrderHelper.LoadFromFile(ofd.FileName);
                SetModelToUI(dto);
            }
        }

        //пересчитать стоимость заказа
        private void RecalculatePrice()
        {
            decimal price = 500;

            foreach (var req in lbOrderRequirements.Items.OfType<OrderRequirements>().ToList())
            {
                switch (req.orderObject)
                {
                    case OrderObject.Logo:
                        price += 1000 * req.koef;
                        break;
                    case OrderObject.SiteLayout:
                        price += 3000 * req.koef;
                        break;
                    case OrderObject.BusinessCard:
                        price += 500 * req.koef;
                        break;
                    case OrderObject.Banner:
                        price += 2500;
                        break;
                }
            }

            txPrice.Text = price.ToString();
        }
    }
}
