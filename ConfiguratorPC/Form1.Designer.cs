namespace ConfiguratorPC
{
	partial class Form1
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
			if(disposing && (components != null))
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.button3 = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.NoRadioBtn = new System.Windows.Forms.RadioButton();
			this.YesRadioBtn = new System.Windows.Forms.RadioButton();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.White;
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.ForeColor = System.Drawing.Color.Black;
			this.textBox1.Location = new System.Drawing.Point(67, 12);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(300, 73);
			this.textBox1.TabIndex = 0;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(233, 137);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(41, 22);
			this.textBox2.TabIndex = 4;
			// 
			// button3
			// 
			this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.button3.Location = new System.Drawing.Point(67, 197);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(300, 27);
			this.button3.TabIndex = 9;
			this.button3.Text = " Продожить";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click_1);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.NoRadioBtn);
			this.groupBox1.Controls.Add(this.YesRadioBtn);
			this.groupBox1.Location = new System.Drawing.Point(121, 91);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 100);
			this.groupBox1.TabIndex = 11;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Варианты ответа";
			// 
			// NoRadioBtn
			// 
			this.NoRadioBtn.AutoSize = true;
			this.NoRadioBtn.Location = new System.Drawing.Point(11, 57);
			this.NoRadioBtn.Name = "NoRadioBtn";
			this.NoRadioBtn.Size = new System.Drawing.Size(53, 20);
			this.NoRadioBtn.TabIndex = 1;
			this.NoRadioBtn.TabStop = true;
			this.NoRadioBtn.Text = "Нет";
			this.NoRadioBtn.UseVisualStyleBackColor = true;
			this.NoRadioBtn.CheckedChanged += new System.EventHandler(this.NoRadioBtn_CheckedChanged);
			// 
			// YesRadioBtn
			// 
			this.YesRadioBtn.AutoSize = true;
			this.YesRadioBtn.Location = new System.Drawing.Point(11, 31);
			this.YesRadioBtn.Name = "YesRadioBtn";
			this.YesRadioBtn.Size = new System.Drawing.Size(45, 20);
			this.YesRadioBtn.TabIndex = 0;
			this.YesRadioBtn.TabStop = true;
			this.YesRadioBtn.Text = "Да";
			this.YesRadioBtn.UseVisualStyleBackColor = true;
			this.YesRadioBtn.CheckedChanged += new System.EventHandler(this.YesRadioBtn_CheckedChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(429, 316);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load_1);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton NoRadioBtn;
		private System.Windows.Forms.RadioButton YesRadioBtn;
	}
}