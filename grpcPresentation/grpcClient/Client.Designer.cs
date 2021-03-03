
namespace grpcClient
{
    partial class Client
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox26 = new System.Windows.Forms.GroupBox();
            this.getAllPlayersButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.day = new System.Windows.Forms.NumericUpDown();
            this.months = new System.Windows.Forms.ComboBox();
            this.year = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addPlayerButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpcPlayerServiceLogOutput = new System.Windows.Forms.TextBox();
            this.redButton = new System.Windows.Forms.Button();
            this.greenButton = new System.Windows.Forms.Button();
            this.yellowButton = new System.Windows.Forms.Button();
            this.orangeButton = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.grpcColorServiceLogOutput = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox26.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.day)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.year)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox26);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Control";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.orangeButton);
            this.groupBox3.Controls.Add(this.yellowButton);
            this.groupBox3.Controls.Add(this.greenButton);
            this.groupBox3.Controls.Add(this.redButton);
            this.groupBox3.Location = new System.Drawing.Point(282, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(224, 301);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Color Game";
            // 
            // groupBox26
            // 
            this.groupBox26.Controls.Add(this.getAllPlayersButton);
            this.groupBox26.Controls.Add(this.groupBox2);
            this.groupBox26.Controls.Add(this.addPlayerButton);
            this.groupBox26.Controls.Add(this.label2);
            this.groupBox26.Controls.Add(this.lastName);
            this.groupBox26.Controls.Add(this.label4);
            this.groupBox26.Controls.Add(this.firstName);
            this.groupBox26.Location = new System.Drawing.Point(19, 18);
            this.groupBox26.Name = "groupBox26";
            this.groupBox26.Size = new System.Drawing.Size(224, 376);
            this.groupBox26.TabIndex = 7;
            this.groupBox26.TabStop = false;
            this.groupBox26.Text = "Add Player";
            // 
            // getAllPlayersButton
            // 
            this.getAllPlayersButton.Location = new System.Drawing.Point(6, 347);
            this.getAllPlayersButton.Name = "getAllPlayersButton";
            this.getAllPlayersButton.Size = new System.Drawing.Size(204, 23);
            this.getAllPlayersButton.TabIndex = 9;
            this.getAllPlayersButton.Text = "Get All Players";
            this.getAllPlayersButton.UseVisualStyleBackColor = true;
            this.getAllPlayersButton.Click += new System.EventHandler(this.getAllPlayersButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.day);
            this.groupBox2.Controls.Add(this.months);
            this.groupBox2.Controls.Add(this.year);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(10, 121);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(208, 173);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Date Of Birth";
            // 
            // day
            // 
            this.day.Location = new System.Drawing.Point(9, 40);
            this.day.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.day.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(193, 20);
            this.day.TabIndex = 2;
            this.day.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // months
            // 
            this.months.FormattingEnabled = true;
            this.months.Location = new System.Drawing.Point(7, 85);
            this.months.Name = "months";
            this.months.Size = new System.Drawing.Size(195, 21);
            this.months.TabIndex = 3;
            // 
            // year
            // 
            this.year.Location = new System.Drawing.Point(9, 134);
            this.year.Maximum = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            this.year.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(193, 20);
            this.year.TabIndex = 4;
            this.year.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Year";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Month";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Day";
            // 
            // addPlayerButton
            // 
            this.addPlayerButton.Location = new System.Drawing.Point(8, 304);
            this.addPlayerButton.Name = "addPlayerButton";
            this.addPlayerButton.Size = new System.Drawing.Size(204, 23);
            this.addPlayerButton.TabIndex = 7;
            this.addPlayerButton.Text = "Add Player";
            this.addPlayerButton.UseVisualStyleBackColor = true;
            this.addPlayerButton.Click += new System.EventHandler(this.addPlayerButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Name";
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(9, 81);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(209, 20);
            this.lastName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "First Name";
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(8, 35);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(209, 20);
            this.firstName.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "gRPC PlayerService Log";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grpcPlayerServiceLogOutput);
            this.groupBox1.Location = new System.Drawing.Point(7, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(755, 387);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "gRPC Log";
            // 
            // grpcPlayerServiceLogOutput
            // 
            this.grpcPlayerServiceLogOutput.Location = new System.Drawing.Point(7, 20);
            this.grpcPlayerServiceLogOutput.Multiline = true;
            this.grpcPlayerServiceLogOutput.Name = "grpcPlayerServiceLogOutput";
            this.grpcPlayerServiceLogOutput.Size = new System.Drawing.Size(742, 348);
            this.grpcPlayerServiceLogOutput.TabIndex = 0;
            // 
            // redButton
            // 
            this.redButton.Location = new System.Drawing.Point(7, 94);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(211, 47);
            this.redButton.TabIndex = 0;
            this.redButton.Text = "Send Red";
            this.redButton.UseVisualStyleBackColor = true;
            this.redButton.Click += new System.EventHandler(this.redButton_Click);
            // 
            // greenButton
            // 
            this.greenButton.Location = new System.Drawing.Point(7, 28);
            this.greenButton.Name = "greenButton";
            this.greenButton.Size = new System.Drawing.Size(211, 47);
            this.greenButton.TabIndex = 1;
            this.greenButton.Text = "Send Green";
            this.greenButton.UseVisualStyleBackColor = true;
            this.greenButton.Click += new System.EventHandler(this.greenButton_Click);
            // 
            // yellowButton
            // 
            this.yellowButton.Location = new System.Drawing.Point(6, 158);
            this.yellowButton.Name = "yellowButton";
            this.yellowButton.Size = new System.Drawing.Size(211, 47);
            this.yellowButton.TabIndex = 2;
            this.yellowButton.Text = "Send Yellow";
            this.yellowButton.UseVisualStyleBackColor = true;
            this.yellowButton.Click += new System.EventHandler(this.yellowButton_Click);
            // 
            // orangeButton
            // 
            this.orangeButton.Location = new System.Drawing.Point(6, 225);
            this.orangeButton.Name = "orangeButton";
            this.orangeButton.Size = new System.Drawing.Size(211, 47);
            this.orangeButton.TabIndex = 3;
            this.orangeButton.Text = "Send Orange";
            this.orangeButton.UseVisualStyleBackColor = true;
            this.orangeButton.Click += new System.EventHandler(this.orangeButton_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(768, 400);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "gRPC ColorService Log";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.grpcColorServiceLogOutput);
            this.groupBox4.Location = new System.Drawing.Point(7, 7);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(755, 387);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "gRPC Log";
            // 
            // grpcColorServiceLogOutput
            // 
            this.grpcColorServiceLogOutput.Location = new System.Drawing.Point(7, 20);
            this.grpcColorServiceLogOutput.Multiline = true;
            this.grpcColorServiceLogOutput.Name = "grpcColorServiceLogOutput";
            this.grpcColorServiceLogOutput.Size = new System.Drawing.Size(742, 348);
            this.grpcColorServiceLogOutput.TabIndex = 0;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Client";
            this.Text = "Client";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox26.ResumeLayout(false);
            this.groupBox26.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.day)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.year)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox26;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown day;
        private System.Windows.Forms.ComboBox months;
        private System.Windows.Forms.NumericUpDown year;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addPlayerButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox grpcPlayerServiceLogOutput;
        private System.Windows.Forms.Button getAllPlayersButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button orangeButton;
        private System.Windows.Forms.Button yellowButton;
        private System.Windows.Forms.Button greenButton;
        private System.Windows.Forms.Button redButton;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox grpcColorServiceLogOutput;
    }
}

