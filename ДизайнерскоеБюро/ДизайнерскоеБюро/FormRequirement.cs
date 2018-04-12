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
    public partial class FormRequirement : Form
    {
        public OrderRequirements or { get; set; }
        //конструктор
        public FormRequirement(OrderRequirements or)
        {
            this.or = or;
            InitializeComponent();
        }

        //при загрузке формы
        private void FormRequirement_Load(object sender, EventArgs e)
        {
            switch (or.orderObject)
            {
                case OrderObject.Logo:
                    cbObjects.SelectedIndex = 0;
                    break;
                case OrderObject.SiteLayout:
                    cbObjects.SelectedIndex = 1;
                    break;
                case OrderObject.BusinessCard:
                    cbObjects.SelectedIndex = 2;
                    break;
                case OrderObject.Banner:
                    cbObjects.SelectedIndex = 3;
                    break;
            }
            txRequirement.Text = or.requirement;
            mtbKoef.Text = or.koef.ToString();

        }

        //сохранение требования
        private void btOK_Click(object sender, EventArgs e)
        {
            switch (cbObjects.SelectedIndex)
            {
                case 0: or.orderObject = OrderObject.Logo;
                    break;
                case 1: or.orderObject = OrderObject.SiteLayout;
                    break;
                case 2: or.orderObject = OrderObject.BusinessCard;
                    break;
                case 3: or.orderObject = OrderObject.Banner;
                    break;
            }
            or.requirement = txRequirement.Text;
            or.koef = Convert.ToDecimal(mtbKoef.Text);
        }
    }
}
