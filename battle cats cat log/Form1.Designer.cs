namespace PasswordEncryptionApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.buttonSaveFile = new System.Windows.Forms.Button();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.DarkOrange;
            this.textBoxPassword.Cursor = System.Windows.Forms.Cursors.NoMoveVert;
            this.textBoxPassword.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(262, 182);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(312, 32);
            this.textBoxPassword.TabIndex = 0;
            this.textBoxPassword.Text = "Password";
            // 
            // textBoxKey
            // 
            this.textBoxKey.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBoxKey.Cursor = System.Windows.Forms.Cursors.NoMoveVert;
            this.textBoxKey.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKey.Location = new System.Drawing.Point(262, 269);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(312, 32);
            this.textBoxKey.TabIndex = 2;
            this.textBoxKey.Text = "Key";
            // 
            // buttonSaveFile
            // 
            this.buttonSaveFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonSaveFile.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.buttonSaveFile.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveFile.Location = new System.Drawing.Point(344, 344);
            this.buttonSaveFile.Name = "buttonSaveFile";
            this.buttonSaveFile.Size = new System.Drawing.Size(139, 57);
            this.buttonSaveFile.TabIndex = 9;
            this.buttonSaveFile.Text = "Save";
            this.buttonSaveFile.UseVisualStyleBackColor = false;
            this.buttonSaveFile.Click += new System.EventHandler(this.buttonSaveFile_Click);
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.BackColor = System.Drawing.Color.MediumVioletRed;
            this.buttonEncrypt.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.buttonEncrypt.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEncrypt.Location = new System.Drawing.Point(575, 344);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(139, 57);
            this.buttonEncrypt.TabIndex = 8;
            this.buttonEncrypt.Text = "Encrypt";
            this.buttonEncrypt.UseVisualStyleBackColor = false;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.BackColor = System.Drawing.Color.MediumVioletRed;
            this.buttonDecrypt.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.buttonDecrypt.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDecrypt.Location = new System.Drawing.Point(121, 344);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(139, 57);
            this.buttonDecrypt.TabIndex = 7;
            this.buttonDecrypt.Text = "Decrypt";
            this.buttonDecrypt.UseVisualStyleBackColor = false;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSaveFile);
            this.Controls.Add(this.buttonEncrypt);
            this.Controls.Add(this.buttonDecrypt);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxKey);
            this.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Encript/decryptor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.Button buttonSaveFile;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.Button buttonDecrypt;
    }
}

