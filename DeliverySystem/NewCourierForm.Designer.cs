namespace DeliverySystem
{
    partial class NewCourierForm
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
            this.txtBxFIO = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownMaxWeight = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownLat = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownLong = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBoxWithCar = new System.Windows.Forms.CheckBox();
            this.txtBxNumberCar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBxPhone = new System.Windows.Forms.MaskedTextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLong)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО";
            // 
            // txtBxFIO
            // 
            this.txtBxFIO.Location = new System.Drawing.Point(200, 27);
            this.txtBxFIO.Name = "txtBxFIO";
            this.txtBxFIO.Size = new System.Drawing.Size(307, 26);
            this.txtBxFIO.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Телефон";
            // 
            // numericUpDownMaxWeight
            // 
            this.numericUpDownMaxWeight.Location = new System.Drawing.Point(200, 91);
            this.numericUpDownMaxWeight.Name = "numericUpDownMaxWeight";
            this.numericUpDownMaxWeight.Size = new System.Drawing.Size(307, 26);
            this.numericUpDownMaxWeight.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Максимальный вес";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Расположение";
            // 
            // numericUpDownLat
            // 
            this.numericUpDownLat.DecimalPlaces = 2;
            this.numericUpDownLat.Location = new System.Drawing.Point(198, 150);
            this.numericUpDownLat.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.numericUpDownLat.Name = "numericUpDownLat";
            this.numericUpDownLat.Size = new System.Drawing.Size(89, 26);
            this.numericUpDownLat.TabIndex = 8;
            // 
            // numericUpDownLong
            // 
            this.numericUpDownLong.DecimalPlaces = 2;
            this.numericUpDownLong.Location = new System.Drawing.Point(379, 150);
            this.numericUpDownLong.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.numericUpDownLong.Name = "numericUpDownLong";
            this.numericUpDownLong.Size = new System.Drawing.Size(89, 26);
            this.numericUpDownLong.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(194, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Широта";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(375, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Долгота";
            // 
            // checkBoxWithCar
            // 
            this.checkBoxWithCar.AutoSize = true;
            this.checkBoxWithCar.Location = new System.Drawing.Point(200, 210);
            this.checkBoxWithCar.Name = "checkBoxWithCar";
            this.checkBoxWithCar.Size = new System.Drawing.Size(106, 23);
            this.checkBoxWithCar.TabIndex = 12;
            this.checkBoxWithCar.Text = "С машиной";
            this.checkBoxWithCar.UseVisualStyleBackColor = true;
            this.checkBoxWithCar.CheckedChanged += new System.EventHandler(this.checkBoxWithCar_CheckedChanged);
            // 
            // txtBxNumberCar
            // 
            this.txtBxNumberCar.Enabled = false;
            this.txtBxNumberCar.Location = new System.Drawing.Point(200, 239);
            this.txtBxNumberCar.Name = "txtBxNumberCar";
            this.txtBxNumberCar.Size = new System.Drawing.Size(307, 26);
            this.txtBxNumberCar.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "Номер машины";
            // 
            // txtBxPhone
            // 
            this.txtBxPhone.Location = new System.Drawing.Point(200, 60);
            this.txtBxPhone.Mask = "(999) 000-0000";
            this.txtBxPhone.Name = "txtBxPhone";
            this.txtBxPhone.Size = new System.Drawing.Size(307, 26);
            this.txtBxPhone.TabIndex = 15;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(407, 307);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 34);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(301, 307);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 34);
            this.btnOK.TabIndex = 17;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // NewCourierForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(530, 361);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtBxPhone);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBxNumberCar);
            this.Controls.Add(this.checkBoxWithCar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDownLong);
            this.Controls.Add(this.numericUpDownLat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownMaxWeight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBxFIO);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NewCourierForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewCourierForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBxFIO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxWeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownLat;
        private System.Windows.Forms.NumericUpDown numericUpDownLong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBoxWithCar;
        private System.Windows.Forms.TextBox txtBxNumberCar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtBxPhone;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
    }
}