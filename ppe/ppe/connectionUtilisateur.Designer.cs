namespace ppe
{
	partial class pageConnection
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
			this.btnConnection = new System.Windows.Forms.Button();
			this.lbLogin = new System.Windows.Forms.Label();
			this.lbPassWord = new System.Windows.Forms.Label();
			this.tbLogin = new System.Windows.Forms.TextBox();
			this.tbPassWord = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnConnection
			// 
			this.btnConnection.Location = new System.Drawing.Point(148, 175);
			this.btnConnection.Name = "btnConnection";
			this.btnConnection.Size = new System.Drawing.Size(75, 23);
			this.btnConnection.TabIndex = 0;
			this.btnConnection.Text = "Connection";
			this.btnConnection.UseVisualStyleBackColor = true;
			// 
			// lbLogin
			// 
			this.lbLogin.AutoSize = true;
			this.lbLogin.Location = new System.Drawing.Point(60, 56);
			this.lbLogin.Name = "lbLogin";
			this.lbLogin.Size = new System.Drawing.Size(29, 13);
			this.lbLogin.TabIndex = 1;
			this.lbLogin.Text = "login";
			// 
			// lbPassWord
			// 
			this.lbPassWord.AutoSize = true;
			this.lbPassWord.Location = new System.Drawing.Point(60, 105);
			this.lbPassWord.Name = "lbPassWord";
			this.lbPassWord.Size = new System.Drawing.Size(52, 13);
			this.lbPassWord.TabIndex = 2;
			this.lbPassWord.Text = "password";
			// 
			// tbLogin
			// 
			this.tbLogin.Location = new System.Drawing.Point(148, 56);
			this.tbLogin.Name = "tbLogin";
			this.tbLogin.Size = new System.Drawing.Size(100, 20);
			this.tbLogin.TabIndex = 3;
			// 
			// tbPassWord
			// 
			this.tbPassWord.Location = new System.Drawing.Point(148, 105);
			this.tbPassWord.Name = "tbPassWord";
			this.tbPassWord.Size = new System.Drawing.Size(100, 20);
			this.tbPassWord.TabIndex = 4;
			// 
			// pageConnection
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(376, 226);
			this.Controls.Add(this.tbPassWord);
			this.Controls.Add(this.tbLogin);
			this.Controls.Add(this.lbPassWord);
			this.Controls.Add(this.lbLogin);
			this.Controls.Add(this.btnConnection);
			this.Name = "pageConnection";
			this.Text = "connection";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnConnection;
		private System.Windows.Forms.Label lbLogin;
		private System.Windows.Forms.Label lbPassWord;
		private System.Windows.Forms.TextBox tbLogin;
		private System.Windows.Forms.TextBox tbPassWord;
	}
}