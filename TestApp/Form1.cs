using SharpFont;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TestApp
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnFont_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog ofd = new OpenFileDialog
			{
				Title = "Please select a .ttf or .otf to open...",
				Filter = "TrueType|*.ttf|OpenType|*.otf|TrueType/OpenType|*.ttf; *.otf;",
				FilterIndex = 4,
			})
			{
				if (ofd.ShowDialog() == DialogResult.OK)
				{
					string file = ofd.FileName;
					txtFont.Text = file;
					Font customFont = FontLoader.LoadFont(file, lblFont.Font.Size);
					lblFont.Font = customFont;
				}
			}
		}
	}
}
