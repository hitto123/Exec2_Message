namespace Exec2_Message
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.button = new System.Windows.Forms.Button();
			this.Showlabel1 = new System.Windows.Forms.Label();
			this.ShowtextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// button
			// 
			this.button.Location = new System.Drawing.Point(244, 26);
			this.button.Name = "button";
			this.button.Size = new System.Drawing.Size(180, 104);
			this.button.TabIndex = 0;
			this.button.Text = "顯示時間";
			this.button.UseVisualStyleBackColor = true;
			this.button.Click += new System.EventHandler(this.button_Click);
			// 
			// Showlabel1
			// 
			this.Showlabel1.Location = new System.Drawing.Point(10, 51);
			this.Showlabel1.Name = "Showlabel1";
			this.Showlabel1.Size = new System.Drawing.Size(194, 79);
			this.Showlabel1.TabIndex = 1;
			this.Showlabel1.Text = "label1";
			// 
			// ShowtextBox
			// 
			this.ShowtextBox.Location = new System.Drawing.Point(12, 26);
			this.ShowtextBox.Name = "ShowtextBox";
			this.ShowtextBox.Size = new System.Drawing.Size(192, 22);
			this.ShowtextBox.TabIndex = 2;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(461, 220);
			this.Controls.Add(this.ShowtextBox);
			this.Controls.Add(this.Showlabel1);
			this.Controls.Add(this.button);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button;
		private System.Windows.Forms.Label Showlabel1;
		private System.Windows.Forms.TextBox ShowtextBox;
	}
}

