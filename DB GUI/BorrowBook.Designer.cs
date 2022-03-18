namespace DB_GUI
{
    partial class BorrowBook
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
            this.bookIDTxt = new System.Windows.Forms.TextBox();
            this.memberIDTxt = new System.Windows.Forms.TextBox();
            this.borrowDateTxt = new System.Windows.Forms.TextBox();
            this.dueDateTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.submitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bookIDTxt
            // 
            this.bookIDTxt.Location = new System.Drawing.Point(117, 16);
            this.bookIDTxt.Name = "bookIDTxt";
            this.bookIDTxt.Size = new System.Drawing.Size(251, 20);
            this.bookIDTxt.TabIndex = 0;
            // 
            // memberIDTxt
            // 
            this.memberIDTxt.Location = new System.Drawing.Point(117, 43);
            this.memberIDTxt.Name = "memberIDTxt";
            this.memberIDTxt.Size = new System.Drawing.Size(251, 20);
            this.memberIDTxt.TabIndex = 1;
            // 
            // borrowDateTxt
            // 
            this.borrowDateTxt.Location = new System.Drawing.Point(117, 70);
            this.borrowDateTxt.Name = "borrowDateTxt";
            this.borrowDateTxt.Size = new System.Drawing.Size(251, 20);
            this.borrowDateTxt.TabIndex = 2;
            // 
            // dueDateTxt
            // 
            this.dueDateTxt.Location = new System.Drawing.Point(117, 97);
            this.dueDateTxt.Name = "dueDateTxt";
            this.dueDateTxt.Size = new System.Drawing.Size(251, 20);
            this.dueDateTxt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Book ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(13, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Member ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(13, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Borrow Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Due Date:";
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(375, 81);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(121, 35);
            this.submitBtn.TabIndex = 8;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // BorrowBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 134);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dueDateTxt);
            this.Controls.Add(this.borrowDateTxt);
            this.Controls.Add(this.memberIDTxt);
            this.Controls.Add(this.bookIDTxt);
            this.Name = "BorrowBook";
            this.Text = "BorrowBook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox bookIDTxt;
        private System.Windows.Forms.TextBox memberIDTxt;
        private System.Windows.Forms.TextBox borrowDateTxt;
        private System.Windows.Forms.TextBox dueDateTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button submitBtn;
    }
}