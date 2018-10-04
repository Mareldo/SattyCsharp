namespace saaty
{
    partial class FormRozmiarMacierzy
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxAlternatywy = new System.Windows.Forms.TextBox();
            this.textBoxKryteria = new System.Windows.Forms.TextBox();
            this.buttonAccept = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buttonExit = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(13, 67);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(115, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Ilość alternatyw";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(12, 115);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(108, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Ilość kryteriów";
            // 
            // textBoxAlternatywy
            // 
            this.textBoxAlternatywy.Location = new System.Drawing.Point(145, 65);
            this.textBoxAlternatywy.MaxLength = 1;
            this.textBoxAlternatywy.Name = "textBoxAlternatywy";
            this.textBoxAlternatywy.Size = new System.Drawing.Size(100, 20);
            this.textBoxAlternatywy.TabIndex = 2;
            // 
            // textBoxKryteria
            // 
            this.textBoxKryteria.Location = new System.Drawing.Point(145, 115);
            this.textBoxKryteria.MaxLength = 1;
            this.textBoxKryteria.Name = "textBoxKryteria";
            this.textBoxKryteria.Size = new System.Drawing.Size(100, 20);
            this.textBoxKryteria.TabIndex = 3;
            // 
            // buttonAccept
            // 
            this.buttonAccept.Depth = 0;
            this.buttonAccept.Location = new System.Drawing.Point(145, 202);
            this.buttonAccept.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Primary = true;
            this.buttonAccept.Size = new System.Drawing.Size(100, 33);
            this.buttonAccept.TabIndex = 4;
            this.buttonAccept.Text = "Dalej";
            this.buttonAccept.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            this.buttonExit.Depth = 0;
            this.buttonExit.Location = new System.Drawing.Point(17, 202);
            this.buttonExit.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Primary = true;
            this.buttonExit.Size = new System.Drawing.Size(93, 33);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Wyjdź";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // FormRozmiarMacierzy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.textBoxKryteria);
            this.Controls.Add(this.textBoxAlternatywy);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRozmiarMacierzy";
            this.Text = "FormRozmiarMacierzy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.TextBox textBoxAlternatywy;
        private System.Windows.Forms.TextBox textBoxKryteria;
        private MaterialSkin.Controls.MaterialRaisedButton buttonAccept;
        private MaterialSkin.Controls.MaterialRaisedButton buttonExit;
    }
}