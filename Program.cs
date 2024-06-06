using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AS.Db.Tools
{
	static class Program
	{    /// <summary>
		 /// Author      : Okyanus Soft
		 /// Create date : 2024-06-05
		 /// Description :  EasySQLTool
		 /// Latest
		 /// Modifier    : Okyanus Soft
		 /// Modify date : 2024-06-05
		 /// </summary>
		 /// <summary>
		 /// The main entry point for the application.
		 /// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new EasySQLTool());
		}
	}
}
