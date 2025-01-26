namespace Autorization
{
    partial class MainPage
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.CloseButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Create_Workout = new System.Windows.Forms.Button();
            this.WorkoutsBox = new System.Windows.Forms.GroupBox();
            this.WorkoutsList = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.WkContent = new System.Windows.Forms.Label();
            this.WkDate = new System.Windows.Forms.Label();
            this.WkType = new System.Windows.Forms.Label();
            this.WorkoutName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.IndianRed;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CloseButton.Location = new System.Drawing.Point(768, 2);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(28, 23);
            this.CloseButton.TabIndex = 11;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(548, 63);
            this.label1.TabIndex = 12;
            this.label1.Text = "Добро пожаловать! ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Create_Workout
            // 
            this.Create_Workout.BackColor = System.Drawing.Color.Gray;
            this.Create_Workout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Create_Workout.ForeColor = System.Drawing.Color.Black;
            this.Create_Workout.Location = new System.Drawing.Point(595, 398);
            this.Create_Workout.Name = "Create_Workout";
            this.Create_Workout.Size = new System.Drawing.Size(160, 72);
            this.Create_Workout.TabIndex = 14;
            this.Create_Workout.Text = "Добавить тренировку";
            this.Create_Workout.UseVisualStyleBackColor = false;
            this.Create_Workout.Click += new System.EventHandler(this.Create_Workout_Click);
            // 
            // WorkoutsBox
            // 
            this.WorkoutsBox.Location = new System.Drawing.Point(23, 111);
            this.WorkoutsBox.Name = "WorkoutsBox";
            this.WorkoutsBox.Size = new System.Drawing.Size(232, 375);
            this.WorkoutsBox.TabIndex = 13;
            this.WorkoutsBox.TabStop = false;
            this.WorkoutsBox.Text = "Ваши тренировки";
            this.WorkoutsBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // WorkoutsList
            // 
            this.WorkoutsList.HideSelection = false;
            this.WorkoutsList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.WorkoutsList.Location = new System.Drawing.Point(24, 156);
            this.WorkoutsList.Name = "WorkoutsList";
            this.WorkoutsList.Size = new System.Drawing.Size(185, 272);
            this.WorkoutsList.TabIndex = 0;
            this.WorkoutsList.UseCompatibleStateImageBehavior = false;
            this.WorkoutsList.View = System.Windows.Forms.View.List;
            this.WorkoutsList.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.WkContent);
            this.panel1.Controls.Add(this.WkDate);
            this.panel1.Controls.Add(this.WkType);
            this.panel1.Controls.Add(this.WorkoutName);
            this.panel1.Location = new System.Drawing.Point(299, 127);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 359);
            this.panel1.TabIndex = 15;
            // 
            // WkContent
            // 
            this.WkContent.AutoSize = true;
            this.WkContent.Location = new System.Drawing.Point(13, 96);
            this.WkContent.Name = "WkContent";
            this.WkContent.Size = new System.Drawing.Size(76, 13);
            this.WkContent.TabIndex = 3;
            this.WkContent.Text = "Содержание: ";
            // 
            // WkDate
            // 
            this.WkDate.AutoSize = true;
            this.WkDate.Location = new System.Drawing.Point(13, 71);
            this.WkDate.Name = "WkDate";
            this.WkDate.Size = new System.Drawing.Size(39, 13);
            this.WkDate.TabIndex = 2;
            this.WkDate.Text = "Дата: ";
            // 
            // WkType
            // 
            this.WkType.AutoSize = true;
            this.WkType.Location = new System.Drawing.Point(13, 45);
            this.WkType.Name = "WkType";
            this.WkType.Size = new System.Drawing.Size(32, 13);
            this.WkType.TabIndex = 1;
            this.WkType.Text = "Тип: ";
            // 
            // WorkoutName
            // 
            this.WorkoutName.AutoSize = true;
            this.WorkoutName.Location = new System.Drawing.Point(13, 20);
            this.WorkoutName.Name = "WorkoutName";
            this.WorkoutName.Size = new System.Drawing.Size(63, 13);
            this.WorkoutName.TabIndex = 0;
            this.WorkoutName.Text = "Название: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(296, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Содержание";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Location = new System.Drawing.Point(673, 33);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(0, 13);
            this.UserName.TabIndex = 17;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(808, 500);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.WorkoutsList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Create_Workout);
            this.Controls.Add(this.WorkoutsBox);
            this.Controls.Add(this.CloseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainPage";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Create_Workout;
        private System.Windows.Forms.GroupBox WorkoutsBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.ListView WorkoutsList;
        private System.Windows.Forms.Label WorkoutName;
        private System.Windows.Forms.Label WkContent;
        private System.Windows.Forms.Label WkDate;
        private System.Windows.Forms.Label WkType;
        internal System.Windows.Forms.Label UserName;
    }
}