namespace GNote
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
            this.l_title = new System.Windows.Forms.Label();
            this.l_notecontent = new System.Windows.Forms.Label();
            this.tB_title = new System.Windows.Forms.TextBox();
            this.tB_content = new System.Windows.Forms.TextBox();
            this.l_saved = new System.Windows.Forms.Label();
            this.button_save = new System.Windows.Forms.Button();
            this.button_read = new System.Windows.Forms.Button();
            this.button_del = new System.Windows.Forms.Button();
            this.button_new = new System.Windows.Forms.Button();
            this.noteslist = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // l_title
            // 
            this.l_title.AutoSize = true;
            this.l_title.Location = new System.Drawing.Point(92, 104);
            this.l_title.Name = "l_title";
            this.l_title.Size = new System.Drawing.Size(32, 15);
            this.l_title.TabIndex = 0;
            this.l_title.Text = "Title:";
            // 
            // l_notecontent
            // 
            this.l_notecontent.AutoSize = true;
            this.l_notecontent.Location = new System.Drawing.Point(92, 146);
            this.l_notecontent.Name = "l_notecontent";
            this.l_notecontent.Size = new System.Drawing.Size(36, 15);
            this.l_notecontent.TabIndex = 1;
            this.l_notecontent.Text = "Note:";
            // 
            // tB_title
            // 
            this.tB_title.Location = new System.Drawing.Point(141, 108);
            this.tB_title.Name = "tB_title";
            this.tB_title.Size = new System.Drawing.Size(196, 23);
            this.tB_title.TabIndex = 2;
            // 
            // tB_content
            // 
            this.tB_content.Location = new System.Drawing.Point(141, 143);
            this.tB_content.Multiline = true;
            this.tB_content.Name = "tB_content";
            this.tB_content.Size = new System.Drawing.Size(196, 198);
            this.tB_content.TabIndex = 3;
            // 
            // l_saved
            // 
            this.l_saved.AutoSize = true;
            this.l_saved.Location = new System.Drawing.Point(506, 104);
            this.l_saved.Name = "l_saved";
            this.l_saved.Size = new System.Drawing.Size(75, 15);
            this.l_saved.TabIndex = 5;
            this.l_saved.Text = "Saved Notes:";
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(262, 358);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 6;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_read
            // 
            this.button_read.Location = new System.Drawing.Point(506, 358);
            this.button_read.Name = "button_read";
            this.button_read.Size = new System.Drawing.Size(75, 23);
            this.button_read.TabIndex = 7;
            this.button_read.Text = "Read";
            this.button_read.UseVisualStyleBackColor = true;
            this.button_read.Click += new System.EventHandler(this.button_read_Click);
            // 
            // button_del
            // 
            this.button_del.Location = new System.Drawing.Point(605, 358);
            this.button_del.Name = "button_del";
            this.button_del.Size = new System.Drawing.Size(75, 23);
            this.button_del.TabIndex = 8;
            this.button_del.Text = "Delete";
            this.button_del.UseVisualStyleBackColor = true;
            this.button_del.Click += new System.EventHandler(this.button_del_Click);
            // 
            // button_new
            // 
            this.button_new.Location = new System.Drawing.Point(141, 358);
            this.button_new.Name = "button_new";
            this.button_new.Size = new System.Drawing.Size(75, 23);
            this.button_new.TabIndex = 9;
            this.button_new.Text = "New";
            this.button_new.UseVisualStyleBackColor = true;
            this.button_new.Click += new System.EventHandler(this.button_new_Click);
            // 
            // noteslist
            // 
            this.noteslist.FormattingEnabled = true;
            this.noteslist.ItemHeight = 15;
            this.noteslist.Location = new System.Drawing.Point(506, 143);
            this.noteslist.Name = "noteslist";
            this.noteslist.Size = new System.Drawing.Size(174, 199);
            this.noteslist.TabIndex = 10;
            this.noteslist.SelectedIndexChanged += new System.EventHandler(this.noteslist_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.noteslist);
            this.Controls.Add(this.button_new);
            this.Controls.Add(this.button_del);
            this.Controls.Add(this.button_read);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.l_saved);
            this.Controls.Add(this.tB_content);
            this.Controls.Add(this.tB_title);
            this.Controls.Add(this.l_notecontent);
            this.Controls.Add(this.l_title);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label l_title;
        private Label l_notecontent;
        private TextBox tB_title;
        private TextBox tB_content;
        private Label l_saved;
        private Button button_save;
        private Button button_read;
        private Button button_del;
        private Button button_new;
        private ListBox noteslist;
    }
}