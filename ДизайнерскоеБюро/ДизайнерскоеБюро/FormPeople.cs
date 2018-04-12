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
    public partial class FormPeople : Form
    {
        public PeopleExec people { get; set; }
        //конструктор
        public FormPeople(PeopleExec people)
        {
            this.people = people;
            InitializeComponent();
        }

        //при загрузке формы
        private void FormPeople_Load(object sender, EventArgs e)
        {
            txName.Text = people.namePeople;
            txPost.Text = people.post;
        }

        //сохранение исполнителя
        private void btOK_Click(object sender, EventArgs e)
        {
            people.namePeople = txName.Text;
            people.post = txPost.Text;
        }

    }
}
