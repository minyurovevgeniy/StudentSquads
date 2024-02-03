namespace StudentSquads
{
    partial class StudentSquadsForm
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
            tabControl1 = new System.Windows.Forms.TabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
            loadStudentSquads = new System.Windows.Forms.Button();
            squadsList = new System.Windows.Forms.ListBox();
            tabPage2 = new System.Windows.Forms.TabPage();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new System.Drawing.Point(49, 41);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(489, 352);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(loadStudentSquads);
            tabPage1.Controls.Add(squadsList);
            tabPage1.Location = new System.Drawing.Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(481, 314);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // loadStudentSquads
            // 
            loadStudentSquads.Location = new System.Drawing.Point(159, 221);
            loadStudentSquads.Name = "loadStudentSquads";
            loadStudentSquads.Size = new System.Drawing.Size(188, 34);
            loadStudentSquads.TabIndex = 1;
            loadStudentSquads.Text = "loadStudentSquads";
            loadStudentSquads.UseVisualStyleBackColor = true;
            loadStudentSquads.Click += loadStudentSquads_Click;
            // 
            // squadsList
            // 
            squadsList.FormattingEnabled = true;
            squadsList.ItemHeight = 25;
            squadsList.Location = new System.Drawing.Point(6, 6);
            squadsList.Name = "squadsList";
            squadsList.Size = new System.Drawing.Size(469, 129);
            squadsList.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Location = new System.Drawing.Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(3);
            tabPage2.Size = new System.Drawing.Size(481, 314);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // backgroundWorker1
            // 
            
            // 
            // StudentSquadsForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(tabControl1);
            Name = "StudentSquadsForm";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox squadsList;
        private System.Windows.Forms.Button loadStudentSquads;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
