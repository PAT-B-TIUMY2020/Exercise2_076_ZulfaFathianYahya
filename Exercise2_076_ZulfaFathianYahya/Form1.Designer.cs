namespace Exercise2_076_ZulfaFathianYahya
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNim = new System.Windows.Forms.TextBox();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.textBoxProdi = new System.Windows.Forms.TextBox();
            this.textBoxAngkatan = new System.Windows.Forms.TextBox();
            this.dtmhs = new System.Windows.Forms.DataGridView();
            this.buttoncreate = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtmhs)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "NIM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama mahasiswa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prodi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Angkatan";
            // 
            // textBoxNim
            // 
            this.textBoxNim.Location = new System.Drawing.Point(272, 57);
            this.textBoxNim.Name = "textBoxNim";
            this.textBoxNim.Size = new System.Drawing.Size(222, 22);
            this.textBoxNim.TabIndex = 4;
            // 
            // textBoxNama
            // 
            this.textBoxNama.Location = new System.Drawing.Point(272, 92);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(222, 22);
            this.textBoxNama.TabIndex = 5;
            // 
            // textBoxProdi
            // 
            this.textBoxProdi.Location = new System.Drawing.Point(272, 139);
            this.textBoxProdi.Name = "textBoxProdi";
            this.textBoxProdi.Size = new System.Drawing.Size(222, 22);
            this.textBoxProdi.TabIndex = 6;
            // 
            // textBoxAngkatan
            // 
            this.textBoxAngkatan.Location = new System.Drawing.Point(272, 186);
            this.textBoxAngkatan.Name = "textBoxAngkatan";
            this.textBoxAngkatan.Size = new System.Drawing.Size(222, 22);
            this.textBoxAngkatan.TabIndex = 7;
            // 
            // dtmhs
            // 
            this.dtmhs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtmhs.Location = new System.Drawing.Point(85, 281);
            this.dtmhs.Name = "dtmhs";
            this.dtmhs.RowHeadersWidth = 51;
            this.dtmhs.RowTemplate.Height = 24;
            this.dtmhs.Size = new System.Drawing.Size(626, 147);
            this.dtmhs.TabIndex = 8;
            this.dtmhs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtmhs_CellClick);
            // 
            // buttoncreate
            // 
            this.buttoncreate.Location = new System.Drawing.Point(622, 57);
            this.buttoncreate.Name = "buttoncreate";
            this.buttoncreate.Size = new System.Drawing.Size(89, 22);
            this.buttoncreate.TabIndex = 9;
            this.buttoncreate.Text = "Create";
            this.buttoncreate.UseVisualStyleBackColor = true;
            this.buttoncreate.Click += new System.EventHandler(this.buttoncreate_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(622, 109);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(89, 22);
            this.buttonSearch.TabIndex = 10;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(622, 163);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(89, 22);
            this.buttonUpdate.TabIndex = 11;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(622, 212);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(89, 22);
            this.buttonDelete.TabIndex = 12;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "jumlah Mahasiswa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(269, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "label6";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(405, 232);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(89, 22);
            this.button5.TabIndex = 15;
            this.button5.Text = "Jumlah";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttoncreate);
            this.Controls.Add(this.dtmhs);
            this.Controls.Add(this.textBoxAngkatan);
            this.Controls.Add(this.textBoxProdi);
            this.Controls.Add(this.textBoxNama);
            this.Controls.Add(this.textBoxNim);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtmhs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNim;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.TextBox textBoxProdi;
        private System.Windows.Forms.TextBox textBoxAngkatan;
        private System.Windows.Forms.DataGridView dtmhs;
        private System.Windows.Forms.Button buttoncreate;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button5;
    }
}

