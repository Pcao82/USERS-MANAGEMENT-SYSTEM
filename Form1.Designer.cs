namespace TO_DO_LIST
{
    partial class ToDolist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToDolist));
            this.label1 = new System.Windows.Forms.Label();
            this.titletextBox = new System.Windows.Forms.TextBox();
            this.DescriptiontextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.newButton = new System.Windows.Forms.Button();
            this.editbutton2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.Todolistview = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.usernametextBox1 = new System.Windows.Forms.TextBox();
            this.PasstextBox2 = new System.Windows.Forms.TextBox();
            this.Pass_confirmtextBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Todolistview)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(767, 66);
            this.label1.TabIndex = 0;
            this.label1.Text = "USERS MANAGEMENT SYSTEM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // titletextBox
            // 
            this.titletextBox.Location = new System.Drawing.Point(2, 438);
            this.titletextBox.Name = "titletextBox";
            this.titletextBox.Size = new System.Drawing.Size(800, 20);
            this.titletextBox.TabIndex = 1;
            this.titletextBox.TextChanged += new System.EventHandler(this.titletextBox_TextChanged);
            // 
            // DescriptiontextBox
            // 
            this.DescriptiontextBox.Location = new System.Drawing.Point(2, 487);
            this.DescriptiontextBox.Name = "DescriptiontextBox";
            this.DescriptiontextBox.Size = new System.Drawing.Size(800, 20);
            this.DescriptiontextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-1, 461);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(800, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-1, 412);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(800, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Title:";
            // 
            // newButton
            // 
            this.newButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newButton.Location = new System.Drawing.Point(1, 514);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(172, 23);
            this.newButton.TabIndex = 6;
            this.newButton.Text = "New";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // editbutton2
            // 
            this.editbutton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editbutton2.Location = new System.Drawing.Point(193, 513);
            this.editbutton2.Name = "editbutton2";
            this.editbutton2.Size = new System.Drawing.Size(146, 23);
            this.editbutton2.TabIndex = 7;
            this.editbutton2.Text = "Edit";
            this.editbutton2.UseVisualStyleBackColor = true;
            this.editbutton2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(384, 513);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(591, 513);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(152, 23);
            this.SaveButton.TabIndex = 9;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // Todolistview
            // 
            this.Todolistview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Todolistview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Todolistview.BackgroundColor = System.Drawing.Color.White;
            this.Todolistview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Todolistview.Location = new System.Drawing.Point(1, 543);
            this.Todolistview.Name = "Todolistview";
            this.Todolistview.Size = new System.Drawing.Size(857, 281);
            this.Todolistview.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(163, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Username";
            // 
            // usernametextBox1
            // 
            this.usernametextBox1.Location = new System.Drawing.Point(277, 119);
            this.usernametextBox1.Name = "usernametextBox1";
            this.usernametextBox1.Size = new System.Drawing.Size(187, 20);
            this.usernametextBox1.TabIndex = 14;
            // 
            // PasstextBox2
            // 
            this.PasstextBox2.Location = new System.Drawing.Point(277, 177);
            this.PasstextBox2.Name = "PasstextBox2";
            this.PasstextBox2.PasswordChar = '*';
            this.PasstextBox2.Size = new System.Drawing.Size(187, 20);
            this.PasstextBox2.TabIndex = 15;
            // 
            // Pass_confirmtextBox3
            // 
            this.Pass_confirmtextBox3.Location = new System.Drawing.Point(286, 244);
            this.Pass_confirmtextBox3.Name = "Pass_confirmtextBox3";
            this.Pass_confirmtextBox3.PasswordChar = '*';
            this.Pass_confirmtextBox3.Size = new System.Drawing.Size(187, 20);
            this.Pass_confirmtextBox3.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(163, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(157, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "Password Confirm";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button2.Location = new System.Drawing.Point(296, 311);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 44);
            this.button2.TabIndex = 19;
            this.button2.Text = "Save Changes";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // ToDolist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(861, 825);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Pass_confirmtextBox3);
            this.Controls.Add(this.PasstextBox2);
            this.Controls.Add(this.usernametextBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Todolistview);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.editbutton2);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DescriptiontextBox);
            this.Controls.Add(this.titletextBox);
            this.Controls.Add(this.label1);
            this.Name = "ToDolist";
            this.Text = "User Management System";
            this.Load += new System.EventHandler(this.ToDolist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Todolistview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox titletextBox;
        private System.Windows.Forms.TextBox DescriptiontextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button editbutton2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.DataGridView Todolistview;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox usernametextBox1;
        private System.Windows.Forms.TextBox PasstextBox2;
        private System.Windows.Forms.TextBox Pass_confirmtextBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
    }
}

