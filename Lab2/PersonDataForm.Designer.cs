namespace Lab2
{
    partial class PersonDataForm
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
            this.textBoxFIO = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAdress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxFIO
            // 
            this.textBoxFIO.Location = new System.Drawing.Point(95, 39);
            this.textBoxFIO.Name = "textBoxFIO";
            this.textBoxFIO.Size = new System.Drawing.Size(200, 22);
            this.textBoxFIO.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "ФИО:";
            // 
            // textBoxAdress
            // 
            this.textBoxAdress.Location = new System.Drawing.Point(95, 80);
            this.textBoxAdress.Name = "textBoxAdress";
            this.textBoxAdress.Size = new System.Drawing.Size(200, 22);
            this.textBoxAdress.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Адрес:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(190, 126);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(109, 126);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 8;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // PersonDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 180);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxAdress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxFIO);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PersonDataForm";
            this.Text = "PersonDataForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        public System.Windows.Forms.TextBox textBoxFIO;
        public System.Windows.Forms.TextBox textBoxAdress;
    }
}