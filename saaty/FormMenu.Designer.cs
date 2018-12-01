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
            this.buttonDemo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Depth = 0;
            this.buttonStart.Location = new System.Drawing.Point(40, 55);
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
            this.buttonWyjdz.Location = new System.Drawing.Point(67, 235);
            this.buttonWyjdz.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonWyjdz.Name = "buttonWyjdz";
            this.buttonWyjdz.Primary = true;
            this.buttonWyjdz.Size = new System.Drawing.Size(123, 44);
            this.buttonWyjdz.TabIndex = 1;
            this.buttonWyjdz.Text = "Wyjdź";
            this.buttonWyjdz.UseVisualStyleBackColor = true;
            this.buttonWyjdz.Click += new System.EventHandler(this.buttonWyjdz_Click);
            // 
            // buttonDemo
            // 
            this.buttonDemo.Depth = 0;
            this.buttonDemo.Location = new System.Drawing.Point(40, 146);
            this.buttonDemo.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonDemo.Name = "buttonDemo";
            this.buttonDemo.Primary = true;
            this.buttonDemo.Size = new System.Drawing.Size(183, 53);
            this.buttonDemo.TabIndex = 2;
            this.buttonDemo.Text = "demo";
            this.buttonDemo.UseVisualStyleBackColor = true;
            this.buttonDemo.Click += new System.EventHandler(this.buttonDemo_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(40, 13);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(184, 19);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Podejmowacz decyzji v0.1";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 326);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.buttonDemo);
            this.Controls.Add(this.buttonWyjdz);
            this.Controls.Add(this.buttonStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton buttonStart;
        private MaterialSkin.Controls.MaterialRaisedButton buttonWyjdz;
        private MaterialSkin.Controls.MaterialRaisedButton buttonDemo;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}