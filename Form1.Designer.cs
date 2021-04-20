
namespace Tic_Tac_Toe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lr = new System.Windows.Forms.Button();
            this.lm = new System.Windows.Forms.Button();
            this.ll = new System.Windows.Forms.Button();
            this.mr = new System.Windows.Forms.Button();
            this.m = new System.Windows.Forms.Button();
            this.ml = new System.Windows.Forms.Button();
            this.tr = new System.Windows.Forms.Button();
            this.tm = new System.Windows.Forms.Button();
            this.tl = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tableLayoutPanel1.Controls.Add(this.lr, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lm, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.ll, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.mr, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.m, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ml, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tr, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tm, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tl, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(193, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(382, 374);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lr
            // 
            this.lr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lr.Location = new System.Drawing.Point(257, 261);
            this.lr.Name = "lr";
            this.lr.Size = new System.Drawing.Size(122, 110);
            this.lr.TabIndex = 8;
            this.lr.UseVisualStyleBackColor = true;
            this.lr.Click += new System.EventHandler(this.Mark);
            // 
            // lm
            // 
            this.lm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lm.Location = new System.Drawing.Point(130, 261);
            this.lm.Name = "lm";
            this.lm.Size = new System.Drawing.Size(121, 110);
            this.lm.TabIndex = 7;
            this.lm.UseVisualStyleBackColor = true;
            this.lm.Click += new System.EventHandler(this.Mark);
            // 
            // ll
            // 
            this.ll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ll.Location = new System.Drawing.Point(3, 261);
            this.ll.Name = "ll";
            this.ll.Size = new System.Drawing.Size(121, 110);
            this.ll.TabIndex = 6;
            this.ll.UseVisualStyleBackColor = true;
            this.ll.Click += new System.EventHandler(this.Mark);
            // 
            // mr
            // 
            this.mr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mr.Location = new System.Drawing.Point(257, 132);
            this.mr.Name = "mr";
            this.mr.Size = new System.Drawing.Size(122, 123);
            this.mr.TabIndex = 5;
            this.mr.UseVisualStyleBackColor = true;
            this.mr.Click += new System.EventHandler(this.Mark);
            // 
            // m
            // 
            this.m.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m.Location = new System.Drawing.Point(130, 132);
            this.m.Name = "m";
            this.m.Size = new System.Drawing.Size(121, 123);
            this.m.TabIndex = 4;
            this.m.UseVisualStyleBackColor = true;
            this.m.Click += new System.EventHandler(this.Mark);
            // 
            // ml
            // 
            this.ml.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ml.Location = new System.Drawing.Point(3, 132);
            this.ml.Name = "ml";
            this.ml.Size = new System.Drawing.Size(121, 123);
            this.ml.TabIndex = 3;
            this.ml.UseVisualStyleBackColor = true;
            this.ml.Click += new System.EventHandler(this.Mark);
            // 
            // tr
            // 
            this.tr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tr.Location = new System.Drawing.Point(257, 3);
            this.tr.Name = "tr";
            this.tr.Size = new System.Drawing.Size(122, 123);
            this.tr.TabIndex = 2;
            this.tr.UseVisualStyleBackColor = true;
            this.tr.Click += new System.EventHandler(this.Mark);
            // 
            // tm
            // 
            this.tm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tm.Location = new System.Drawing.Point(130, 3);
            this.tm.Name = "tm";
            this.tm.Size = new System.Drawing.Size(121, 123);
            this.tm.TabIndex = 1;
            this.tm.UseVisualStyleBackColor = true;
            this.tm.Click += new System.EventHandler(this.Mark);
            // 
            // tl
            // 
            this.tl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tl.Location = new System.Drawing.Point(3, 3);
            this.tl.Name = "tl";
            this.tl.Size = new System.Drawing.Size(121, 123);
            this.tl.TabIndex = 0;
            this.tl.UseVisualStyleBackColor = true;
            this.tl.Click += new System.EventHandler(this.Mark);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 389);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ruch:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 389);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "X";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button lr;
        private System.Windows.Forms.Button lm;
        private System.Windows.Forms.Button ll;
        private System.Windows.Forms.Button mr;
        private System.Windows.Forms.Button m;
        private System.Windows.Forms.Button ml;
        private System.Windows.Forms.Button tr;
        private System.Windows.Forms.Button tm;
        private System.Windows.Forms.Button tl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

