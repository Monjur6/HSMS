namespace HSMS
{
    partial class UserProfile
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GridWorkersList = new System.Windows.Forms.DataGridView();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Work_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Working_Hours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtWorkersWorkType = new System.Windows.Forms.TextBox();
            this.txtWorkersName = new System.Windows.Forms.TextBox();
            this.txtWorkersUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridWorkersList)).BeginInit();
            this.SuspendLayout();
            // 
            // GridWorkersList
            // 
            this.GridWorkersList.AllowUserToAddRows = false;
            this.GridWorkersList.AllowUserToDeleteRows = false;
            this.GridWorkersList.AllowUserToResizeRows = false;
            this.GridWorkersList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridWorkersList.BackgroundColor = System.Drawing.Color.Gray;
            this.GridWorkersList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridWorkersList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridWorkersList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridWorkersList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.GridWorkersList.ColumnHeadersHeight = 30;
            this.GridWorkersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.GridWorkersList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Username,
            this.name,
            this.Work_Type,
            this.Working_Hours,
            this.Salary});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridWorkersList.DefaultCellStyle = dataGridViewCellStyle5;
            this.GridWorkersList.EnableHeadersVisualStyles = false;
            this.GridWorkersList.GridColor = System.Drawing.Color.White;
            this.GridWorkersList.Location = new System.Drawing.Point(11, 37);
            this.GridWorkersList.Margin = new System.Windows.Forms.Padding(2);
            this.GridWorkersList.Name = "GridWorkersList";
            this.GridWorkersList.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridWorkersList.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.GridWorkersList.RowHeadersWidth = 51;
            this.GridWorkersList.RowTemplate.Height = 24;
            this.GridWorkersList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridWorkersList.Size = new System.Drawing.Size(507, 384);
            this.GridWorkersList.TabIndex = 23;
            this.GridWorkersList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridWorkersList_CellClick);
            // 
            // Username
            // 
            this.Username.DataPropertyName = "UserName";
            this.Username.HeaderText = "User Name";
            this.Username.MinimumWidth = 6;
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            // 
            // name
            // 
            this.name.DataPropertyName = "Name";
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // Work_Type
            // 
            this.Work_Type.DataPropertyName = "WorkType";
            this.Work_Type.HeaderText = "Work Type";
            this.Work_Type.MinimumWidth = 6;
            this.Work_Type.Name = "Work_Type";
            this.Work_Type.ReadOnly = true;
            // 
            // Working_Hours
            // 
            this.Working_Hours.DataPropertyName = "Workinghours";
            this.Working_Hours.HeaderText = "Working Hours";
            this.Working_Hours.MinimumWidth = 6;
            this.Working_Hours.Name = "Working_Hours";
            this.Working_Hours.ReadOnly = true;
            // 
            // Salary
            // 
            this.Salary.DataPropertyName = "Salary";
            this.Salary.HeaderText = "Salary";
            this.Salary.MinimumWidth = 6;
            this.Salary.Name = "Salary";
            this.Salary.ReadOnly = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(665, 207);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(76, 28);
            this.button3.TabIndex = 22;
            this.button3.Text = "Select";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(760, 11);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 28);
            this.button2.TabIndex = 21;
            this.button2.Text = "Log Out";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtWorkersWorkType
            // 
            this.txtWorkersWorkType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWorkersWorkType.Location = new System.Drawing.Point(665, 144);
            this.txtWorkersWorkType.Margin = new System.Windows.Forms.Padding(2);
            this.txtWorkersWorkType.Name = "txtWorkersWorkType";
            this.txtWorkersWorkType.Size = new System.Drawing.Size(153, 24);
            this.txtWorkersWorkType.TabIndex = 29;
            // 
            // txtWorkersName
            // 
            this.txtWorkersName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWorkersName.Location = new System.Drawing.Point(665, 104);
            this.txtWorkersName.Margin = new System.Windows.Forms.Padding(2);
            this.txtWorkersName.Name = "txtWorkersName";
            this.txtWorkersName.ReadOnly = true;
            this.txtWorkersName.Size = new System.Drawing.Size(153, 24);
            this.txtWorkersName.TabIndex = 28;
            // 
            // txtWorkersUsername
            // 
            this.txtWorkersUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWorkersUsername.Location = new System.Drawing.Point(665, 65);
            this.txtWorkersUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtWorkersUsername.Name = "txtWorkersUsername";
            this.txtWorkersUsername.ReadOnly = true;
            this.txtWorkersUsername.Size = new System.Drawing.Size(153, 24);
            this.txtWorkersUsername.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(522, 144);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 18);
            this.label3.TabIndex = 26;
            this.label3.Text = "Work Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(522, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 18);
            this.label2.TabIndex = 25;
            this.label2.Text = "Workers Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(522, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 18);
            this.label1.TabIndex = 24;
            this.label1.Text = "Workers Username";
            // 
            // UserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(827, 434);
            this.Controls.Add(this.GridWorkersList);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtWorkersWorkType);
            this.Controls.Add(this.txtWorkersName);
            this.Controls.Add(this.txtWorkersUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserProfile";
            this.Load += new System.EventHandler(this.UserProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridWorkersList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridWorkersList;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtWorkersWorkType;
        private System.Windows.Forms.TextBox txtWorkersName;
        private System.Windows.Forms.TextBox txtWorkersUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Work_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Working_Hours;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
    }
}