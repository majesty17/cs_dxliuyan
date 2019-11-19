namespace cs_dxliuyan
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_cookie = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_reply_date = new System.Windows.Forms.TextBox();
            this.textBox_date = new System.Windows.Forms.TextBox();
            this.textBox_sub = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_reply_dept = new System.Windows.Forms.TextBox();
            this.label_status = new System.Windows.Forms.Label();
            this.richTextBox_msg = new System.Windows.Forms.RichTextBox();
            this.richTextBox_reply = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "cookie";
            // 
            // textBox_cookie
            // 
            this.textBox_cookie.Location = new System.Drawing.Point(60, 10);
            this.textBox_cookie.Name = "textBox_cookie";
            this.textBox_cookie.Size = new System.Drawing.Size(217, 21);
            this.textBox_cookie.TabIndex = 1;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(283, 10);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            5000000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 21);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Value = new decimal(new int[] {
            214451,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.Controls.Add(this.textBox_reply_date, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBox_date, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox_sub, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox_reply_dept, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.richTextBox_msg, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.richTextBox_reply, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 55);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(756, 413);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // textBox_reply_date
            // 
            this.textBox_reply_date.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_reply_date.Location = new System.Drawing.Point(80, 348);
            this.textBox_reply_date.Multiline = true;
            this.textBox_reply_date.Name = "textBox_reply_date";
            this.textBox_reply_date.Size = new System.Drawing.Size(672, 26);
            this.textBox_reply_date.TabIndex = 17;
            // 
            // textBox_date
            // 
            this.textBox_date.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_date.Location = new System.Drawing.Point(80, 37);
            this.textBox_date.Multiline = true;
            this.textBox_date.Name = "textBox_date";
            this.textBox_date.Size = new System.Drawing.Size(672, 26);
            this.textBox_date.TabIndex = 14;
            // 
            // textBox_sub
            // 
            this.textBox_sub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_sub.Location = new System.Drawing.Point(80, 4);
            this.textBox_sub.Multiline = true;
            this.textBox_sub.Name = "textBox_sub";
            this.textBox_sub.Size = new System.Drawing.Size(672, 26);
            this.textBox_sub.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 378);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 11;
            this.label12.Text = "回复部门";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 345);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 9;
            this.label10.Text = "回复时间";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 7;
            this.label8.Text = "回复";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "留言";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "时间";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "主题";
            // 
            // textBox_reply_dept
            // 
            this.textBox_reply_dept.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_reply_dept.Location = new System.Drawing.Point(80, 381);
            this.textBox_reply_dept.Multiline = true;
            this.textBox_reply_dept.Name = "textBox_reply_dept";
            this.textBox_reply_dept.Size = new System.Drawing.Size(672, 28);
            this.textBox_reply_dept.TabIndex = 12;
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Location = new System.Drawing.Point(432, 13);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(41, 12);
            this.label_status.TabIndex = 4;
            this.label_status.Text = "label3";
            // 
            // richTextBox_msg
            // 
            this.richTextBox_msg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_msg.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox_msg.Location = new System.Drawing.Point(80, 70);
            this.richTextBox_msg.Name = "richTextBox_msg";
            this.richTextBox_msg.Size = new System.Drawing.Size(672, 132);
            this.richTextBox_msg.TabIndex = 18;
            this.richTextBox_msg.Text = "";
            // 
            // richTextBox_reply
            // 
            this.richTextBox_reply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_reply.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox_reply.Location = new System.Drawing.Point(80, 209);
            this.richTextBox_reply.Name = "richTextBox_reply";
            this.richTextBox_reply.Size = new System.Drawing.Size(672, 132);
            this.richTextBox_reply.TabIndex = 19;
            this.richTextBox_reply.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 480);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.textBox_cookie);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_cookie;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_reply_date;
        private System.Windows.Forms.TextBox textBox_date;
        private System.Windows.Forms.TextBox textBox_sub;
        private System.Windows.Forms.TextBox textBox_reply_dept;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.RichTextBox richTextBox_msg;
        private System.Windows.Forms.RichTextBox richTextBox_reply;
    }
}

