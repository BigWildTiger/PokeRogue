using Microsoft.Web.WebView2.WinForms;
using Microsoft.Web.WebView2.Core;

namespace PokeRogue
{
	public partial class Browser : Form
	{

		public Browser()
		{
			this.Icon = Properties.Resources.PR_Icon;
			InitializeComponent();
			AddNewTab();
		}

		private void AddNewTab()
		{
			var webView = new WebView2()
			{
				Source = new Uri(@"https://pokerogue.net/"),
				Dock = DockStyle.Fill
			};

			var BTUserControl = new BrowserTabUserControl(webView);
			BTUserControl.Dock = DockStyle.Fill;
			var TP = new TabPage();
			TP.Controls.Add(BTUserControl);
			browserTabControl.TabPages.Add(TP);
			browserTabControl.Dock = DockStyle.Fill;
			browserTabControl.SelectTab(browserTabControl.TabPages.Count - 1);
		}

		private void addNewTabToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AddNewTab();
		}

		private void closeTabToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DeleteCurrentTab();
		}

		private void DeleteCurrentTab()
		{
			if (browserTabControl.TabPages.Count > 1)
			{
				var selPage = browserTabControl.SelectedTab;
				var selPageIndex = browserTabControl.SelectedIndex;
				if (selPageIndex == 0)
				{
					//없애려는 탭이 첫번째일경우
					DeleteTab(selPage);
				}
				else if (selPageIndex != 0 && selPageIndex <= browserTabControl.TabPages.Count - 1)
				{
					//없애려는 탭이 마지막 혹인 중간인경우
					DeleteTab(selPage);
					browserTabControl.SelectTab(selPageIndex - 1);
				}
			}
		}

		private static void DeleteTab(TabPage? selPage)
		{
			if (selPage != null) { selPage.Dispose(); }
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void alwaysTopToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.alwaysTopToolStripMenuItem.Checked = !this.alwaysTopToolStripMenuItem.Checked;
			this.TopMost = this.alwaysTopToolStripMenuItem.Checked;
		}
	}
}
