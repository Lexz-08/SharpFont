
namespace TestApp
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblFont = new System.Windows.Forms.Label();
			this.txtFont = new System.Windows.Forms.TextBox();
			this.btnFont = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblFont
			// 
			this.lblFont.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblFont.BackColor = System.Drawing.SystemColors.ControlLight;
			this.lblFont.Font = new System.Drawing.Font("Segoe UI", 24F);
			this.lblFont.Location = new System.Drawing.Point(12, 9);
			this.lblFont.Name = "lblFont";
			this.lblFont.Size = new System.Drawing.Size(368, 81);
			this.lblFont.TabIndex = 0;
			this.lblFont.Text = "Aa Bb";
			this.lblFont.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtFont
			// 
			this.txtFont.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtFont.Location = new System.Drawing.Point(20, 98);
			this.txtFont.Name = "txtFont";
			this.txtFont.ReadOnly = true;
			this.txtFont.Size = new System.Drawing.Size(303, 20);
			this.txtFont.TabIndex = 1;
			this.txtFont.Text = "<default: Segoe UI>";
			// 
			// btnFont
			// 
			this.btnFont.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnFont.Location = new System.Drawing.Point(329, 97);
			this.btnFont.Name = "btnFont";
			this.btnFont.Size = new System.Drawing.Size(40, 22);
			this.btnFont.TabIndex = 2;
			this.btnFont.Text = "...";
			this.btnFont.UseVisualStyleBackColor = true;
			this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(392, 131);
			this.Controls.Add(this.btnFont);
			this.Controls.Add(this.txtFont);
			this.Controls.Add(this.lblFont);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(645, 170);
			this.MinimumSize = new System.Drawing.Size(408, 170);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "TestApp";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblFont;
		private System.Windows.Forms.TextBox txtFont;
		private System.Windows.Forms.Button btnFont;
	}
}

