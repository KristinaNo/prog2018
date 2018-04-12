namespace ДизайнерскоеБюро
{
    partial class FormRequirement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cbObjects = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txRequirement = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mtbKoef = new System.Windows.Forms.MaskedTextBox();
            this.btOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Объект";
            // 
            // cbObjects
            // 
            this.cbObjects.FormattingEnabled = true;
            this.cbObjects.Items.AddRange(new object[] {
            "Логотип",
            "Макет сайта",
            "Визитная карточка",
            "Баннер"});
            this.cbObjects.Location = new System.Drawing.Point(120, 18);
            this.cbObjects.Name = "cbObjects";
            this.cbObjects.Size = new System.Drawing.Size(229, 21);
            this.cbObjects.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Требование";
            // 
            // txRequirement
            // 
            this.txRequirement.Location = new System.Drawing.Point(120, 56);
            this.txRequirement.Multiline = true;
            this.txRequirement.Name = "txRequirement";
            this.txRequirement.Size = new System.Drawing.Size(229, 45);
            this.txRequirement.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Коэффициент сложности";
            // 
            // mtbKoef
            // 
            this.mtbKoef.Location = new System.Drawing.Point(177, 116);
            this.mtbKoef.Mask = "0.00";
            this.mtbKoef.Name = "mtbKoef";
            this.mtbKoef.Size = new System.Drawing.Size(172, 20);
            this.mtbKoef.TabIndex = 5;
            // 
            // btOK
            // 
            this.btOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btOK.Location = new System.Drawing.Point(130, 157);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(117, 23);
            this.btOK.TabIndex = 6;
            this.btOK.Text = "Добавить";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // FormRequirement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 203);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.mtbKoef);
            this.Controls.Add(this.txRequirement);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbObjects);
            this.Controls.Add(this.label1);
            this.Name = "FormRequirement";
            this.Text = "Требование к заказу";
            this.Load += new System.EventHandler(this.FormRequirement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbObjects;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txRequirement;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtbKoef;
        private System.Windows.Forms.Button btOK;
    }
}