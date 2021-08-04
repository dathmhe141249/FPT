
namespace Q1_PE_SP20_B1
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
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lbCountry = new System.Windows.Forms.ListBox();
            this.dgvCase = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCase)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDate
            // 
            this.dtpDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpDate.Location = new System.Drawing.Point(44, 27);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(262, 22);
            this.dtpDate.TabIndex = 0;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // lbCountry
            // 
            this.lbCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbCountry.FormattingEnabled = true;
            this.lbCountry.ItemHeight = 20;
            this.lbCountry.Location = new System.Drawing.Point(44, 83);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbCountry.Size = new System.Drawing.Size(181, 304);
            this.lbCountry.TabIndex = 1;
            this.lbCountry.SelectedIndexChanged += new System.EventHandler(this.lbCountry_SelectedIndexChanged);
            // 
            // dgvCase
            // 
            this.dgvCase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCase.Location = new System.Drawing.Point(259, 83);
            this.dgvCase.Name = "dgvCase";
            this.dgvCase.RowHeadersWidth = 51;
            this.dgvCase.RowTemplate.Height = 24;
            this.dgvCase.Size = new System.Drawing.Size(496, 304);
            this.dgvCase.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvCase);
            this.Controls.Add(this.lbCountry);
            this.Controls.Add(this.dtpDate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCase)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ListBox lbCountry;
        private System.Windows.Forms.DataGridView dgvCase;
    }
}

