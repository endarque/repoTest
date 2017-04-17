using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web_Browser
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		/// <summary>
		/// 폼 로드시
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Form1_Load(object sender, EventArgs e)
		{
			uriComboBox.SelectedIndex = 0;
			webBrowser.GoHome();
		}

		/// <summary>
		/// 이동 버튼 클릭
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void goButton_Click(object sender, EventArgs e)
		{
			webBrowser.Navigate (new Uri (uriComboBox.SelectedItem.ToString()));
		}

		/// <summary>
		/// 탐색 -> 홈
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void homeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			webBrowser.GoHome();
		}

		/// <summary>
		/// 탐색 -> 앞으로
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void goForwardToolStripMenuItem_Click(object sender, EventArgs e)
		{
			webBrowser.GoForward();
		}

		/// <summary>
		/// 탐색 -> 뒤로
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void goBackToolStripMenuItem_Click(object sender, EventArgs e)
		{
			webBrowser.GoBack();
		}

		/// <summary>
		/// 도움말 -> 정보
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AboutForm f = new AboutForm();
//			f.Show();
			f.ShowDialog();
		}

		private void alertToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show ("alert");
		}

		private void confirmToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show ("계속하시겠습니까?", "확인창", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				MessageBox.Show ("\"예\"를 선택함.");
			}
			else
			{
				MessageBox.Show("\"아니오\"를 선택함.");
			}
		}
	}
}
