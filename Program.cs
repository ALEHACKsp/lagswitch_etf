using System;
using System.Windows.Forms;

namespace PPSUCSwitch
{
	// Token: 0x02000008 RID: 8
	internal static class Program
	{
		// Token: 0x06000018 RID: 24
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1
				());
		}
	}
}
