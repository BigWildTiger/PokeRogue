using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;

namespace PokeRogue
{
	public partial class BrowserTabUserControl : UserControl
	{
		public WebView2 Browser { get; private set; }

		public BrowserTabUserControl(WebView2 edgeHostControl)
		{
			InitializeComponent();
			//edgeHostControl.Dock = DockStyle.Fill;
			Browser = edgeHostControl;
			urlTextBox.Text = edgeHostControl.Source.ToString();
			browserPanel.Controls.Add(edgeHostControl);
			edgeHostControl.NavigationStarting += Browser_NavigationStarting;
			edgeHostControl.NavigationCompleted += EdgeHostControl_NavigationCompleted;
			InitializeAsync(Browser);
			//chromiumHostControl.LoadingStateChanged += OnBrowserLoadingStateChanged;
			//chromiumHostControl.ConsoleMessage += OnBrowserConsoleMessage;
			//chromiumHostControl.TitleChanged += OnBrowserTitleChanged;
			//chromiumHostControl.AddressChanged += OnBrowserAddressChanged;
			//chromiumHostControl.StatusMessage += OnBrowserStatusMessage;
			//chromiumHostControl.IsBrowserInitializedChanged += OnIsBrowserInitializedChanged;
			//chromiumHostControl.LoadError += OnLoadError;
		}

		private void Browser_NavigationStarting(object? sender, CoreWebView2NavigationStartingEventArgs e)
		{
			String uri = e.Uri;
			if (!uri.StartsWith("https://"))
			{
				e.Cancel = true;
			}
		}

		private void EdgeHostControl_NavigationCompleted(object? sender, CoreWebView2NavigationCompletedEventArgs e)
		{
			backButton.Enabled = Browser.CanGoBack;
			forwardButton.Enabled = Browser.CanGoForward;
			var d = sender as WebView2;
			if (d != null)
			{
				//Panel fdf = d.Parent as Panel;
				//SplitContainer da = d.Parent.Parent.Parent as SplitContainer;
				//BrowserTabUserControl adf = d.Parent.Parent.Parent.Parent as BrowserTabUserControl;
				TabPage asfdd = d.Parent.Parent.Parent.Parent.Parent as TabPage;
				if (asfdd != null)
				{
					asfdd.Text = d.CoreWebView2.DocumentTitle;
				}
			}
		}

		async void InitializeAsync(WebView2 webView)
		{
			await webView.EnsureCoreWebView2Async(null);
			webView.CoreWebView2.WebMessageReceived += UpdateAddressBar;

			await webView.CoreWebView2.AddScriptToExecuteOnDocumentCreatedAsync("window.chrome.webview.postMessage(window.document.URL);");
			await webView.CoreWebView2.AddScriptToExecuteOnDocumentCreatedAsync("window.chrome.webview.addEventListener(\'message\', event => alert(event.data));");
		}

		private void UpdateAddressBar(object? sender, CoreWebView2WebMessageReceivedEventArgs args)
		{
			String uri = args.TryGetWebMessageAsString();
			urlTextBox.Text = uri;
			//Browser.CoreWebView2.PostWebMessageAsString(uri);
		}


		private void GoButtonClick(object sender, EventArgs e)
		{
			LoadUrl(urlTextBox.Text);
		}

		private void LoadUrl(string url)
		{

			if (IsValidUrl(url))
			{
				if (Browser != null && Browser.CoreWebView2 != null)
				{
					Browser.CoreWebView2.Navigate(url);
				}
				//Browser.Source = new Uri(url);
			}
			else
			{
				var searchUrl = "https://www.google.com/search?q=" + Uri.EscapeDataString(url);
				//Browser.Source = new Uri(searchUrl);
				if (Browser != null && Browser.CoreWebView2 != null)
				{
					Browser.CoreWebView2.Navigate(searchUrl);
				}
			}
		}

		public static bool IsValidUrl(string url)
		{
			Uri uriResult;
			return Uri.TryCreate(url, UriKind.Absolute, out uriResult) &&
					(uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
		}

		private void UrlTextBoxKeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Enter)
			{
				return;
			}

			LoadUrl(urlTextBox.Text);
		}

		private void BackButtonClick(object sender, EventArgs e)
		{
			if (Browser.CanGoBack) { Browser.GoBack(); }
		}

		private void ForwardButtonClick(object sender, EventArgs e)
		{
			if (Browser.CanGoForward) { Browser.GoForward(); }
		}

		private void HandleToolStripLayout(object sender, LayoutEventArgs e)
		{
			HandleToolStripLayout();
		}

		private void HandleToolStripLayout()
		{
			var width = toolStrip1.Width;
			foreach (ToolStripItem item in toolStrip1.Items)
			{
				if (item != urlTextBox)
				{
					width -= item.Width - item.Margin.Horizontal;
				}
			}
			urlTextBox.Width = Math.Max(100, width - urlTextBox.Margin.Horizontal - goButton.Width);
		}

		private void FindCloseButtonClick(object sender, EventArgs e)
		{
			ToggleBottomToolStrip();
		}
		private void ToggleBottomToolStrip()
		{
			if (toolStrip2.Visible)
			{
				Browser.Stop();
				//Browser.StopFinding(true);
				toolStrip2.Visible = false;
			}
			else
			{
				toolStrip2.Visible = true;
				findTextBox.Focus();
			}
		}

		private void FindNextButtonClick(object sender, EventArgs e)
		{
			Find(true);
		}

		private void FindPreviousButtonClick(object sender, EventArgs e)
		{
			Find(false);
		}

		private void Find(bool next)
		{
			if (!string.IsNullOrEmpty(findTextBox.Text))
			{
				//Browser.Find(findTextBox.Text, next, false, false);

			}
		}

		private void FindTextBoxKeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Enter)
			{
				return;
			}

			Find(true);
		}
	}
}
