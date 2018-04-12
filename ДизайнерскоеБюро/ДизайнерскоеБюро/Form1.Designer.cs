namespace ДизайнерскоеБюро
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dtDateOrder = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txNumOrder = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txNameCustomer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gbCustomer = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mtxbPhone = new System.Windows.Forms.MaskedTextBox();
            this.lbOrderRequirements = new System.Windows.Forms.ListBox();
            this.btAddRequirement = new System.Windows.Forms.Button();
            this.btDelRequirement = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lbPeopleExec = new System.Windows.Forms.ListBox();
            this.btAddPeople = new System.Windows.Forms.Button();
            this.btDelPeople = new System.Windows.Forms.Button();
            this.btLoad = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txPrice = new System.Windows.Forms.TextBox();
            this.gbCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дата заказа";
            // 
            // dtDateOrder
            // 
            this.dtDateOrder.Location = new System.Drawing.Point(213, 15);
            this.dtDateOrder.Name = "dtDateOrder";
            this.dtDateOrder.Size = new System.Drawing.Size(157, 20);
            this.dtDateOrder.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Номер заказа";
            // 
            // txNumOrder
            // 
            this.txNumOrder.Location = new System.Drawing.Point(213, 57);
            this.txNumOrder.Name = "txNumOrder";
            this.txNumOrder.Size = new System.Drawing.Size(157, 20);
            this.txNumOrder.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Наименование (ФИО)";
            // 
            // txNameCustomer
            // 
            this.txNameCustomer.Location = new System.Drawing.Point(157, 16);
            this.txNameCustomer.Name = "txNameCustomer";
            this.txNameCustomer.Size = new System.Drawing.Size(157, 20);
            this.txNameCustomer.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Адрес";
            // 
            // txAddress
            // 
            this.txAddress.Location = new System.Drawing.Point(157, 55);
            this.txAddress.Name = "txAddress";
            this.txAddress.Size = new System.Drawing.Size(157, 20);
            this.txAddress.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Телефон";
            // 
            // gbCustomer
            // 
            this.gbCustomer.Controls.Add(this.mtxbPhone);
            this.gbCustomer.Controls.Add(this.label5);
            this.gbCustomer.Controls.Add(this.txAddress);
            this.gbCustomer.Controls.Add(this.label4);
            this.gbCustomer.Controls.Add(this.txNameCustomer);
            this.gbCustomer.Controls.Add(this.label3);
            this.gbCustomer.Location = new System.Drawing.Point(56, 90);
            this.gbCustomer.Name = "gbCustomer";
            this.gbCustomer.Size = new System.Drawing.Size(336, 133);
            this.gbCustomer.TabIndex = 4;
            this.gbCustomer.TabStop = false;
            this.gbCustomer.Text = "Информация о заказчике";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Требования к заказу";
            // 
            // mtxbPhone
            // 
            this.mtxbPhone.Location = new System.Drawing.Point(157, 90);
            this.mtxbPhone.Mask = "(999) 000-0000";
            this.mtxbPhone.Name = "mtxbPhone";
            this.mtxbPhone.Size = new System.Drawing.Size(157, 20);
            this.mtxbPhone.TabIndex = 4;
            // 
            // lbOrderRequirements
            // 
            this.lbOrderRequirements.FormattingEnabled = true;
            this.lbOrderRequirements.Location = new System.Drawing.Point(25, 294);
            this.lbOrderRequirements.Name = "lbOrderRequirements";
            this.lbOrderRequirements.Size = new System.Drawing.Size(296, 160);
            this.lbOrderRequirements.TabIndex = 6;
            // 
            // btAddRequirement
            // 
            this.btAddRequirement.Location = new System.Drawing.Point(25, 265);
            this.btAddRequirement.Name = "btAddRequirement";
            this.btAddRequirement.Size = new System.Drawing.Size(44, 23);
            this.btAddRequirement.TabIndex = 7;
            this.btAddRequirement.Text = "+";
            this.btAddRequirement.UseVisualStyleBackColor = true;
            this.btAddRequirement.Click += new System.EventHandler(this.btAddRequirement_Click);
            // 
            // btDelRequirement
            // 
            this.btDelRequirement.Location = new System.Drawing.Point(75, 265);
            this.btDelRequirement.Name = "btDelRequirement";
            this.btDelRequirement.Size = new System.Drawing.Size(44, 23);
            this.btDelRequirement.TabIndex = 7;
            this.btDelRequirement.Text = "-";
            this.btDelRequirement.UseVisualStyleBackColor = true;
            this.btDelRequirement.Click += new System.EventHandler(this.btDelRequirement_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(340, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Исполнители заказа";
            // 
            // lbPeopleExec
            // 
            this.lbPeopleExec.FormattingEnabled = true;
            this.lbPeopleExec.Location = new System.Drawing.Point(343, 294);
            this.lbPeopleExec.Name = "lbPeopleExec";
            this.lbPeopleExec.Size = new System.Drawing.Size(272, 160);
            this.lbPeopleExec.TabIndex = 6;
            // 
            // btAddPeople
            // 
            this.btAddPeople.Location = new System.Drawing.Point(343, 265);
            this.btAddPeople.Name = "btAddPeople";
            this.btAddPeople.Size = new System.Drawing.Size(44, 23);
            this.btAddPeople.TabIndex = 7;
            this.btAddPeople.Text = "+";
            this.btAddPeople.UseVisualStyleBackColor = true;
            this.btAddPeople.Click += new System.EventHandler(this.btAddPeople_Click);
            // 
            // btDelPeople
            // 
            this.btDelPeople.Location = new System.Drawing.Point(393, 265);
            this.btDelPeople.Name = "btDelPeople";
            this.btDelPeople.Size = new System.Drawing.Size(44, 23);
            this.btDelPeople.TabIndex = 7;
            this.btDelPeople.Text = "-";
            this.btDelPeople.UseVisualStyleBackColor = true;
            this.btDelPeople.Click += new System.EventHandler(this.btDelPeople_Click);
            // 
            // btLoad
            // 
            this.btLoad.Location = new System.Drawing.Point(498, 475);
            this.btLoad.Name = "btLoad";
            this.btLoad.Size = new System.Drawing.Size(117, 23);
            this.btLoad.TabIndex = 7;
            this.btLoad.Text = "Открыть";
            this.btLoad.UseVisualStyleBackColor = true;
            this.btLoad.Click += new System.EventHandler(this.btLoad_Click);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(375, 475);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(117, 23);
            this.btSave.TabIndex = 7;
            this.btSave.Text = "Сохранить";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(416, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Стоимость";
            // 
            // txPrice
            // 
            this.txPrice.Location = new System.Drawing.Point(484, 203);
            this.txPrice.Name = "txPrice";
            this.txPrice.Size = new System.Drawing.Size(131, 20);
            this.txPrice.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 509);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btLoad);
            this.Controls.Add(this.btDelPeople);
            this.Controls.Add(this.btDelRequirement);
            this.Controls.Add(this.btAddPeople);
            this.Controls.Add(this.btAddRequirement);
            this.Controls.Add(this.lbPeopleExec);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbOrderRequirements);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gbCustomer);
            this.Controls.Add(this.txPrice);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txNumOrder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtDateOrder);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Дизайнерское бюро - Заказ";
            this.gbCustomer.ResumeLayout(false);
            this.gbCustomer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtDateOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txNumOrder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txNameCustomer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbCustomer;
        private System.Windows.Forms.MaskedTextBox mtxbPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lbOrderRequirements;
        private System.Windows.Forms.Button btAddRequirement;
        private System.Windows.Forms.Button btDelRequirement;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lbPeopleExec;
        private System.Windows.Forms.Button btAddPeople;
        private System.Windows.Forms.Button btDelPeople;
        private System.Windows.Forms.Button btLoad;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txPrice;
    }
}

