namespace Mesagi
{
    partial class ManTwo
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
            this.cancelbut = new System.Windows.Forms.Button();
            this.okbut = new System.Windows.Forms.Button();
            this.Maluav = new System.Windows.Forms.DataGridView();
            this.Perepiska = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Maluava = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Maluav)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelbut
            // 
            this.cancelbut.Location = new System.Drawing.Point(12, 334);
            this.cancelbut.Name = "cancelbut";
            this.cancelbut.Size = new System.Drawing.Size(75, 23);
            this.cancelbut.TabIndex = 0;
            this.cancelbut.Text = "cancel";
            this.cancelbut.UseVisualStyleBackColor = true;
            this.cancelbut.Click += new System.EventHandler(this.cancelbut_Click);
            // 
            // okbut
            // 
            this.okbut.Location = new System.Drawing.Point(724, 334);
            this.okbut.Name = "okbut";
            this.okbut.Size = new System.Drawing.Size(75, 23);
            this.okbut.TabIndex = 1;
            this.okbut.Text = "OK";
            this.okbut.UseVisualStyleBackColor = true;
            this.okbut.DoubleClick += new System.EventHandler(this.okbut_ddClick);
            this.okbut.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.okbut_Click);
            this.okbut.Click += new System.EventHandler(this.okbut_Click);
            // 
            // Maluav
            // 
            this.Maluav.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Maluav.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Perepiska});
            this.Maluav.Location = new System.Drawing.Point(12, 12);
            this.Maluav.Name = "Maluav";
            this.Maluav.Size = new System.Drawing.Size(787, 219);
            this.Maluav.TabIndex = 2;
            // 
            // Perepiska
            // 
            this.Perepiska.FillWeight = 1000F;
            this.Perepiska.HeaderText = "Perepiska";
            this.Perepiska.Name = "Perepiska";
            this.Perepiska.ReadOnly = true;
            this.Perepiska.Width = 700;
            // 
            // Maluava
            // 
            this.Maluava.Location = new System.Drawing.Point(12, 237);
            this.Maluava.Multiline = true;
            this.Maluava.Name = "Maluava";
            this.Maluava.Size = new System.Drawing.Size(787, 91);
            this.Maluava.TabIndex = 3;
            // 
            // ManTwo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 369);
            this.Controls.Add(this.Maluava);
            this.Controls.Add(this.Maluav);
            this.Controls.Add(this.okbut);
            this.Controls.Add(this.cancelbut);
            this.Name = "ManTwo";
            this.Text = "ManTwo";
            ((System.ComponentModel.ISupportInitialize)(this.Maluav)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelbut;
        private System.Windows.Forms.Button okbut;
        private System.Windows.Forms.DataGridView Maluav;
        private System.Windows.Forms.DataGridViewTextBoxColumn Perepiska;
        private System.Windows.Forms.TextBox Maluava;
    }
}