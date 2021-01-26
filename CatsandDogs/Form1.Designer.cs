namespace CatsandDogs
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
            this.dogPicture = new System.Windows.Forms.PictureBox();
            this.GetADog = new System.Windows.Forms.Button();
            this.CatPicture = new System.Windows.Forms.PictureBox();
            this.GetACat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dogPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CatPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // dogPicture
            // 
            this.dogPicture.Location = new System.Drawing.Point(632, 50);
            this.dogPicture.Name = "dogPicture";
            this.dogPicture.Size = new System.Drawing.Size(265, 304);
            this.dogPicture.TabIndex = 0;
            this.dogPicture.TabStop = false;
            this.dogPicture.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // GetADog
            // 
            this.GetADog.Location = new System.Drawing.Point(632, 417);
            this.GetADog.Name = "GetADog";
            this.GetADog.Size = new System.Drawing.Size(265, 125);
            this.GetADog.TabIndex = 1;
            this.GetADog.Text = "Get dog image";
            this.GetADog.UseVisualStyleBackColor = true;
            this.GetADog.Click += new System.EventHandler(this.button1_Click);
            // 
            // CatPicture
            // 
            this.CatPicture.Location = new System.Drawing.Point(80, 50);
            this.CatPicture.Name = "CatPicture";
            this.CatPicture.Size = new System.Drawing.Size(269, 313);
            this.CatPicture.TabIndex = 2;
            this.CatPicture.TabStop = false;
            // 
            // GetACat
            // 
            this.GetACat.Location = new System.Drawing.Point(89, 417);
            this.GetACat.Name = "GetACat";
            this.GetACat.Size = new System.Drawing.Size(237, 125);
            this.GetACat.TabIndex = 3;
            this.GetACat.Text = "Get cat image";
            this.GetACat.UseVisualStyleBackColor = true;
            this.GetACat.Click += new System.EventHandler(this.GetACat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 686);
            this.Controls.Add(this.GetACat);
            this.Controls.Add(this.CatPicture);
            this.Controls.Add(this.GetADog);
            this.Controls.Add(this.dogPicture);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dogPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CatPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox dogPicture;
        private System.Windows.Forms.Button GetADog;
        private System.Windows.Forms.PictureBox CatPicture;
        private System.Windows.Forms.Button GetACat;
    }
}

