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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.textBoxAlt = new System.Windows.Forms.TextBox();
            this.buttonAddAlt = new MaterialSkin.Controls.MaterialRaisedButton();
            this.textBoxKryt = new System.Windows.Forms.TextBox();
            this.buttonAddKryt = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buttonZapisz = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dataGridView.Location = new System.Drawing.Point(13, 66);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 100;
            this.dataGridView.Size = new System.Drawing.Size(454, 351);
            this.dataGridView.TabIndex = 0;
            // 
            // textBoxAlt
            // 
            this.textBoxAlt.Location = new System.Drawing.Point(13, 33);
            this.textBoxAlt.Name = "textBoxAlt";
            this.textBoxAlt.Size = new System.Drawing.Size(100, 20);
            this.textBoxAlt.TabIndex = 1;
            // 
            // buttonAddAlt
            // 
            this.buttonAddAlt.Depth = 0;
            this.buttonAddAlt.Location = new System.Drawing.Point(119, 24);
            this.buttonAddAlt.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonAddAlt.Name = "buttonAddAlt";
            this.buttonAddAlt.Primary = true;
            this.buttonAddAlt.Size = new System.Drawing.Size(104, 36);
            this.buttonAddAlt.TabIndex = 2;
            this.buttonAddAlt.Text = "Dodaj alternatywę";
            this.buttonAddAlt.UseVisualStyleBackColor = true;
            this.buttonAddAlt.Click += new System.EventHandler(this.buttonAddAlt_Click);
            // 
            // textBoxKryt
            // 
            this.textBoxKryt.Location = new System.Drawing.Point(269, 33);
            this.textBoxKryt.Name = "textBoxKryt";
            this.textBoxKryt.Size = new System.Drawing.Size(100, 20);
            this.textBoxKryt.TabIndex = 3;
            // 
            // buttonAddKryt
            // 
            this.buttonAddKryt.Depth = 0;
            this.buttonAddKryt.Location = new System.Drawing.Point(375, 24);
            this.buttonAddKryt.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonAddKryt.Name = "buttonAddKryt";
            this.buttonAddKryt.Primary = true;
            this.buttonAddKryt.Size = new System.Drawing.Size(92, 36);
            this.buttonAddKryt.TabIndex = 4;
            this.buttonAddKryt.Text = "Dodaj kryterium";
            this.buttonAddKryt.UseVisualStyleBackColor = true;
            this.buttonAddKryt.Click += new System.EventHandler(this.buttonAddKryt_Click);
            // 
            // buttonZapisz
            // 
            this.buttonZapisz.Depth = 0;
            this.buttonZapisz.Location = new System.Drawing.Point(310, 423);
            this.buttonZapisz.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonZapisz.Name = "buttonZapisz";
            this.buttonZapisz.Primary = true;
            this.buttonZapisz.Size = new System.Drawing.Size(157, 34);
            this.buttonZapisz.TabIndex = 5;
            this.buttonZapisz.Text = "Zapisz";
            this.buttonZapisz.UseVisualStyleBackColor = true;
            this.buttonZapisz.Click += new System.EventHandler(this.buttonZapisz_Click);
            // 
            // FormKonfiguracja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 469);
            this.Controls.Add(this.buttonZapisz);
            this.Controls.Add(this.buttonAddKryt);
            this.Controls.Add(this.textBoxKryt);
            this.Controls.Add(this.buttonAddAlt);
            this.Controls.Add(this.textBoxAlt);
            this.Controls.Add(this.dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormKonfiguracja";
            this.Text = "FormNazywanie";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox textBoxAlt;
        private MaterialSkin.Controls.MaterialRaisedButton buttonAddAlt;
        private System.Windows.Forms.TextBox textBoxKryt;
        private MaterialSkin.Controls.MaterialRaisedButton buttonAddKryt;
        private MaterialSkin.Controls.MaterialRaisedButton buttonZapisz;
    }
}