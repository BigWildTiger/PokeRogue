namespace PokeRogue
{
	partial class Browser
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
			browserTabControl = new TabControl();
			menuStrip2 = new MenuStrip();
			mainToolStripMenuItem = new ToolStripMenuItem();
			alwaysTopToolStripMenuItem = new ToolStripMenuItem();
			exitToolStripMenuItem = new ToolStripMenuItem();
			tabToolStripMenuItem = new ToolStripMenuItem();
			addNewTabToolStripMenuItem = new ToolStripMenuItem();
			closeTabToolStripMenuItem = new ToolStripMenuItem();
			menuStrip2.SuspendLayout();
			SuspendLayout();
			// 
			// browserTabControl
			// 
			browserTabControl.Location = new Point(12, 116);
			browserTabControl.Name = "browserTabControl";
			browserTabControl.SelectedIndex = 0;
			browserTabControl.Size = new Size(200, 100);
			browserTabControl.TabIndex = 3;
			// 
			// menuStrip2
			// 
			menuStrip2.Items.AddRange(new ToolStripItem[] { mainToolStripMenuItem, tabToolStripMenuItem });
			menuStrip2.Location = new Point(0, 0);
			menuStrip2.Name = "menuStrip2";
			menuStrip2.Size = new Size(819, 24);
			menuStrip2.TabIndex = 5;
			menuStrip2.Text = "menuStrip2";
			// 
			// mainToolStripMenuItem
			// 
			mainToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { alwaysTopToolStripMenuItem, exitToolStripMenuItem });
			mainToolStripMenuItem.Name = "mainToolStripMenuItem";
			mainToolStripMenuItem.Size = new Size(46, 20);
			mainToolStripMenuItem.Text = "Main";
			// 
			// alwaysTopToolStripMenuItem
			// 
			alwaysTopToolStripMenuItem.Name = "alwaysTopToolStripMenuItem";
			alwaysTopToolStripMenuItem.Size = new Size(131, 22);
			alwaysTopToolStripMenuItem.Text = "AlwaysTop";
			alwaysTopToolStripMenuItem.Click += alwaysTopToolStripMenuItem_Click;
			// 
			// exitToolStripMenuItem
			// 
			exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			exitToolStripMenuItem.Size = new Size(131, 22);
			exitToolStripMenuItem.Text = "Exit";
			exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
			// 
			// tabToolStripMenuItem
			// 
			tabToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addNewTabToolStripMenuItem, closeTabToolStripMenuItem });
			tabToolStripMenuItem.Name = "tabToolStripMenuItem";
			tabToolStripMenuItem.Size = new Size(38, 20);
			tabToolStripMenuItem.Text = "Tab";
			// 
			// addNewTabToolStripMenuItem
			// 
			addNewTabToolStripMenuItem.Name = "addNewTabToolStripMenuItem";
			addNewTabToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.T;
			addNewTabToolStripMenuItem.Size = new Size(187, 22);
			addNewTabToolStripMenuItem.Text = "Add New Tab";
			addNewTabToolStripMenuItem.Click += addNewTabToolStripMenuItem_Click;
			// 
			// closeTabToolStripMenuItem
			// 
			closeTabToolStripMenuItem.Name = "closeTabToolStripMenuItem";
			closeTabToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.F4;
			closeTabToolStripMenuItem.Size = new Size(187, 22);
			closeTabToolStripMenuItem.Text = "Close Tab ";
			closeTabToolStripMenuItem.Click += closeTabToolStripMenuItem_Click;
			// 
			// Browser
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(819, 562);
			Controls.Add(browserTabControl);
			Controls.Add(menuStrip2);
			Name = "Browser";
			Text = "PokeRogue";
			menuStrip2.ResumeLayout(false);
			menuStrip2.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private TabControl browserTabControl;
		private MenuStrip menuStrip1;
		private MenuStrip menuStrip2;
		private ToolStripMenuItem mainToolStripMenuItem;
		private ToolStripMenuItem tabToolStripMenuItem;
		private ToolStripMenuItem addNewTabToolStripMenuItem;
		private ToolStripMenuItem closeTabToolStripMenuItem;
		private ToolStripMenuItem exitToolStripMenuItem;
		private ToolStripMenuItem alwaysTopToolStripMenuItem;
	}
}
