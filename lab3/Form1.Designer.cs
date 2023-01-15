namespace lab3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.textBox_yaer = new System.Windows.Forms.TextBox();
            this.textBox_body = new System.Windows.Forms.TextBox();
            this.textBox_grad = new System.Windows.Forms.TextBox();
            this.textBox_major = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.all = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.all)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ชิ่อ-นามสกุล";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "รหัสนักศึกษา";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "ปีเกิด";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(405, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "ส่วนสูง";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(536, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "เกรด";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(667, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "สาขา";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(12, 32);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(125, 27);
            this.textBox_name.TabIndex = 6;
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(143, 32);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(125, 27);
            this.textBox_ID.TabIndex = 7;
            // 
            // textBox_yaer
            // 
            this.textBox_yaer.Location = new System.Drawing.Point(274, 32);
            this.textBox_yaer.Name = "textBox_yaer";
            this.textBox_yaer.Size = new System.Drawing.Size(125, 27);
            this.textBox_yaer.TabIndex = 8;
            // 
            // textBox_body
            // 
            this.textBox_body.Location = new System.Drawing.Point(405, 32);
            this.textBox_body.Name = "textBox_body";
            this.textBox_body.Size = new System.Drawing.Size(125, 27);
            this.textBox_body.TabIndex = 9;
            // 
            // textBox_grad
            // 
            this.textBox_grad.Location = new System.Drawing.Point(536, 32);
            this.textBox_grad.Name = "textBox_grad";
            this.textBox_grad.Size = new System.Drawing.Size(125, 27);
            this.textBox_grad.TabIndex = 10;
            // 
            // textBox_major
            // 
            this.textBox_major.Location = new System.Drawing.Point(667, 32);
            this.textBox_major.Name = "textBox_major";
            this.textBox_major.Size = new System.Drawing.Size(125, 27);
            this.textBox_major.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(358, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 12;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // all
            // 
            this.all.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.all.Location = new System.Drawing.Point(12, 127);
            this.all.Name = "all";
            this.all.RowHeadersWidth = 51;
            this.all.RowTemplate.Height = 29;
            this.all.Size = new System.Drawing.Size(780, 269);
            this.all.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.all);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_major);
            this.Controls.Add(this.textBox_grad);
            this.Controls.Add(this.textBox_body);
            this.Controls.Add(this.textBox_yaer);
            this.Controls.Add(this.textBox_ID);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.all)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox_name;
        private TextBox textBox_ID;
        private TextBox textBox_yaer;
        private TextBox textBox_body;
        private TextBox textBox_grad;
        private TextBox textBox_major;
        private Button button1;
        private DataGridView all;
    }
}