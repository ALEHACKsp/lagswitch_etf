namespace PPSUCSwitch
{
	// Token: 0x02000003 RID: 3
	public partial class Form1 : global::System.Windows.Forms.Form
	{
		// Token: 0x0600000C RID: 12 RVA: 0x00002528 File Offset: 0x00000728
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002560 File Offset: 0x00000760
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(330, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "C:\\Battlestate Games\\EFT (live)\\EscapeFromTarkov.exe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Game executable path";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(348, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 20);
            this.button1.TabIndex = 3;
            this.button1.Text = "browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 64);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(393, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hotkey";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "1000",
            "2000",
            "3000",
            "4000",
            "5000",
            "6000",
            "7000",
            "8000",
            "9000",
            "10000",
            "11000",
            "12000",
            "13000",
            "14000",
            "15000"});
            this.comboBox2.Location = new System.Drawing.Point(12, 104);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(393, 21);
            this.comboBox2.TabIndex = 6;
            this.comboBox2.Tag = "";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Lag duration (in milliseconds)";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 131);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(393, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "start";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 167);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "LhaasperLagswitch";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		// Token: 0x040000CE RID: 206
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040000CF RID: 207
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x040000D0 RID: 208
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040000D1 RID: 209
		private global::System.Windows.Forms.Button button1;

		// Token: 0x040000D2 RID: 210
		private global::System.Windows.Forms.ComboBox comboBox1;

		// Token: 0x040000D3 RID: 211
		private global::System.Windows.Forms.Label label3;

		// Token: 0x040000D4 RID: 212
		private global::System.Windows.Forms.ComboBox comboBox2;

		// Token: 0x040000D5 RID: 213
		private global::System.Windows.Forms.Label label4;

		// Token: 0x040000D6 RID: 214
		private global::System.Windows.Forms.Button button2;

		// Token: 0x040000D7 RID: 215
		private global::System.Windows.Forms.Timer timer1;
	}
}
