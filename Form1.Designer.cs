namespace SuccessScreenBuilder
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
            this.customBar1 = new SuccessScreenBuilder.UI.CustomBar();
            this.hookingFilesPanel = new System.Windows.Forms.Panel();
            this.gettingFilesStatusBar = new SuccessScreenBuilder.UI.Bar();
            this.label1 = new System.Windows.Forms.Label();
            this.DJSuccessPanelShow = new System.Windows.Forms.Panel();
            this.selectDjsPanel = new System.Windows.Forms.Panel();
            this.select4Button = new SuccessScreenBuilder.UI.CustomButton();
            this.select3Button = new SuccessScreenBuilder.UI.CustomButton();
            this.select2Button = new SuccessScreenBuilder.UI.CustomButton();
            this.select1Button = new SuccessScreenBuilder.UI.CustomButton();
            this.select0Button = new SuccessScreenBuilder.UI.CustomButton();
            this.exportationButton = new SuccessScreenBuilder.UI.CustomButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backScreenColor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.hookingFilesPanel.SuspendLayout();
            this.selectDjsPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // customBar1
            // 
            this.customBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.customBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.customBar1.HasClose = true;
            this.customBar1.HasMinimize = true;
            this.customBar1.Location = new System.Drawing.Point(0, 0);
            this.customBar1.Margin = new System.Windows.Forms.Padding(4);
            this.customBar1.Name = "customBar1";
            this.customBar1.Size = new System.Drawing.Size(1035, 31);
            this.customBar1.TabIndex = 0;
            // 
            // hookingFilesPanel
            // 
            this.hookingFilesPanel.Controls.Add(this.gettingFilesStatusBar);
            this.hookingFilesPanel.Controls.Add(this.label1);
            this.hookingFilesPanel.Location = new System.Drawing.Point(0, 459);
            this.hookingFilesPanel.Name = "hookingFilesPanel";
            this.hookingFilesPanel.Size = new System.Drawing.Size(1018, 45);
            this.hookingFilesPanel.TabIndex = 3;
            // 
            // gettingFilesStatusBar
            // 
            this.gettingFilesStatusBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.gettingFilesStatusBar.BarColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.gettingFilesStatusBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gettingFilesStatusBar.Location = new System.Drawing.Point(0, 25);
            this.gettingFilesStatusBar.MaxValue = 100;
            this.gettingFilesStatusBar.MinValue = 0;
            this.gettingFilesStatusBar.Name = "gettingFilesStatusBar";
            this.gettingFilesStatusBar.Size = new System.Drawing.Size(1018, 20);
            this.gettingFilesStatusBar.TabIndex = 1;
            this.gettingFilesStatusBar.Value = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1018, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Récupération des screens :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DJSuccessPanelShow
            // 
            this.DJSuccessPanelShow.AutoScroll = true;
            this.DJSuccessPanelShow.Location = new System.Drawing.Point(309, 35);
            this.DJSuccessPanelShow.Name = "DJSuccessPanelShow";
            this.DJSuccessPanelShow.Size = new System.Drawing.Size(709, 418);
            this.DJSuccessPanelShow.TabIndex = 4;
            // 
            // selectDjsPanel
            // 
            this.selectDjsPanel.Controls.Add(this.select4Button);
            this.selectDjsPanel.Controls.Add(this.select3Button);
            this.selectDjsPanel.Controls.Add(this.select2Button);
            this.selectDjsPanel.Controls.Add(this.select1Button);
            this.selectDjsPanel.Controls.Add(this.select0Button);
            this.selectDjsPanel.Location = new System.Drawing.Point(5, 35);
            this.selectDjsPanel.Name = "selectDjsPanel";
            this.selectDjsPanel.Size = new System.Drawing.Size(291, 201);
            this.selectDjsPanel.TabIndex = 5;
            this.selectDjsPanel.Visible = false;
            // 
            // select4Button
            // 
            this.select4Button.Align = SuccessScreenBuilder.UI.CustomButton.Alignement.None;
            this.select4Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.select4Button.Corner = "5;5";
            this.select4Button.FlatAppearance.BorderSize = 0;
            this.select4Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.select4Button.Location = new System.Drawing.Point(19, 162);
            this.select4Button.Name = "select4Button";
            this.select4Button.Opacity = "100%";
            this.select4Button.Size = new System.Drawing.Size(254, 31);
            this.select4Button.TabIndex = 12;
            this.select4Button.Text = "Donjon 191 - 200";
            this.select4Button.UseVisualStyleBackColor = false;
            this.select4Button.Click += new System.EventHandler(this.select4Button_Click);
            // 
            // select3Button
            // 
            this.select3Button.Align = SuccessScreenBuilder.UI.CustomButton.Alignement.None;
            this.select3Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.select3Button.Corner = "5;5";
            this.select3Button.FlatAppearance.BorderSize = 0;
            this.select3Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.select3Button.Location = new System.Drawing.Point(19, 125);
            this.select3Button.Name = "select3Button";
            this.select3Button.Opacity = "100%";
            this.select3Button.Size = new System.Drawing.Size(254, 31);
            this.select3Button.TabIndex = 11;
            this.select3Button.Text = "Donjon 151 - 190";
            this.select3Button.UseVisualStyleBackColor = false;
            this.select3Button.Click += new System.EventHandler(this.select3Button_Click);
            // 
            // select2Button
            // 
            this.select2Button.Align = SuccessScreenBuilder.UI.CustomButton.Alignement.None;
            this.select2Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.select2Button.Corner = "5;5";
            this.select2Button.FlatAppearance.BorderSize = 0;
            this.select2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.select2Button.Location = new System.Drawing.Point(19, 88);
            this.select2Button.Name = "select2Button";
            this.select2Button.Opacity = "100%";
            this.select2Button.Size = new System.Drawing.Size(254, 31);
            this.select2Button.TabIndex = 10;
            this.select2Button.Text = "Donjon 101 - 150";
            this.select2Button.UseVisualStyleBackColor = false;
            this.select2Button.Click += new System.EventHandler(this.select2Button_Click);
            // 
            // select1Button
            // 
            this.select1Button.Align = SuccessScreenBuilder.UI.CustomButton.Alignement.None;
            this.select1Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.select1Button.Corner = "5;5";
            this.select1Button.FlatAppearance.BorderSize = 0;
            this.select1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.select1Button.Location = new System.Drawing.Point(19, 51);
            this.select1Button.Name = "select1Button";
            this.select1Button.Opacity = "100%";
            this.select1Button.Size = new System.Drawing.Size(254, 31);
            this.select1Button.TabIndex = 9;
            this.select1Button.Text = "Donjon 51 - 100";
            this.select1Button.UseVisualStyleBackColor = false;
            this.select1Button.Click += new System.EventHandler(this.select1Button_Click);
            // 
            // select0Button
            // 
            this.select0Button.Align = SuccessScreenBuilder.UI.CustomButton.Alignement.None;
            this.select0Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.select0Button.Corner = "5;5";
            this.select0Button.FlatAppearance.BorderSize = 0;
            this.select0Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.select0Button.Location = new System.Drawing.Point(19, 14);
            this.select0Button.Name = "select0Button";
            this.select0Button.Opacity = "100%";
            this.select0Button.Size = new System.Drawing.Size(254, 31);
            this.select0Button.TabIndex = 8;
            this.select0Button.Text = "Donjon 1 à 50";
            this.select0Button.UseVisualStyleBackColor = false;
            this.select0Button.Click += new System.EventHandler(this.select0Button_Click);
            // 
            // exportationButton
            // 
            this.exportationButton.Align = SuccessScreenBuilder.UI.CustomButton.Alignement.None;
            this.exportationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.exportationButton.Corner = "5;5";
            this.exportationButton.FlatAppearance.BorderSize = 0;
            this.exportationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportationButton.Location = new System.Drawing.Point(24, 129);
            this.exportationButton.Name = "exportationButton";
            this.exportationButton.Opacity = "100%";
            this.exportationButton.Size = new System.Drawing.Size(242, 31);
            this.exportationButton.TabIndex = 7;
            this.exportationButton.Text = "Exporter";
            this.exportationButton.UseVisualStyleBackColor = false;
            this.exportationButton.Click += new System.EventHandler(this.exportationButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.backScreenColor);
            this.groupBox1.Controls.Add(this.exportationButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 242);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 171);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gestion du screen final";
            this.groupBox1.Visible = false;
            // 
            // backScreenColor
            // 
            this.backScreenColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.backScreenColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.backScreenColor.Location = new System.Drawing.Point(151, 25);
            this.backScreenColor.Name = "backScreenColor";
            this.backScreenColor.Size = new System.Drawing.Size(115, 26);
            this.backScreenColor.TabIndex = 1;
            this.backScreenColor.Text = "#3e3f40";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Couleur de fond : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nombre de succès par colonne";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(35, 92);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(218, 26);
            this.numericUpDown1.TabIndex = 9;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(1035, 511);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.selectDjsPanel);
            this.Controls.Add(this.DJSuccessPanelShow);
            this.Controls.Add(this.hookingFilesPanel);
            this.Controls.Add(this.customBar1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SucessScreen";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.hookingFilesPanel.ResumeLayout(false);
            this.selectDjsPanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UI.CustomBar customBar1;
        private Panel hookingFilesPanel;
        private Label label1;
        public UI.Bar gettingFilesStatusBar;
        private Panel DJSuccessPanelShow;
        private UI.CustomButton exportationButton;
        private UI.CustomButton select4Button;
        private UI.CustomButton select3Button;
        private UI.CustomButton select2Button;
        private UI.CustomButton select1Button;
        private UI.CustomButton select0Button;
        public Panel selectDjsPanel;
        private GroupBox groupBox1;
        private TextBox backScreenColor;
        private Label label2;
        private Label label3;
        private NumericUpDown numericUpDown1;
    }
}