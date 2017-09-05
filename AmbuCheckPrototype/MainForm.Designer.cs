namespace AmbuCheckPrototype
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label_Title = new System.Windows.Forms.Label();
            this.label_Date = new System.Windows.Forms.Label();
            this.label_Time = new System.Windows.Forms.Label();
            this.textBox_Date = new System.Windows.Forms.TextBox();
            this.textBox_Time = new System.Windows.Forms.TextBox();
            this.textBox_Crew2 = new System.Windows.Forms.TextBox();
            this.textBox_Crew1 = new System.Windows.Forms.TextBox();
            this.label_Crew2 = new System.Windows.Forms.Label();
            this.label_Crew1 = new System.Windows.Forms.Label();
            this.label_RigNumber = new System.Windows.Forms.Label();
            this.comboBox_RigNumber = new System.Windows.Forms.ComboBox();
            this.panel_Checklist = new System.Windows.Forms.Panel();
            this.textBox_Notes = new System.Windows.Forms.TextBox();
            this.label_Notes = new System.Windows.Forms.Label();
            this.button_Submit = new System.Windows.Forms.Button();
            this.panel_Sandbox = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_Checklist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mileage:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fuel Level:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(73, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(73, 43);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Exterior clean",
            "Lights/Sirens OK",
            "Tires OK (6)"});
            this.checkedListBox1.Location = new System.Drawing.Point(179, 14);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(158, 49);
            this.checkedListBox1.TabIndex = 5;
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.ColumnWidth = 200;
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Items.AddRange(new object[] {
            "ERG Book",
            "Binder",
            "      Registration*",
            "      Insurance*",
            "      Directions to Hospital",
            "Gate Keys (driver door)",
            "Reflective Coats/Vests (2)",
            "Monroe County Map (1)",
            "Perinton Map (1)",
            "Binoculars (1)"});
            this.checkedListBox2.Location = new System.Drawing.Point(14, 86);
            this.checkedListBox2.MultiColumn = true;
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(627, 79);
            this.checkedListBox2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cab Interior";
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.Location = new System.Drawing.Point(187, 134);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(276, 29);
            this.label_Title.TabIndex = 8;
            this.label_Title.Text = "Ambulance Check Sheet";
            // 
            // label_Date
            // 
            this.label_Date.AutoSize = true;
            this.label_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Date.Location = new System.Drawing.Point(48, 191);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(53, 24);
            this.label_Date.TabIndex = 9;
            this.label_Date.Text = "Date:";
            // 
            // label_Time
            // 
            this.label_Time.AutoSize = true;
            this.label_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Time.Location = new System.Drawing.Point(43, 226);
            this.label_Time.Name = "label_Time";
            this.label_Time.Size = new System.Drawing.Size(58, 24);
            this.label_Time.TabIndex = 10;
            this.label_Time.Text = "Time:";
            // 
            // textBox_Date
            // 
            this.textBox_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Date.Location = new System.Drawing.Point(104, 191);
            this.textBox_Date.Name = "textBox_Date";
            this.textBox_Date.Size = new System.Drawing.Size(116, 29);
            this.textBox_Date.TabIndex = 11;
            // 
            // textBox_Time
            // 
            this.textBox_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Time.Location = new System.Drawing.Point(104, 226);
            this.textBox_Time.Name = "textBox_Time";
            this.textBox_Time.Size = new System.Drawing.Size(116, 29);
            this.textBox_Time.TabIndex = 13;
            // 
            // textBox_Crew2
            // 
            this.textBox_Crew2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Crew2.Location = new System.Drawing.Point(316, 226);
            this.textBox_Crew2.Name = "textBox_Crew2";
            this.textBox_Crew2.Size = new System.Drawing.Size(339, 29);
            this.textBox_Crew2.TabIndex = 17;
            // 
            // textBox_Crew1
            // 
            this.textBox_Crew1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox_Crew1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox_Crew1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Crew1.Location = new System.Drawing.Point(316, 191);
            this.textBox_Crew1.Name = "textBox_Crew1";
            this.textBox_Crew1.Size = new System.Drawing.Size(339, 29);
            this.textBox_Crew1.TabIndex = 16;
            // 
            // label_Crew2
            // 
            this.label_Crew2.AutoSize = true;
            this.label_Crew2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Crew2.Location = new System.Drawing.Point(226, 229);
            this.label_Crew2.Name = "label_Crew2";
            this.label_Crew2.Size = new System.Drawing.Size(84, 24);
            this.label_Crew2.TabIndex = 15;
            this.label_Crew2.Text = "Crew #2:";
            // 
            // label_Crew1
            // 
            this.label_Crew1.AutoSize = true;
            this.label_Crew1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Crew1.Location = new System.Drawing.Point(226, 194);
            this.label_Crew1.Name = "label_Crew1";
            this.label_Crew1.Size = new System.Drawing.Size(84, 24);
            this.label_Crew1.TabIndex = 14;
            this.label_Crew1.Text = "Crew #1:";
            // 
            // label_RigNumber
            // 
            this.label_RigNumber.AutoSize = true;
            this.label_RigNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_RigNumber.Location = new System.Drawing.Point(40, 269);
            this.label_RigNumber.Name = "label_RigNumber";
            this.label_RigNumber.Size = new System.Drawing.Size(58, 24);
            this.label_RigNumber.TabIndex = 18;
            this.label_RigNumber.Text = "Rig #:";
            // 
            // comboBox_RigNumber
            // 
            this.comboBox_RigNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_RigNumber.FormattingEnabled = true;
            this.comboBox_RigNumber.Location = new System.Drawing.Point(104, 261);
            this.comboBox_RigNumber.Name = "comboBox_RigNumber";
            this.comboBox_RigNumber.Size = new System.Drawing.Size(116, 32);
            this.comboBox_RigNumber.TabIndex = 20;
            // 
            // panel_Checklist
            // 
            this.panel_Checklist.AutoScroll = true;
            this.panel_Checklist.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_Checklist.Controls.Add(this.checkedListBox2);
            this.panel_Checklist.Controls.Add(this.label3);
            this.panel_Checklist.Controls.Add(this.checkedListBox1);
            this.panel_Checklist.Controls.Add(this.label1);
            this.panel_Checklist.Controls.Add(this.label2);
            this.panel_Checklist.Controls.Add(this.textBox1);
            this.panel_Checklist.Controls.Add(this.textBox2);
            this.panel_Checklist.Location = new System.Drawing.Point(12, 299);
            this.panel_Checklist.Name = "panel_Checklist";
            this.panel_Checklist.Size = new System.Drawing.Size(669, 197);
            this.panel_Checklist.TabIndex = 21;
            // 
            // textBox_Notes
            // 
            this.textBox_Notes.Location = new System.Drawing.Point(25, 656);
            this.textBox_Notes.Multiline = true;
            this.textBox_Notes.Name = "textBox_Notes";
            this.textBox_Notes.Size = new System.Drawing.Size(627, 104);
            this.textBox_Notes.TabIndex = 22;
            // 
            // label_Notes
            // 
            this.label_Notes.AutoSize = true;
            this.label_Notes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Notes.Location = new System.Drawing.Point(21, 629);
            this.label_Notes.Name = "label_Notes";
            this.label_Notes.Size = new System.Drawing.Size(64, 24);
            this.label_Notes.TabIndex = 23;
            this.label_Notes.Text = "Notes:";
            // 
            // button_Submit
            // 
            this.button_Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Submit.Location = new System.Drawing.Point(25, 771);
            this.button_Submit.Name = "button_Submit";
            this.button_Submit.Size = new System.Drawing.Size(627, 37);
            this.button_Submit.TabIndex = 24;
            this.button_Submit.Text = "SUBMIT";
            this.button_Submit.UseVisualStyleBackColor = true;
            this.button_Submit.Click += new System.EventHandler(this.button_Submit_Click);
            // 
            // panel_Sandbox
            // 
            this.panel_Sandbox.AutoScroll = true;
            this.panel_Sandbox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_Sandbox.Location = new System.Drawing.Point(12, 502);
            this.panel_Sandbox.Name = "panel_Sandbox";
            this.panel_Sandbox.Size = new System.Drawing.Size(669, 124);
            this.panel_Sandbox.TabIndex = 22;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AmbuCheckPrototype.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(130, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(404, 119);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 820);
            this.Controls.Add(this.panel_Sandbox);
            this.Controls.Add(this.button_Submit);
            this.Controls.Add(this.label_Notes);
            this.Controls.Add(this.textBox_Notes);
            this.Controls.Add(this.panel_Checklist);
            this.Controls.Add(this.comboBox_RigNumber);
            this.Controls.Add(this.label_RigNumber);
            this.Controls.Add(this.textBox_Crew2);
            this.Controls.Add(this.textBox_Crew1);
            this.Controls.Add(this.label_Crew2);
            this.Controls.Add(this.label_Crew1);
            this.Controls.Add(this.textBox_Time);
            this.Controls.Add(this.textBox_Date);
            this.Controls.Add(this.label_Time);
            this.Controls.Add(this.label_Date);
            this.Controls.Add(this.label_Title);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "AmbuCheck Prototype";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_Checklist.ResumeLayout(false);
            this.panel_Checklist.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Label label_Date;
        private System.Windows.Forms.Label label_Time;
        private System.Windows.Forms.TextBox textBox_Date;
        private System.Windows.Forms.TextBox textBox_Time;
        private System.Windows.Forms.TextBox textBox_Crew2;
        private System.Windows.Forms.TextBox textBox_Crew1;
        private System.Windows.Forms.Label label_Crew2;
        private System.Windows.Forms.Label label_Crew1;
        private System.Windows.Forms.Label label_RigNumber;
        private System.Windows.Forms.ComboBox comboBox_RigNumber;
        private System.Windows.Forms.Panel panel_Checklist;
        private System.Windows.Forms.TextBox textBox_Notes;
        private System.Windows.Forms.Label label_Notes;
        private System.Windows.Forms.Button button_Submit;
        private System.Windows.Forms.Panel panel_Sandbox;
    }
}

