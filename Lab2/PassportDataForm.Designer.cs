namespace Lab2
{
    partial class PassportDataForm
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
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(179, 95);
            this.dateTimePicker.MaxDate = new System.DateTime(2020, 9, 29, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker.TabIndex = 0;
            this.dateTimePicker.Value = new System.DateTime(2020, 9, 29, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Номер паспорта";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Дата выдачи";
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(179, 53);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(200, 22);
            this.textBoxNumber.TabIndex = 3;
            this.textBoxNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(179, 156);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 4;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(260, 156);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // PassportDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 211);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PassportDataForm";
            this.Text = "PassportDataForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        public System.Windows.Forms.DateTimePicker dateTimePicker;
        public System.Windows.Forms.TextBox textBoxNumber;
    }
}