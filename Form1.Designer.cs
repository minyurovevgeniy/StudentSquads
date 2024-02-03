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
            tabs = new System.Windows.Forms.TabControl();
            squadsListTabPage = new System.Windows.Forms.TabPage();
            loadStudentSquads = new System.Windows.Forms.Button();
            squadsList = new System.Windows.Forms.ListBox();
            tabPage2 = new System.Windows.Forms.TabPage();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            tabs.SuspendLayout();
            squadsListTabPage.SuspendLayout();
            SuspendLayout();
            // 
            // tabs
            // 
            tabs.Controls.Add(squadsListTabPage);
            tabs.Controls.Add(tabPage2);
            tabs.Location = new System.Drawing.Point(49, 41);
            tabs.Name = "tabs";
            tabs.SelectedIndex = 0;
            tabs.Size = new System.Drawing.Size(489, 352);
            tabs.TabIndex = 0;
            // 
            // squadsListTabPage
            // 
            squadsListTabPage.Controls.Add(loadStudentSquads);
            squadsListTabPage.Controls.Add(squadsList);
            squadsListTabPage.Location = new System.Drawing.Point(4, 34);
            squadsListTabPage.Name = "squadsListTabPage";
            squadsListTabPage.Padding = new System.Windows.Forms.Padding(3);
            squadsListTabPage.Size = new System.Drawing.Size(481, 314);
            squadsListTabPage.TabIndex = 0;
            squadsListTabPage.Text = "Список отрядов";
            squadsListTabPage.UseVisualStyleBackColor = true;
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
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
            // 
            // StudentSquadsForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(tabs);
            Name = "StudentSquadsForm";
            Text = "Form1";
            tabs.ResumeLayout(false);
            squadsListTabPage.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage squadsListTabPage;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox squadsList;
        private System.Windows.Forms.Button loadStudentSquads;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
