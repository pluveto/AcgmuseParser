namespace AcgmuseParser.Windows
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
            this.openMidiDialog = new System.Windows.Forms.OpenFileDialog();
            this.tbOut = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFileName = new System.Windows.Forms.TextBox();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.btnGo = new System.Windows.Forms.Button();
            this.trackBarOct = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.trackBarThird = new System.Windows.Forms.TrackBar();
            this.trackBarSecond = new System.Windows.Forms.TrackBar();
            this.trackBarFirst = new System.Windows.Forms.TrackBar();
            this.lblThirdClass = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSecondClass = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblFirstClass = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCopy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOct)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarThird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSecond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFirst)).BeginInit();
            this.SuspendLayout();
            // 
            // openMidiDialog
            // 
            this.openMidiDialog.FileName = "openFileDialog1";
            this.openMidiDialog.Filter = "midi 文件|*.mid";
            // 
            // tbOut
            // 
            this.tbOut.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbOut.Location = new System.Drawing.Point(370, 58);
            this.tbOut.Multiline = true;
            this.tbOut.Name = "tbOut";
            this.tbOut.Size = new System.Drawing.Size(387, 499);
            this.tbOut.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(368, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "输出JE谱";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "输入文件";
            // 
            // tbFileName
            // 
            this.tbFileName.Location = new System.Drawing.Point(71, 16);
            this.tbFileName.Name = "tbFileName";
            this.tbFileName.ReadOnly = true;
            this.tbFileName.Size = new System.Drawing.Size(201, 21);
            this.tbFileName.TabIndex = 2;
            this.tbFileName.DoubleClick += new System.EventHandler(this.BtnBrowser_Click);
            // 
            // btnBrowser
            // 
            this.btnBrowser.Location = new System.Drawing.Point(278, 14);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(75, 23);
            this.btnBrowser.TabIndex = 3;
            this.btnBrowser.Text = "浏览...";
            this.btnBrowser.UseVisualStyleBackColor = true;
            this.btnBrowser.Click += new System.EventHandler(this.BtnBrowser_Click);
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(19, 312);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(339, 27);
            this.btnGo.TabIndex = 5;
            this.btnGo.Text = "转换";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.BtnGo_Click);
            // 
            // trackBarOct
            // 
            this.trackBarOct.Location = new System.Drawing.Point(81, 261);
            this.trackBarOct.Maximum = 2;
            this.trackBarOct.Minimum = -2;
            this.trackBarOct.Name = "trackBarOct";
            this.trackBarOct.Size = new System.Drawing.Size(266, 45);
            this.trackBarOct.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 264);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 8;
            this.label8.Text = "八度调整";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.trackBarThird);
            this.groupBox1.Controls.Add(this.trackBarSecond);
            this.groupBox1.Controls.Add(this.trackBarFirst);
            this.groupBox1.Controls.Add(this.lblThirdClass);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblSecondClass);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblFirstClass);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(14, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 197);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "分割节奏的临界值调整";
            // 
            // trackBarThird
            // 
            this.trackBarThird.Location = new System.Drawing.Point(62, 133);
            this.trackBarThird.Maximum = 10000;
            this.trackBarThird.Name = "trackBarThird";
            this.trackBarThird.Size = new System.Drawing.Size(184, 45);
            this.trackBarThird.TabIndex = 11;
            this.trackBarThird.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarThird.Value = 5000;
            this.trackBarThird.Scroll += new System.EventHandler(this.TrackBarThird_Scroll);
            // 
            // trackBarSecond
            // 
            this.trackBarSecond.Location = new System.Drawing.Point(62, 82);
            this.trackBarSecond.Maximum = 3000;
            this.trackBarSecond.Name = "trackBarSecond";
            this.trackBarSecond.Size = new System.Drawing.Size(184, 45);
            this.trackBarSecond.TabIndex = 12;
            this.trackBarSecond.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarSecond.Value = 1000;
            this.trackBarSecond.Scroll += new System.EventHandler(this.TrackBarSecond_Scroll);
            // 
            // trackBarFirst
            // 
            this.trackBarFirst.Location = new System.Drawing.Point(62, 31);
            this.trackBarFirst.Maximum = 1000;
            this.trackBarFirst.Name = "trackBarFirst";
            this.trackBarFirst.Size = new System.Drawing.Size(184, 45);
            this.trackBarFirst.TabIndex = 13;
            this.trackBarFirst.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarFirst.Value = 500;
            this.trackBarFirst.Scroll += new System.EventHandler(this.TrackBarFirst_Scroll);
            // 
            // lblThirdClass
            // 
            this.lblThirdClass.AutoSize = true;
            this.lblThirdClass.Location = new System.Drawing.Point(252, 133);
            this.lblThirdClass.Name = "lblThirdClass";
            this.lblThirdClass.Size = new System.Drawing.Size(41, 12);
            this.lblThirdClass.TabIndex = 5;
            this.lblThirdClass.Text = "第三档";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "第三档\r\n双换行";
            // 
            // lblSecondClass
            // 
            this.lblSecondClass.AutoSize = true;
            this.lblSecondClass.Location = new System.Drawing.Point(252, 82);
            this.lblSecondClass.Name = "lblSecondClass";
            this.lblSecondClass.Size = new System.Drawing.Size(41, 12);
            this.lblSecondClass.TabIndex = 7;
            this.lblSecondClass.Text = "第二档";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "第二档\r\n换行";
            // 
            // lblFirstClass
            // 
            this.lblFirstClass.AutoSize = true;
            this.lblFirstClass.Location = new System.Drawing.Point(252, 34);
            this.lblFirstClass.Name = "lblFirstClass";
            this.lblFirstClass.Size = new System.Drawing.Size(41, 12);
            this.lblFirstClass.TabIndex = 9;
            this.lblFirstClass.Text = "第一档";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(15, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 31);
            this.label4.TabIndex = 10;
            this.label4.Text = "第一档\r\n四空格";
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(682, 29);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 3;
            this.btnCopy.Text = "复制";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.BtnCopy_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 562);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.trackBarOct);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnBrowser);
            this.Controls.Add(this.tbFileName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbOut);
            this.Name = "MainForm";
            this.Text = "Acgmuse MIDI->Je谱 转换器";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOct)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarThird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSecond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFirst)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openMidiDialog;
        private System.Windows.Forms.TextBox tbOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbFileName;
        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TrackBar trackBarOct;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar trackBarThird;
        private System.Windows.Forms.TrackBar trackBarSecond;
        private System.Windows.Forms.TrackBar trackBarFirst;
        private System.Windows.Forms.Label lblThirdClass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSecondClass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblFirstClass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCopy;
    }
}