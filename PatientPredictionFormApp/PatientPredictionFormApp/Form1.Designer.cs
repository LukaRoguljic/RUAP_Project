namespace PatientPredictionFormApp
{
    partial class Form1
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
            this.ageBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioBtnFemale = new System.Windows.Forms.RadioButton();
            this.radioBtnMale = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbSun = new System.Windows.Forms.RadioButton();
            this.rbSat = new System.Windows.Forms.RadioButton();
            this.rbFri = new System.Windows.Forms.RadioButton();
            this.rbThur = new System.Windows.Forms.RadioButton();
            this.rbWed = new System.Windows.Forms.RadioButton();
            this.rbTue = new System.Windows.Forms.RadioButton();
            this.rbMon = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbDiaYes = new System.Windows.Forms.RadioButton();
            this.rbDiaNo = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbAlcYes = new System.Windows.Forms.RadioButton();
            this.rbAlcNo = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rbHipYes = new System.Windows.Forms.RadioButton();
            this.rbHipNo = new System.Windows.Forms.RadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.rbHanCapFour = new System.Windows.Forms.RadioButton();
            this.rbHanCapThree = new System.Windows.Forms.RadioButton();
            this.rbHanCapTwo = new System.Windows.Forms.RadioButton();
            this.rbHanCapOne = new System.Windows.Forms.RadioButton();
            this.rbHanCapZero = new System.Windows.Forms.RadioButton();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.rbSmoYes = new System.Windows.Forms.RadioButton();
            this.rbSmoNo = new System.Windows.Forms.RadioButton();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.rbSchYes = new System.Windows.Forms.RadioButton();
            this.rbSchNo = new System.Windows.Forms.RadioButton();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.rbTbcYes = new System.Windows.Forms.RadioButton();
            this.rbTbcNo = new System.Windows.Forms.RadioButton();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.rbSmsTwo = new System.Windows.Forms.RadioButton();
            this.rbSmsOne = new System.Windows.Forms.RadioButton();
            this.rbSmsZero = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.awaitBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(64, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "PATIENT SHOW UP PREDICTION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "AGE:";
            // 
            // ageBox
            // 
            this.ageBox.Location = new System.Drawing.Point(114, 51);
            this.ageBox.Name = "ageBox";
            this.ageBox.Size = new System.Drawing.Size(42, 20);
            this.ageBox.TabIndex = 2;
            this.ageBox.Text = "25";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioBtnFemale);
            this.groupBox1.Controls.Add(this.radioBtnMale);
            this.groupBox1.Location = new System.Drawing.Point(12, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(144, 45);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GENDER";
            // 
            // radioBtnFemale
            // 
            this.radioBtnFemale.AutoSize = true;
            this.radioBtnFemale.Location = new System.Drawing.Point(70, 19);
            this.radioBtnFemale.Name = "radioBtnFemale";
            this.radioBtnFemale.Size = new System.Drawing.Size(67, 17);
            this.radioBtnFemale.TabIndex = 1;
            this.radioBtnFemale.Text = "FEMALE";
            this.radioBtnFemale.UseVisualStyleBackColor = true;
            // 
            // radioBtnMale
            // 
            this.radioBtnMale.AutoSize = true;
            this.radioBtnMale.Checked = true;
            this.radioBtnMale.Location = new System.Drawing.Point(10, 19);
            this.radioBtnMale.Name = "radioBtnMale";
            this.radioBtnMale.Size = new System.Drawing.Size(54, 17);
            this.radioBtnMale.TabIndex = 0;
            this.radioBtnMale.TabStop = true;
            this.radioBtnMale.Text = "MALE";
            this.radioBtnMale.UseVisualStyleBackColor = true;
            this.radioBtnMale.CheckedChanged += new System.EventHandler(this.radioBtnMale_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbSun);
            this.groupBox2.Controls.Add(this.rbSat);
            this.groupBox2.Controls.Add(this.rbFri);
            this.groupBox2.Controls.Add(this.rbThur);
            this.groupBox2.Controls.Add(this.rbWed);
            this.groupBox2.Controls.Add(this.rbTue);
            this.groupBox2.Controls.Add(this.rbMon);
            this.groupBox2.Location = new System.Drawing.Point(12, 138);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(409, 83);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DAY OF THE WEEK";
            // 
            // rbSun
            // 
            this.rbSun.AutoSize = true;
            this.rbSun.Location = new System.Drawing.Point(269, 60);
            this.rbSun.Name = "rbSun";
            this.rbSun.Size = new System.Drawing.Size(61, 17);
            this.rbSun.TabIndex = 6;
            this.rbSun.Text = "Sunday";
            this.rbSun.UseVisualStyleBackColor = true;
            // 
            // rbSat
            // 
            this.rbSat.AutoSize = true;
            this.rbSat.Location = new System.Drawing.Point(159, 60);
            this.rbSat.Name = "rbSat";
            this.rbSat.Size = new System.Drawing.Size(67, 17);
            this.rbSat.TabIndex = 5;
            this.rbSat.Text = "Saturday";
            this.rbSat.UseVisualStyleBackColor = true;
            // 
            // rbFri
            // 
            this.rbFri.AutoSize = true;
            this.rbFri.Location = new System.Drawing.Point(56, 60);
            this.rbFri.Name = "rbFri";
            this.rbFri.Size = new System.Drawing.Size(53, 17);
            this.rbFri.TabIndex = 4;
            this.rbFri.Text = "Friday";
            this.rbFri.UseVisualStyleBackColor = true;
            // 
            // rbThur
            // 
            this.rbThur.AutoSize = true;
            this.rbThur.Location = new System.Drawing.Point(318, 20);
            this.rbThur.Name = "rbThur";
            this.rbThur.Size = new System.Drawing.Size(69, 17);
            this.rbThur.TabIndex = 3;
            this.rbThur.Text = "Thursday";
            this.rbThur.UseVisualStyleBackColor = true;
            // 
            // rbWed
            // 
            this.rbWed.AutoSize = true;
            this.rbWed.Location = new System.Drawing.Point(211, 20);
            this.rbWed.Name = "rbWed";
            this.rbWed.Size = new System.Drawing.Size(82, 17);
            this.rbWed.TabIndex = 2;
            this.rbWed.Text = "Wednesday";
            this.rbWed.UseVisualStyleBackColor = true;
            // 
            // rbTue
            // 
            this.rbTue.AutoSize = true;
            this.rbTue.Location = new System.Drawing.Point(108, 20);
            this.rbTue.Name = "rbTue";
            this.rbTue.Size = new System.Drawing.Size(66, 17);
            this.rbTue.TabIndex = 1;
            this.rbTue.Text = "Tuesday";
            this.rbTue.UseVisualStyleBackColor = true;
            // 
            // rbMon
            // 
            this.rbMon.AutoSize = true;
            this.rbMon.Checked = true;
            this.rbMon.Location = new System.Drawing.Point(10, 20);
            this.rbMon.Name = "rbMon";
            this.rbMon.Size = new System.Drawing.Size(63, 17);
            this.rbMon.TabIndex = 0;
            this.rbMon.TabStop = true;
            this.rbMon.Text = "Monday";
            this.rbMon.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbDiaYes);
            this.groupBox3.Controls.Add(this.rbDiaNo);
            this.groupBox3.Location = new System.Drawing.Point(12, 228);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(204, 45);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DIABETES";
            // 
            // rbDiaYes
            // 
            this.rbDiaYes.AutoSize = true;
            this.rbDiaYes.Location = new System.Drawing.Point(113, 19);
            this.rbDiaYes.Name = "rbDiaYes";
            this.rbDiaYes.Size = new System.Drawing.Size(43, 17);
            this.rbDiaYes.TabIndex = 2;
            this.rbDiaYes.Text = "Yes";
            this.rbDiaYes.UseVisualStyleBackColor = true;
            // 
            // rbDiaNo
            // 
            this.rbDiaNo.AutoSize = true;
            this.rbDiaNo.Checked = true;
            this.rbDiaNo.Location = new System.Drawing.Point(6, 19);
            this.rbDiaNo.Name = "rbDiaNo";
            this.rbDiaNo.Size = new System.Drawing.Size(39, 17);
            this.rbDiaNo.TabIndex = 1;
            this.rbDiaNo.TabStop = true;
            this.rbDiaNo.Text = "No";
            this.rbDiaNo.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbAlcYes);
            this.groupBox4.Controls.Add(this.rbAlcNo);
            this.groupBox4.Location = new System.Drawing.Point(12, 279);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(204, 45);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "ALCOHOLISM";
            // 
            // rbAlcYes
            // 
            this.rbAlcYes.AutoSize = true;
            this.rbAlcYes.Location = new System.Drawing.Point(113, 19);
            this.rbAlcYes.Name = "rbAlcYes";
            this.rbAlcYes.Size = new System.Drawing.Size(43, 17);
            this.rbAlcYes.TabIndex = 2;
            this.rbAlcYes.Text = "Yes";
            this.rbAlcYes.UseVisualStyleBackColor = true;
            // 
            // rbAlcNo
            // 
            this.rbAlcNo.AutoSize = true;
            this.rbAlcNo.Checked = true;
            this.rbAlcNo.Location = new System.Drawing.Point(6, 19);
            this.rbAlcNo.Name = "rbAlcNo";
            this.rbAlcNo.Size = new System.Drawing.Size(39, 17);
            this.rbAlcNo.TabIndex = 1;
            this.rbAlcNo.TabStop = true;
            this.rbAlcNo.Text = "No";
            this.rbAlcNo.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rbHipYes);
            this.groupBox5.Controls.Add(this.rbHipNo);
            this.groupBox5.Location = new System.Drawing.Point(12, 330);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(204, 45);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "HIPERTENSION";
            // 
            // rbHipYes
            // 
            this.rbHipYes.AutoSize = true;
            this.rbHipYes.Location = new System.Drawing.Point(113, 19);
            this.rbHipYes.Name = "rbHipYes";
            this.rbHipYes.Size = new System.Drawing.Size(43, 17);
            this.rbHipYes.TabIndex = 2;
            this.rbHipYes.Text = "Yes";
            this.rbHipYes.UseVisualStyleBackColor = true;
            // 
            // rbHipNo
            // 
            this.rbHipNo.AutoSize = true;
            this.rbHipNo.Checked = true;
            this.rbHipNo.Location = new System.Drawing.Point(6, 19);
            this.rbHipNo.Name = "rbHipNo";
            this.rbHipNo.Size = new System.Drawing.Size(39, 17);
            this.rbHipNo.TabIndex = 1;
            this.rbHipNo.TabStop = true;
            this.rbHipNo.Text = "No";
            this.rbHipNo.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.rbHanCapFour);
            this.groupBox6.Controls.Add(this.rbHanCapThree);
            this.groupBox6.Controls.Add(this.rbHanCapTwo);
            this.groupBox6.Controls.Add(this.rbHanCapOne);
            this.groupBox6.Controls.Add(this.rbHanCapZero);
            this.groupBox6.Location = new System.Drawing.Point(12, 381);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(275, 45);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "HANDICAP LEVEL";
            // 
            // rbHanCapFour
            // 
            this.rbHanCapFour.AutoSize = true;
            this.rbHanCapFour.Location = new System.Drawing.Point(221, 19);
            this.rbHanCapFour.Name = "rbHanCapFour";
            this.rbHanCapFour.Size = new System.Drawing.Size(46, 17);
            this.rbHanCapFour.TabIndex = 5;
            this.rbHanCapFour.Text = "Four";
            this.rbHanCapFour.UseVisualStyleBackColor = true;
            // 
            // rbHanCapThree
            // 
            this.rbHanCapThree.AutoSize = true;
            this.rbHanCapThree.Location = new System.Drawing.Point(162, 19);
            this.rbHanCapThree.Name = "rbHanCapThree";
            this.rbHanCapThree.Size = new System.Drawing.Size(53, 17);
            this.rbHanCapThree.TabIndex = 4;
            this.rbHanCapThree.Text = "Three";
            this.rbHanCapThree.UseVisualStyleBackColor = true;
            // 
            // rbHanCapTwo
            // 
            this.rbHanCapTwo.AutoSize = true;
            this.rbHanCapTwo.Location = new System.Drawing.Point(110, 19);
            this.rbHanCapTwo.Name = "rbHanCapTwo";
            this.rbHanCapTwo.Size = new System.Drawing.Size(46, 17);
            this.rbHanCapTwo.TabIndex = 3;
            this.rbHanCapTwo.Text = "Two";
            this.rbHanCapTwo.UseVisualStyleBackColor = true;
            // 
            // rbHanCapOne
            // 
            this.rbHanCapOne.AutoSize = true;
            this.rbHanCapOne.Location = new System.Drawing.Point(59, 19);
            this.rbHanCapOne.Name = "rbHanCapOne";
            this.rbHanCapOne.Size = new System.Drawing.Size(45, 17);
            this.rbHanCapOne.TabIndex = 2;
            this.rbHanCapOne.Text = "One";
            this.rbHanCapOne.UseVisualStyleBackColor = true;
            // 
            // rbHanCapZero
            // 
            this.rbHanCapZero.AutoSize = true;
            this.rbHanCapZero.Checked = true;
            this.rbHanCapZero.Location = new System.Drawing.Point(6, 19);
            this.rbHanCapZero.Name = "rbHanCapZero";
            this.rbHanCapZero.Size = new System.Drawing.Size(47, 17);
            this.rbHanCapZero.TabIndex = 1;
            this.rbHanCapZero.TabStop = true;
            this.rbHanCapZero.Text = "Zero";
            this.rbHanCapZero.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.rbSmoYes);
            this.groupBox7.Controls.Add(this.rbSmoNo);
            this.groupBox7.Location = new System.Drawing.Point(12, 432);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(204, 45);
            this.groupBox7.TabIndex = 9;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "SMOKING";
            // 
            // rbSmoYes
            // 
            this.rbSmoYes.AutoSize = true;
            this.rbSmoYes.Location = new System.Drawing.Point(113, 19);
            this.rbSmoYes.Name = "rbSmoYes";
            this.rbSmoYes.Size = new System.Drawing.Size(43, 17);
            this.rbSmoYes.TabIndex = 2;
            this.rbSmoYes.Text = "Yes";
            this.rbSmoYes.UseVisualStyleBackColor = true;
            // 
            // rbSmoNo
            // 
            this.rbSmoNo.AutoSize = true;
            this.rbSmoNo.Checked = true;
            this.rbSmoNo.Location = new System.Drawing.Point(6, 19);
            this.rbSmoNo.Name = "rbSmoNo";
            this.rbSmoNo.Size = new System.Drawing.Size(39, 17);
            this.rbSmoNo.TabIndex = 1;
            this.rbSmoNo.TabStop = true;
            this.rbSmoNo.Text = "No";
            this.rbSmoNo.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.rbSchYes);
            this.groupBox8.Controls.Add(this.rbSchNo);
            this.groupBox8.Location = new System.Drawing.Point(12, 483);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(204, 45);
            this.groupBox8.TabIndex = 10;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "SCHOLARSHIP";
            // 
            // rbSchYes
            // 
            this.rbSchYes.AutoSize = true;
            this.rbSchYes.Location = new System.Drawing.Point(113, 19);
            this.rbSchYes.Name = "rbSchYes";
            this.rbSchYes.Size = new System.Drawing.Size(43, 17);
            this.rbSchYes.TabIndex = 2;
            this.rbSchYes.Text = "Yes";
            this.rbSchYes.UseVisualStyleBackColor = true;
            // 
            // rbSchNo
            // 
            this.rbSchNo.AutoSize = true;
            this.rbSchNo.Checked = true;
            this.rbSchNo.Location = new System.Drawing.Point(6, 19);
            this.rbSchNo.Name = "rbSchNo";
            this.rbSchNo.Size = new System.Drawing.Size(39, 17);
            this.rbSchNo.TabIndex = 1;
            this.rbSchNo.TabStop = true;
            this.rbSchNo.Text = "No";
            this.rbSchNo.UseVisualStyleBackColor = true;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.rbTbcYes);
            this.groupBox9.Controls.Add(this.rbTbcNo);
            this.groupBox9.Location = new System.Drawing.Point(12, 534);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(204, 45);
            this.groupBox9.TabIndex = 11;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "TUBERCULOSIS";
            // 
            // rbTbcYes
            // 
            this.rbTbcYes.AutoSize = true;
            this.rbTbcYes.Location = new System.Drawing.Point(113, 19);
            this.rbTbcYes.Name = "rbTbcYes";
            this.rbTbcYes.Size = new System.Drawing.Size(43, 17);
            this.rbTbcYes.TabIndex = 2;
            this.rbTbcYes.Text = "Yes";
            this.rbTbcYes.UseVisualStyleBackColor = true;
            // 
            // rbTbcNo
            // 
            this.rbTbcNo.AutoSize = true;
            this.rbTbcNo.Checked = true;
            this.rbTbcNo.Location = new System.Drawing.Point(6, 19);
            this.rbTbcNo.Name = "rbTbcNo";
            this.rbTbcNo.Size = new System.Drawing.Size(39, 17);
            this.rbTbcNo.TabIndex = 1;
            this.rbTbcNo.TabStop = true;
            this.rbTbcNo.Text = "No";
            this.rbTbcNo.UseVisualStyleBackColor = true;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.rbSmsTwo);
            this.groupBox10.Controls.Add(this.rbSmsOne);
            this.groupBox10.Controls.Add(this.rbSmsZero);
            this.groupBox10.Location = new System.Drawing.Point(12, 585);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(204, 39);
            this.groupBox10.TabIndex = 12;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "NUMBER OF SMS REMINDERS";
            // 
            // rbSmsTwo
            // 
            this.rbSmsTwo.AutoSize = true;
            this.rbSmsTwo.Location = new System.Drawing.Point(80, 19);
            this.rbSmsTwo.Name = "rbSmsTwo";
            this.rbSmsTwo.Size = new System.Drawing.Size(31, 17);
            this.rbSmsTwo.TabIndex = 3;
            this.rbSmsTwo.Text = "2";
            this.rbSmsTwo.UseVisualStyleBackColor = true;
            // 
            // rbSmsOne
            // 
            this.rbSmsOne.AutoSize = true;
            this.rbSmsOne.Location = new System.Drawing.Point(43, 17);
            this.rbSmsOne.Name = "rbSmsOne";
            this.rbSmsOne.Size = new System.Drawing.Size(31, 17);
            this.rbSmsOne.TabIndex = 2;
            this.rbSmsOne.Text = "1";
            this.rbSmsOne.UseVisualStyleBackColor = true;
            // 
            // rbSmsZero
            // 
            this.rbSmsZero.AutoSize = true;
            this.rbSmsZero.Checked = true;
            this.rbSmsZero.Location = new System.Drawing.Point(6, 19);
            this.rbSmsZero.Name = "rbSmsZero";
            this.rbSmsZero.Size = new System.Drawing.Size(31, 17);
            this.rbSmsZero.TabIndex = 1;
            this.rbSmsZero.TabStop = true;
            this.rbSmsZero.Text = "0";
            this.rbSmsZero.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "AWAITING TIME:";
            // 
            // awaitBox
            // 
            this.awaitBox.Location = new System.Drawing.Point(342, 51);
            this.awaitBox.Name = "awaitBox";
            this.awaitBox.Size = new System.Drawing.Size(42, 20);
            this.awaitBox.TabIndex = 14;
            this.awaitBox.Text = "-20";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(269, 585);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 39);
            this.button1.TabIndex = 15;
            this.button1.Text = "PREDICT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 633);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.awaitBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ageBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ageBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioBtnFemale;
        private System.Windows.Forms.RadioButton radioBtnMale;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbSun;
        private System.Windows.Forms.RadioButton rbSat;
        private System.Windows.Forms.RadioButton rbFri;
        private System.Windows.Forms.RadioButton rbThur;
        private System.Windows.Forms.RadioButton rbWed;
        private System.Windows.Forms.RadioButton rbTue;
        private System.Windows.Forms.RadioButton rbMon;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbDiaYes;
        private System.Windows.Forms.RadioButton rbDiaNo;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbAlcYes;
        private System.Windows.Forms.RadioButton rbAlcNo;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rbHipYes;
        private System.Windows.Forms.RadioButton rbHipNo;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton rbHanCapFour;
        private System.Windows.Forms.RadioButton rbHanCapThree;
        private System.Windows.Forms.RadioButton rbHanCapTwo;
        private System.Windows.Forms.RadioButton rbHanCapOne;
        private System.Windows.Forms.RadioButton rbHanCapZero;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.RadioButton rbSmoYes;
        private System.Windows.Forms.RadioButton rbSmoNo;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.RadioButton rbSchYes;
        private System.Windows.Forms.RadioButton rbSchNo;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.RadioButton rbTbcYes;
        private System.Windows.Forms.RadioButton rbTbcNo;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.RadioButton rbSmsTwo;
        private System.Windows.Forms.RadioButton rbSmsOne;
        private System.Windows.Forms.RadioButton rbSmsZero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox awaitBox;
        private System.Windows.Forms.Button button1;
    }
}

