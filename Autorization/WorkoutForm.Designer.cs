namespace Autorization
{
    partial class WorkoutForm
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
            this.CloseButton = new System.Windows.Forms.Button();
            this.WorkoutName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.WorkoutDate = new System.Windows.Forms.DateTimePicker();
            this.WorkoutType = new System.Windows.Forms.ComboBox();
            this.AddExercise = new System.Windows.Forms.Button();
            this.AddWorkoutContent = new System.Windows.Forms.Button();
            this.Note = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.IndianRed;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CloseButton.Location = new System.Drawing.Point(959, 2);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(28, 23);
            this.CloseButton.TabIndex = 12;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // WorkoutName
            // 
            this.WorkoutName.Location = new System.Drawing.Point(38, 42);
            this.WorkoutName.Name = "WorkoutName";
            this.WorkoutName.Size = new System.Drawing.Size(279, 20);
            this.WorkoutName.TabIndex = 13;
            this.WorkoutName.Text = "Тренировка";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Название тренировки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Тип тренировки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Дата тренировки";
            // 
            // WorkoutDate
            // 
            this.WorkoutDate.Location = new System.Drawing.Point(38, 151);
            this.WorkoutDate.Name = "WorkoutDate";
            this.WorkoutDate.Size = new System.Drawing.Size(159, 20);
            this.WorkoutDate.TabIndex = 19;
            this.WorkoutDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // WorkoutType
            // 
            this.WorkoutType.FormattingEnabled = true;
            this.WorkoutType.Items.AddRange(new object[] {
            "Силовая",
            "Кардио"});
            this.WorkoutType.Location = new System.Drawing.Point(38, 96);
            this.WorkoutType.Name = "WorkoutType";
            this.WorkoutType.Size = new System.Drawing.Size(279, 21);
            this.WorkoutType.TabIndex = 20;
            // 
            // AddExercise
            // 
            this.AddExercise.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddExercise.Location = new System.Drawing.Point(346, 42);
            this.AddExercise.Margin = new System.Windows.Forms.Padding(1);
            this.AddExercise.Name = "AddExercise";
            this.AddExercise.Size = new System.Drawing.Size(39, 38);
            this.AddExercise.TabIndex = 21;
            this.AddExercise.Text = "+";
            this.AddExercise.UseVisualStyleBackColor = true;
            this.AddExercise.Click += new System.EventHandler(this.AddExercise_Click);
            // 
            // AddWorkoutContent
            // 
            this.AddWorkoutContent.Location = new System.Drawing.Point(38, 480);
            this.AddWorkoutContent.Name = "AddWorkoutContent";
            this.AddWorkoutContent.Size = new System.Drawing.Size(172, 23);
            this.AddWorkoutContent.TabIndex = 22;
            this.AddWorkoutContent.Text = "Создать тренировку";
            this.AddWorkoutContent.UseVisualStyleBackColor = true;
            this.AddWorkoutContent.Click += new System.EventHandler(this.AddWorkoutContent_Click);
            // 
            // Note
            // 
            this.Note.AutoSize = true;
            this.Note.ForeColor = System.Drawing.Color.Red;
            this.Note.Location = new System.Drawing.Point(38, 203);
            this.Note.Name = "Note";
            this.Note.Size = new System.Drawing.Size(0, 13);
            this.Note.TabIndex = 23;
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Location = new System.Drawing.Point(922, 48);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(0, 13);
            this.UserName.TabIndex = 24;
            // 
            // WorkoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(999, 595);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.Note);
            this.Controls.Add(this.AddWorkoutContent);
            this.Controls.Add(this.AddExercise);
            this.Controls.Add(this.WorkoutType);
            this.Controls.Add(this.WorkoutDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WorkoutName);
            this.Controls.Add(this.CloseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WorkoutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WorkoutForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.TextBox WorkoutName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker WorkoutDate;
        private System.Windows.Forms.ComboBox WorkoutType;
        private System.Windows.Forms.Button AddExercise;
        private System.Windows.Forms.Button AddWorkoutContent;
        private System.Windows.Forms.Label Note;
        internal System.Windows.Forms.Label UserName;
    }
}