namespace MicMuter
{
    partial class Main
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
            this.btn_startmuter = new System.Windows.Forms.Button();
            this.btn_stopmuter = new System.Windows.Forms.Button();
            this.lbl_muterenb = new System.Windows.Forms.Label();
            this.lmt_mic = new System.Windows.Forms.ProgressBar();
            this.sbar_micminlvl = new System.Windows.Forms.TrackBar();
            this.btn_updatedev = new System.Windows.Forms.Button();
            this.cbox_mic = new System.Windows.Forms.ComboBox();
            this.cbox_out = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lmt_out = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.sbar_micminlvl)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_startmuter
            // 
            this.btn_startmuter.Location = new System.Drawing.Point(312, 328);
            this.btn_startmuter.Name = "btn_startmuter";
            this.btn_startmuter.Size = new System.Drawing.Size(75, 21);
            this.btn_startmuter.TabIndex = 0;
            this.btn_startmuter.Text = "Start";
            this.btn_startmuter.UseVisualStyleBackColor = true;
            this.btn_startmuter.Click += new System.EventHandler(this.Btn_startmuter_Click);
            // 
            // btn_stopmuter
            // 
            this.btn_stopmuter.Location = new System.Drawing.Point(231, 328);
            this.btn_stopmuter.Name = "btn_stopmuter";
            this.btn_stopmuter.Size = new System.Drawing.Size(75, 21);
            this.btn_stopmuter.TabIndex = 1;
            this.btn_stopmuter.Text = "Stop";
            this.btn_stopmuter.UseVisualStyleBackColor = true;
            this.btn_stopmuter.Click += new System.EventHandler(this.Btn_stopmuter_Click);
            // 
            // lbl_muterenb
            // 
            this.lbl_muterenb.AutoSize = true;
            this.lbl_muterenb.Location = new System.Drawing.Point(12, 332);
            this.lbl_muterenb.Name = "lbl_muterenb";
            this.lbl_muterenb.Size = new System.Drawing.Size(79, 12);
            this.lbl_muterenb.TabIndex = 2;
            this.lbl_muterenb.Text = "Muter Stopped";
            // 
            // lmt_mic
            // 
            this.lmt_mic.Location = new System.Drawing.Point(57, 36);
            this.lmt_mic.Name = "lmt_mic";
            this.lmt_mic.Size = new System.Drawing.Size(330, 21);
            this.lmt_mic.TabIndex = 6;
            // 
            // sbar_micminlvl
            // 
            this.sbar_micminlvl.Location = new System.Drawing.Point(57, 63);
            this.sbar_micminlvl.Maximum = 100;
            this.sbar_micminlvl.Name = "sbar_micminlvl";
            this.sbar_micminlvl.Size = new System.Drawing.Size(330, 45);
            this.sbar_micminlvl.TabIndex = 7;
            this.sbar_micminlvl.Scroll += new System.EventHandler(this.sbar_micminlvl_Scroll);
            // 
            // btn_updatedev
            // 
            this.btn_updatedev.Location = new System.Drawing.Point(150, 328);
            this.btn_updatedev.Name = "btn_updatedev";
            this.btn_updatedev.Size = new System.Drawing.Size(75, 21);
            this.btn_updatedev.TabIndex = 8;
            this.btn_updatedev.Text = "Update";
            this.btn_updatedev.UseVisualStyleBackColor = true;
            this.btn_updatedev.Click += new System.EventHandler(this.Btn_updatedev_Click);
            // 
            // cbox_mic
            // 
            this.cbox_mic.FormattingEnabled = true;
            this.cbox_mic.Location = new System.Drawing.Point(57, 11);
            this.cbox_mic.Name = "cbox_mic";
            this.cbox_mic.Size = new System.Drawing.Size(330, 20);
            this.cbox_mic.TabIndex = 9;
            // 
            // cbox_out
            // 
            this.cbox_out.FormattingEnabled = true;
            this.cbox_out.Location = new System.Drawing.Point(57, 110);
            this.cbox_out.Name = "cbox_out";
            this.cbox_out.Size = new System.Drawing.Size(330, 20);
            this.cbox_out.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "Mic";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "Output";
            // 
            // lmt_out
            // 
            this.lmt_out.Location = new System.Drawing.Point(57, 136);
            this.lmt_out.Name = "lmt_out";
            this.lmt_out.Size = new System.Drawing.Size(330, 23);
            this.lmt_out.TabIndex = 13;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 360);
            this.Controls.Add(this.lmt_out);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbox_out);
            this.Controls.Add(this.cbox_mic);
            this.Controls.Add(this.btn_updatedev);
            this.Controls.Add(this.sbar_micminlvl);
            this.Controls.Add(this.lmt_mic);
            this.Controls.Add(this.lbl_muterenb);
            this.Controls.Add(this.btn_stopmuter);
            this.Controls.Add(this.btn_startmuter);
            this.Name = "Main";
            this.Text = "MicMuter";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sbar_micminlvl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_startmuter;
        private System.Windows.Forms.Button btn_stopmuter;
        private System.Windows.Forms.Label lbl_muterenb;
        private System.Windows.Forms.ProgressBar lmt_mic;
        private System.Windows.Forms.TrackBar sbar_micminlvl;
        private System.Windows.Forms.Button btn_updatedev;
        private System.Windows.Forms.ComboBox cbox_mic;
        private System.Windows.Forms.ComboBox cbox_out;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar lmt_out;
    }
}

