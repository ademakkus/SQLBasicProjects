namespace WindowsFormsAppDataReader
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
			this.components = new System.ComponentModel.Container();
			this.cmbKategoriID = new System.Windows.Forms.ComboBox();
			this.lsbCategoryName = new System.Windows.Forms.ListBox();
			this.lsbDescription = new System.Windows.Forms.ListBox();
			this.lsbPictures = new System.Windows.Forms.ListBox();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// cmbKategoriID
			// 
			this.cmbKategoriID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.cmbKategoriID.FormattingEnabled = true;
			this.cmbKategoriID.Location = new System.Drawing.Point(1, 80);
			this.cmbKategoriID.Name = "cmbKategoriID";
			this.cmbKategoriID.Size = new System.Drawing.Size(132, 33);
			this.cmbKategoriID.TabIndex = 0;
			// 
			// lsbCategoryName
			// 
			this.lsbCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lsbCategoryName.FormattingEnabled = true;
			this.lsbCategoryName.ItemHeight = 25;
			this.lsbCategoryName.Location = new System.Drawing.Point(150, 80);
			this.lsbCategoryName.Name = "lsbCategoryName";
			this.lsbCategoryName.Size = new System.Drawing.Size(246, 79);
			this.lsbCategoryName.TabIndex = 1;
			// 
			// lsbDescription
			// 
			this.lsbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lsbDescription.FormattingEnabled = true;
			this.lsbDescription.ItemHeight = 25;
			this.lsbDescription.Location = new System.Drawing.Point(432, 80);
			this.lsbDescription.Name = "lsbDescription";
			this.lsbDescription.Size = new System.Drawing.Size(294, 79);
			this.lsbDescription.TabIndex = 2;
			// 
			// lsbPictures
			// 
			this.lsbPictures.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lsbPictures.FormattingEnabled = true;
			this.lsbPictures.ItemHeight = 25;
			this.lsbPictures.Location = new System.Drawing.Point(744, 80);
			this.lsbPictures.Name = "lsbPictures";
			this.lsbPictures.Size = new System.Drawing.Size(217, 79);
			this.lsbPictures.TabIndex = 3;
			// 
			// imageList1
			// 
			this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(80, 230);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(213, 153);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1099, 450);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.lsbPictures);
			this.Controls.Add(this.lsbDescription);
			this.Controls.Add(this.lsbCategoryName);
			this.Controls.Add(this.cmbKategoriID);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ComboBox cmbKategoriID;
		private System.Windows.Forms.ListBox lsbCategoryName;
		private System.Windows.Forms.ListBox lsbDescription;
		private System.Windows.Forms.ListBox lsbPictures;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}

