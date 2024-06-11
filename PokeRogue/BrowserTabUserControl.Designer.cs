
using System;

namespace PokeRogue
{
	partial class BrowserTabUserControl
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			toolStrip2 = new ToolStrip();
			findTextBox = new ToolStripTextBox();
			findPreviousButton = new ToolStripButton();
			findNextButton = new ToolStripButton();
			findCloseButton = new ToolStripButton();
			statusLabel = new Label();
			outputLabel = new Label();
			toolStrip1 = new ToolStrip();
			backButton = new ToolStripButton();
			forwardButton = new ToolStripButton();
			urlTextBox = new ToolStripTextBox();
			goButton = new ToolStripButton();
			browserSplitContainer = new SplitContainer();
			browserPanel = new Panel();
			toolStrip2.SuspendLayout();
			toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)browserSplitContainer).BeginInit();
			browserSplitContainer.Panel1.SuspendLayout();
			browserSplitContainer.SuspendLayout();
			SuspendLayout();
			// 
			// toolStrip2
			// 
			toolStrip2.Dock = DockStyle.Bottom;
			toolStrip2.GripStyle = ToolStripGripStyle.Hidden;
			toolStrip2.Items.AddRange(new ToolStripItem[] { findTextBox, findPreviousButton, findNextButton, findCloseButton });
			toolStrip2.Location = new Point(0, 465);
			toolStrip2.Name = "toolStrip2";
			toolStrip2.Size = new Size(730, 25);
			toolStrip2.TabIndex = 0;
			toolStrip2.Visible = false;
			// 
			// findTextBox
			// 
			findTextBox.Name = "findTextBox";
			findTextBox.Size = new Size(100, 25);
			findTextBox.KeyDown += FindTextBoxKeyDown;
			// 
			// findPreviousButton
			// 
			findPreviousButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
			findPreviousButton.Image = Properties.Resources.nav_left_green;
			findPreviousButton.ImageTransparentColor = Color.Magenta;
			findPreviousButton.Name = "findPreviousButton";
			findPreviousButton.Size = new Size(23, 22);
			findPreviousButton.Text = "Find Previous";
			findPreviousButton.Click += FindPreviousButtonClick;
			// 
			// findNextButton
			// 
			findNextButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
			findNextButton.Image = Properties.Resources.nav_right_green;
			findNextButton.ImageTransparentColor = Color.Magenta;
			findNextButton.Name = "findNextButton";
			findNextButton.Size = new Size(23, 22);
			findNextButton.Text = "Find Next";
			findNextButton.Click += FindNextButtonClick;
			// 
			// findCloseButton
			// 
			findCloseButton.Alignment = ToolStripItemAlignment.Right;
			findCloseButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
			findCloseButton.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
			findCloseButton.ImageTransparentColor = Color.Magenta;
			findCloseButton.Name = "findCloseButton";
			findCloseButton.Size = new Size(23, 22);
			findCloseButton.Text = "X";
			findCloseButton.Click += FindCloseButtonClick;
			// 
			// statusLabel
			// 
			statusLabel.AutoSize = true;
			statusLabel.Dock = DockStyle.Bottom;
			statusLabel.Location = new Point(0, 460);
			statusLabel.Name = "statusLabel";
			statusLabel.Size = new Size(0, 15);
			statusLabel.TabIndex = 1;
			// 
			// outputLabel
			// 
			outputLabel.AutoSize = true;
			outputLabel.Dock = DockStyle.Bottom;
			outputLabel.Location = new Point(0, 475);
			outputLabel.Name = "outputLabel";
			outputLabel.Size = new Size(0, 15);
			outputLabel.TabIndex = 0;
			// 
			// toolStrip1
			// 
			toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
			toolStrip1.Items.AddRange(new ToolStripItem[] { backButton, forwardButton, urlTextBox, goButton });
			toolStrip1.Location = new Point(0, 0);
			toolStrip1.Name = "toolStrip1";
			toolStrip1.Padding = new Padding(0);
			toolStrip1.Size = new Size(730, 25);
			toolStrip1.Stretch = true;
			toolStrip1.TabIndex = 0;
			toolStrip1.Layout += HandleToolStripLayout;
			// 
			// backButton
			// 
			backButton.Enabled = false;
			backButton.Image = Properties.Resources.nav_left_green;
			backButton.ImageTransparentColor = Color.Magenta;
			backButton.Name = "backButton";
			backButton.Size = new Size(52, 22);
			backButton.Text = "Back";
			backButton.Click += BackButtonClick;
			// 
			// forwardButton
			// 
			forwardButton.Enabled = false;
			forwardButton.Image = Properties.Resources.nav_right_green;
			forwardButton.ImageTransparentColor = Color.Magenta;
			forwardButton.Name = "forwardButton";
			forwardButton.Size = new Size(70, 22);
			forwardButton.Text = "Forward";
			forwardButton.Click += ForwardButtonClick;
			// 
			// urlTextBox
			// 
			urlTextBox.AutoSize = false;
			urlTextBox.Name = "urlTextBox";
			urlTextBox.ReadOnly = true;
			urlTextBox.Size = new Size(500, 25);
			urlTextBox.KeyUp += UrlTextBoxKeyUp;
			// 
			// goButton
			// 
			goButton.Image = Properties.Resources.nav_plain_green;
			goButton.ImageTransparentColor = Color.Magenta;
			goButton.Name = "goButton";
			goButton.Size = new Size(42, 22);
			goButton.Text = "Go";
			goButton.Click += GoButtonClick;
			// 
			// browserSplitContainer
			// 
			browserSplitContainer.Dock = DockStyle.Fill;
			browserSplitContainer.Location = new Point(0, 25);
			browserSplitContainer.Name = "browserSplitContainer";
			// 
			// browserSplitContainer.Panel1
			// 
			browserSplitContainer.Panel1.Controls.Add(browserPanel);
			browserSplitContainer.Panel2Collapsed = true;
			browserSplitContainer.Size = new Size(730, 435);
			browserSplitContainer.SplitterDistance = 481;
			browserSplitContainer.TabIndex = 2;
			// 
			// browserPanel
			// 
			browserPanel.Dock = DockStyle.Fill;
			browserPanel.Location = new Point(0, 0);
			browserPanel.Name = "browserPanel";
			browserPanel.Size = new Size(730, 435);
			browserPanel.TabIndex = 3;
			// 
			// BrowserTabUserControl
			// 
			Controls.Add(browserSplitContainer);
			Controls.Add(toolStrip1);
			Controls.Add(statusLabel);
			Controls.Add(outputLabel);
			Controls.Add(toolStrip2);
			Name = "BrowserTabUserControl";
			Size = new Size(730, 490);
			toolStrip2.ResumeLayout(false);
			toolStrip2.PerformLayout();
			toolStrip1.ResumeLayout(false);
			toolStrip1.PerformLayout();
			browserSplitContainer.Panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)browserSplitContainer).EndInit();
			browserSplitContainer.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton backButton;
		private System.Windows.Forms.ToolStripButton forwardButton;
		private System.Windows.Forms.ToolStripTextBox urlTextBox;
		private System.Windows.Forms.ToolStripButton goButton;
		private System.Windows.Forms.Label outputLabel;

		private System.Windows.Forms.ToolStrip toolStrip2;
		private System.Windows.Forms.ToolStripButton findPreviousButton;
		private System.Windows.Forms.ToolStripTextBox findTextBox;
		private System.Windows.Forms.ToolStripButton findNextButton;
		private System.Windows.Forms.ToolStripButton findCloseButton;
		private System.Windows.Forms.Label statusLabel;
		private System.Windows.Forms.SplitContainer browserSplitContainer;
		private System.Windows.Forms.Panel browserPanel;
	}
}
