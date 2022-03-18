namespace DB_GUI
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
            this.showBooksBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.booksHomeBtn = new System.Windows.Forms.Button();
            this.booksBorrowedBtn = new System.Windows.Forms.Button();
            this.newMemberBtn = new System.Windows.Forms.Button();
            this.showMembersBtn = new System.Windows.Forms.Button();
            this.newBookBtn = new System.Windows.Forms.Button();
            this.borrowBookBtn = new System.Windows.Forms.Button();
            this.memberBorrowedBtn = new System.Windows.Forms.Button();
            this.memberBorrowingBtn = new System.Windows.Forms.Button();
            this.deleteBookBtn = new System.Windows.Forms.Button();
            this.deleteMemberBtn = new System.Windows.Forms.Button();
            this.booksFromKategoryBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // showBooksBtn
            // 
            this.showBooksBtn.Location = new System.Drawing.Point(12, 12);
            this.showBooksBtn.Name = "showBooksBtn";
            this.showBooksBtn.Size = new System.Drawing.Size(138, 32);
            this.showBooksBtn.TabIndex = 4;
            this.showBooksBtn.Text = "Show Books";
            this.showBooksBtn.UseVisualStyleBackColor = true;
            this.showBooksBtn.Click += new System.EventHandler(this.showBooksBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(169, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(538, 463);
            this.dataGridView1.TabIndex = 5;
            // 
            // booksHomeBtn
            // 
            this.booksHomeBtn.Location = new System.Drawing.Point(12, 50);
            this.booksHomeBtn.Name = "booksHomeBtn";
            this.booksHomeBtn.Size = new System.Drawing.Size(138, 32);
            this.booksHomeBtn.TabIndex = 6;
            this.booksHomeBtn.Text = "Show Books Home";
            this.booksHomeBtn.UseVisualStyleBackColor = true;
            this.booksHomeBtn.Click += new System.EventHandler(this.booksHomeBtn_Click);
            // 
            // booksBorrowedBtn
            // 
            this.booksBorrowedBtn.Location = new System.Drawing.Point(12, 88);
            this.booksBorrowedBtn.Name = "booksBorrowedBtn";
            this.booksBorrowedBtn.Size = new System.Drawing.Size(138, 32);
            this.booksBorrowedBtn.TabIndex = 7;
            this.booksBorrowedBtn.Text = "Show Books Borrowed";
            this.booksBorrowedBtn.UseVisualStyleBackColor = true;
            this.booksBorrowedBtn.Click += new System.EventHandler(this.booksBorrowedBtn_Click);
            // 
            // newMemberBtn
            // 
            this.newMemberBtn.Location = new System.Drawing.Point(13, 166);
            this.newMemberBtn.Name = "newMemberBtn";
            this.newMemberBtn.Size = new System.Drawing.Size(138, 32);
            this.newMemberBtn.TabIndex = 8;
            this.newMemberBtn.Text = "Add New Member";
            this.newMemberBtn.UseVisualStyleBackColor = true;
            this.newMemberBtn.Click += new System.EventHandler(this.newMemberBtn_Click);
            // 
            // showMembersBtn
            // 
            this.showMembersBtn.Location = new System.Drawing.Point(13, 128);
            this.showMembersBtn.Name = "showMembersBtn";
            this.showMembersBtn.Size = new System.Drawing.Size(137, 32);
            this.showMembersBtn.TabIndex = 9;
            this.showMembersBtn.Text = "Show Members";
            this.showMembersBtn.UseVisualStyleBackColor = true;
            this.showMembersBtn.Click += new System.EventHandler(this.showMembersBtn_Click);
            // 
            // newBookBtn
            // 
            this.newBookBtn.Location = new System.Drawing.Point(12, 204);
            this.newBookBtn.Name = "newBookBtn";
            this.newBookBtn.Size = new System.Drawing.Size(138, 32);
            this.newBookBtn.TabIndex = 10;
            this.newBookBtn.Text = "Add New Book";
            this.newBookBtn.UseVisualStyleBackColor = true;
            this.newBookBtn.Click += new System.EventHandler(this.newBookBtn_Click);
            // 
            // borrowBookBtn
            // 
            this.borrowBookBtn.Location = new System.Drawing.Point(13, 242);
            this.borrowBookBtn.Name = "borrowBookBtn";
            this.borrowBookBtn.Size = new System.Drawing.Size(137, 32);
            this.borrowBookBtn.TabIndex = 11;
            this.borrowBookBtn.Text = "Borrow Book";
            this.borrowBookBtn.UseVisualStyleBackColor = true;
            this.borrowBookBtn.Click += new System.EventHandler(this.borrowBookBtn_Click);
            // 
            // memberBorrowedBtn
            // 
            this.memberBorrowedBtn.Location = new System.Drawing.Point(12, 280);
            this.memberBorrowedBtn.Name = "memberBorrowedBtn";
            this.memberBorrowedBtn.Size = new System.Drawing.Size(138, 35);
            this.memberBorrowedBtn.TabIndex = 12;
            this.memberBorrowedBtn.Text = "Show Books a Member has Borrowed";
            this.memberBorrowedBtn.UseVisualStyleBackColor = true;
            this.memberBorrowedBtn.Click += new System.EventHandler(this.memberBorrowedBtn_Click);
            // 
            // memberBorrowingBtn
            // 
            this.memberBorrowingBtn.Location = new System.Drawing.Point(13, 321);
            this.memberBorrowingBtn.Name = "memberBorrowingBtn";
            this.memberBorrowingBtn.Size = new System.Drawing.Size(138, 35);
            this.memberBorrowingBtn.TabIndex = 13;
            this.memberBorrowingBtn.Text = "Show Books a Meber is Borrowing";
            this.memberBorrowingBtn.UseVisualStyleBackColor = true;
            this.memberBorrowingBtn.Click += new System.EventHandler(this.memberBorrowingBtn_Click);
            // 
            // deleteBookBtn
            // 
            this.deleteBookBtn.Location = new System.Drawing.Point(13, 363);
            this.deleteBookBtn.Name = "deleteBookBtn";
            this.deleteBookBtn.Size = new System.Drawing.Size(138, 32);
            this.deleteBookBtn.TabIndex = 14;
            this.deleteBookBtn.Text = "Delete Book";
            this.deleteBookBtn.UseVisualStyleBackColor = true;
            this.deleteBookBtn.Click += new System.EventHandler(this.deleteBookBtn_Click);
            // 
            // deleteMemberBtn
            // 
            this.deleteMemberBtn.Location = new System.Drawing.Point(12, 402);
            this.deleteMemberBtn.Name = "deleteMemberBtn";
            this.deleteMemberBtn.Size = new System.Drawing.Size(138, 32);
            this.deleteMemberBtn.TabIndex = 15;
            this.deleteMemberBtn.Text = "Delete Member";
            this.deleteMemberBtn.UseVisualStyleBackColor = true;
            this.deleteMemberBtn.Click += new System.EventHandler(this.deleteMemberBtn_Click);
            // 
            // booksFromKategoryBtn
            // 
            this.booksFromKategoryBtn.Location = new System.Drawing.Point(12, 440);
            this.booksFromKategoryBtn.Name = "booksFromKategoryBtn";
            this.booksFromKategoryBtn.Size = new System.Drawing.Size(138, 35);
            this.booksFromKategoryBtn.TabIndex = 16;
            this.booksFromKategoryBtn.Text = "Show Books From kategory";
            this.booksFromKategoryBtn.UseVisualStyleBackColor = true;
            this.booksFromKategoryBtn.Click += new System.EventHandler(this.booksFromKategoryBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 490);
            this.Controls.Add(this.booksFromKategoryBtn);
            this.Controls.Add(this.deleteMemberBtn);
            this.Controls.Add(this.deleteBookBtn);
            this.Controls.Add(this.memberBorrowingBtn);
            this.Controls.Add(this.memberBorrowedBtn);
            this.Controls.Add(this.borrowBookBtn);
            this.Controls.Add(this.newBookBtn);
            this.Controls.Add(this.showMembersBtn);
            this.Controls.Add(this.newMemberBtn);
            this.Controls.Add(this.booksBorrowedBtn);
            this.Controls.Add(this.booksHomeBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.showBooksBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button showBooksBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button booksHomeBtn;
        private System.Windows.Forms.Button booksBorrowedBtn;
        private System.Windows.Forms.Button newMemberBtn;
        private System.Windows.Forms.Button showMembersBtn;
        private System.Windows.Forms.Button newBookBtn;
        private System.Windows.Forms.Button borrowBookBtn;
        private System.Windows.Forms.Button memberBorrowedBtn;
        private System.Windows.Forms.Button memberBorrowingBtn;
        private System.Windows.Forms.Button deleteBookBtn;
        private System.Windows.Forms.Button deleteMemberBtn;
        private System.Windows.Forms.Button booksFromKategoryBtn;
    }
}

