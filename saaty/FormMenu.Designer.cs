namespace saaty
{
    partial class FormMenu
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
            this.buttonStart = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buttonWyjdz = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Depth = 0;
            this.buttonStart.Location = new System.Drawing.Point(70, 49);
            this.buttonStart.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Primary = true;
            this.buttonStart.Size = new System.Drawing.Size(183, 50);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Wpisz ręcznie";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonWyjdz
            // 
            this.buttonWyjdz.Depth = 0;
            this.buttonWyjdz.Location = new System.Drawing.Point(84, 204);
            this.buttonWyjdz.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonWyjdz.Name = "buttonWyjdz";
            this.buttonWyjdz.Primary = true;
            this.buttonWyjdz.Size = new System.Drawing.Size(123, 44);
            this.buttonWyjdz.TabIndex = 1;
            this.buttonWyjdz.Text = "Wyjdź";
            this.buttonWyjdz.UseVisualStyleBackColor = true;
            this.buttonWyjdz.Click += new System.EventHandler(this.buttonWyjdz_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 326);
            this.Controls.Add(this.buttonWyjdz);
            this.Controls.Add(this.buttonStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton buttonStart;
        private MaterialSkin.Controls.MaterialRaisedButton buttonWyjdz;
    }
}