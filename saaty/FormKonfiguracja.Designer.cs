namespace saaty
{
    partial class FormKonfiguracja
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
            this.buttonZapisz = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxAlternatywy = new System.Windows.Forms.TextBox();
            this.textBoxKryteria = new System.Windows.Forms.TextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // buttonZapisz
            // 
            this.buttonZapisz.Depth = 0;
            this.buttonZapisz.Location = new System.Drawing.Point(159, 144);
            this.buttonZapisz.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonZapisz.Name = "buttonZapisz";
            this.buttonZapisz.Primary = true;
            this.buttonZapisz.Size = new System.Drawing.Size(157, 34);
            this.buttonZapisz.TabIndex = 5;
            this.buttonZapisz.Text = "Dalej";
            this.buttonZapisz.UseVisualStyleBackColor = true;
            this.buttonZapisz.Click += new System.EventHandler(this.buttonZapisz_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 48);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(87, 19);
            this.materialLabel1.TabIndex = 6;
            this.materialLabel1.Text = "Alternatywy";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(12, 76);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(60, 19);
            this.materialLabel2.TabIndex = 7;
            this.materialLabel2.Text = "Kryteria";
            // 
            // textBoxAlternatywy
            // 
            this.textBoxAlternatywy.Location = new System.Drawing.Point(117, 49);
            this.textBoxAlternatywy.Name = "textBoxAlternatywy";
            this.textBoxAlternatywy.Size = new System.Drawing.Size(100, 20);
            this.textBoxAlternatywy.TabIndex = 8;
            // 
            // textBoxKryteria
            // 
            this.textBoxKryteria.Location = new System.Drawing.Point(117, 75);
            this.textBoxKryteria.Name = "textBoxKryteria";
            this.textBoxKryteria.Size = new System.Drawing.Size(100, 20);
            this.textBoxKryteria.TabIndex = 9;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(12, 9);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(231, 19);
            this.materialLabel3.TabIndex = 10;
            this.materialLabel3.Text = "Podaj ilość alternatyw i kryteriów";
            // 
            // FormKonfiguracja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 192);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.textBoxKryteria);
            this.Controls.Add(this.textBoxAlternatywy);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.buttonZapisz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormKonfiguracja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormNazywanie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialRaisedButton buttonZapisz;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.TextBox textBoxAlternatywy;
        private System.Windows.Forms.TextBox textBoxKryteria;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
    }
}