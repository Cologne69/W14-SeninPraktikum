namespace W14_Praktikum
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
            this.btn_Last = new System.Windows.Forms.Button();
            this.btn_prev = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_begin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_namaTim = new System.Windows.Forms.Label();
            this.lbl_Manager = new System.Windows.Forms.Label();
            this.lbl_SIUUUU = new System.Windows.Forms.Label();
            this.lbl_topScorer = new System.Windows.Forms.Label();
            this.lbl_Stadium = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Last
            // 
            this.btn_Last.Location = new System.Drawing.Point(224, 12);
            this.btn_Last.Name = "btn_Last";
            this.btn_Last.Size = new System.Drawing.Size(82, 60);
            this.btn_Last.TabIndex = 0;
            this.btn_Last.Text = "<<";
            this.btn_Last.UseVisualStyleBackColor = true;
            this.btn_Last.Click += new System.EventHandler(this.btn_Last_Click);
            // 
            // btn_prev
            // 
            this.btn_prev.Location = new System.Drawing.Point(312, 12);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(82, 60);
            this.btn_prev.TabIndex = 1;
            this.btn_prev.Text = "<";
            this.btn_prev.UseVisualStyleBackColor = true;
            this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(400, 12);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(82, 60);
            this.btn_next.TabIndex = 2;
            this.btn_next.Text = ">";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_begin
            // 
            this.btn_begin.Location = new System.Drawing.Point(488, 12);
            this.btn_begin.Name = "btn_begin";
            this.btn_begin.Size = new System.Drawing.Size(82, 60);
            this.btn_begin.TabIndex = 3;
            this.btn_begin.Text = ">>";
            this.btn_begin.UseVisualStyleBackColor = true;
            this.btn_begin.Click += new System.EventHandler(this.btn_begin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Team Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Manager :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Stadium :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Top Scorer :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Worst Dicipline :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lbl_namaTim
            // 
            this.lbl_namaTim.AutoSize = true;
            this.lbl_namaTim.Location = new System.Drawing.Point(220, 128);
            this.lbl_namaTim.Name = "lbl_namaTim";
            this.lbl_namaTim.Size = new System.Drawing.Size(21, 20);
            this.lbl_namaTim.TabIndex = 10;
            this.lbl_namaTim.Text = "...";
            // 
            // lbl_Manager
            // 
            this.lbl_Manager.AutoSize = true;
            this.lbl_Manager.Location = new System.Drawing.Point(220, 167);
            this.lbl_Manager.Name = "lbl_Manager";
            this.lbl_Manager.Size = new System.Drawing.Size(21, 20);
            this.lbl_Manager.TabIndex = 11;
            this.lbl_Manager.Text = "...";
            // 
            // lbl_SIUUUU
            // 
            this.lbl_SIUUUU.AutoSize = true;
            this.lbl_SIUUUU.Location = new System.Drawing.Point(220, 293);
            this.lbl_SIUUUU.Name = "lbl_SIUUUU";
            this.lbl_SIUUUU.Size = new System.Drawing.Size(21, 20);
            this.lbl_SIUUUU.TabIndex = 12;
            this.lbl_SIUUUU.Text = "...";
            this.lbl_SIUUUU.Click += new System.EventHandler(this.lbl_SIUUUU_Click);
            // 
            // lbl_topScorer
            // 
            this.lbl_topScorer.AutoSize = true;
            this.lbl_topScorer.Location = new System.Drawing.Point(220, 248);
            this.lbl_topScorer.Name = "lbl_topScorer";
            this.lbl_topScorer.Size = new System.Drawing.Size(21, 20);
            this.lbl_topScorer.TabIndex = 13;
            this.lbl_topScorer.Text = "...";
            // 
            // lbl_Stadium
            // 
            this.lbl_Stadium.AutoSize = true;
            this.lbl_Stadium.Location = new System.Drawing.Point(220, 208);
            this.lbl_Stadium.Name = "lbl_Stadium";
            this.lbl_Stadium.Size = new System.Drawing.Size(21, 20);
            this.lbl_Stadium.TabIndex = 14;
            this.lbl_Stadium.Text = "...";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 348);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(776, 272);
            this.dataGridView1.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 632);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_Stadium);
            this.Controls.Add(this.lbl_topScorer);
            this.Controls.Add(this.lbl_SIUUUU);
            this.Controls.Add(this.lbl_Manager);
            this.Controls.Add(this.lbl_namaTim);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_begin);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_prev);
            this.Controls.Add(this.btn_Last);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Last;
        private System.Windows.Forms.Button btn_prev;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_begin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_namaTim;
        private System.Windows.Forms.Label lbl_Manager;
        private System.Windows.Forms.Label lbl_SIUUUU;
        private System.Windows.Forms.Label lbl_topScorer;
        private System.Windows.Forms.Label lbl_Stadium;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

