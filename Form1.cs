using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace PPSUCSwitch
{
	// Token: 0x02000003 RID: 3
	public partial class Form1 : Form
	{
		// Token: 0x06000001 RID: 1
		[DllImport("User32.dll")]
		private static extern bool GetAsyncKeyState(ushort vKey);

		// Token: 0x06000002 RID: 2 RVA: 0x000021A8 File Offset: 0x000003A8
		private static bool IsNotInMenu()
		{
			IntPtr handle = Cursors.WaitCursor.Handle;
			Form1.CURSORINFO cursorinfo;
			cursorinfo.cbSize = Marshal.SizeOf(typeof(Form1.CURSORINFO));
			Form1.GetCursorInfo(out cursorinfo);
			return cursorinfo.flags != 0;
		}

		// Token: 0x06000003 RID: 3
		[DllImport("user32.dll")]
		private static extern bool GetCursorInfo(out Form1.CURSORINFO pci);

		// Token: 0x06000004 RID: 4 RVA: 0x000021EC File Offset: 0x000003EC
		public Form1()
		{
			this.InitializeComponent();
			this.comboBox1.DataSource = Enum.GetValues(typeof(VirtualKeys));
		}

		// Token: 0x06000005 RID: 5 RVA: 0x0000223C File Offset: 0x0000043C
		private void button1_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
				bool flag = openFileDialog.ShowDialog() == DialogResult.OK;
				if (flag)
				{
					this.gamepath = (this.textBox1.Text = openFileDialog.FileName);
				}
			}
		}

		// Token: 0x06000006 RID: 6 RVA: 0x0000229C File Offset: 0x0000049C
		private void button2_Click(object sender, EventArgs e)
		{
			this.hotkey = (ushort)Enum.Parse(typeof(VirtualKeys), this.comboBox1.SelectedItem.ToString());
			this.duration = Convert.ToInt32(this.comboBox2.SelectedItem);
			bool flag = this.gamepath.Length == 0;
			if (flag)
			{
				MessageBox.Show("No game executable path was set", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			this.active = !this.active;
			bool flag2 = this.active;
			if (flag2)
			{
				this.button2.Text = "stop";
				this.timer1.Start();
			}
			else
			{
				this.button2.Text = "start";
				this.timer1.Stop();
			}
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002368 File Offset: 0x00000568
		public void StartLag()
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo("cmd.exe", "/c netsh advfirewall firewall add rule name=\"UCLagSwitch\" dir=in action=block program=\"" + this.gamepath + "\" enable=yes");
			ProcessStartInfo processStartInfo2 = new ProcessStartInfo("cmd.exe", "/c netsh advfirewall firewall add rule name=\"UCLagSwitch\" dir=out action=block program=\"" + this.gamepath + "\" enable=yes");
			ProcessStartInfo processStartInfo3 = new ProcessStartInfo("cmd.exe", "/c netsh advfirewall firewall delete rule name=\"UCLagSwitch\" program=\"" + this.gamepath + "\"");
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo2.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo3.WindowStyle = ProcessWindowStyle.Hidden;
			Process.Start(processStartInfo);
			Process.Start(processStartInfo2);
			Console.Beep();
			DateTime now = DateTime.Now;
			while (this.IsLagging)
			{
				this.LastLagTime = DateTime.Now;
				bool flag = DateTime.Now.Subtract(now).Seconds >= this.duration / 1000;
				if (flag)
				{
					this.IsLagging = false;
				}
				Thread.Sleep(1);
			}
			Console.Beep();
			this.IsLagging = false;
			Process.Start(processStartInfo3);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002478 File Offset: 0x00000678
		private void timer1_Tick(object sender, EventArgs e)
		{
			bool flag = Form1.GetAsyncKeyState(this.hotkey) && !Form1.IsNotInMenu();
			if (flag)
			{
				bool flag2 = !this.Hotkey_Down;
				if (flag2)
				{
					this.Hotkey_Down = true;
					bool isLagging = this.IsLagging;
					if (isLagging)
					{
						this.IsLagging = false;
					}
					else
					{
						bool flag3 = DateTime.Now > this.LastLagTime.AddSeconds(3.0);
						if (flag3)
						{
							this.IsLagging = true;
							this.thr1 = new Thread(new ThreadStart(this.StartLag));
							this.thr1.Start();
						}
					}
				}
			}
			else
			{
				this.Hotkey_Down = false;
			}
		}

		private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		private void label2_Click(object sender, EventArgs e)
		{
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			this.comboBox1.SelectedIndex = 133;
			this.comboBox2.SelectedIndex = 2;
		}

		// Token: 0x040000C6 RID: 198
		private bool active;

		// Token: 0x040000C7 RID: 199
		private string gamepath = "C:\\Battlestate Games\\EFT (live)\\EscapeFromTarkov.exe";

		// Token: 0x040000C8 RID: 200
		private ushort hotkey;

		// Token: 0x040000C9 RID: 201
		private int duration;

		// Token: 0x040000CA RID: 202
		private bool Hotkey_Down;

		// Token: 0x040000CB RID: 203
		private bool IsLagging;

		// Token: 0x040000CC RID: 204
		private DateTime LastLagTime = DateTime.Now;

		// Token: 0x040000CD RID: 205
		private Thread thr1;

		// Token: 0x02000004 RID: 4
		private struct POINT
		{
			// Token: 0x040000D8 RID: 216
			public int x;

			// Token: 0x040000D9 RID: 217
			public int y;
		}

		// Token: 0x02000005 RID: 5
		private struct CURSORINFO
		{
			// Token: 0x040000DA RID: 218
			public int cbSize;

			// Token: 0x040000DB RID: 219
			public int flags;

			// Token: 0x040000DC RID: 220
			public IntPtr hCursor;

			// Token: 0x040000DD RID: 221
			public Form1.POINT ptScreenPos;
		}
	}
}
