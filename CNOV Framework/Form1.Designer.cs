namespace CNOV_Framework
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.antivirusgroup = new System.Windows.Forms.GroupBox();
            this.radlvl3 = new System.Windows.Forms.RadioButton();
            this.radlvl2 = new System.Windows.Forms.RadioButton();
            this.radlvl1 = new System.Windows.Forms.RadioButton();
            this.lblfilename = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.filesqty = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblcant = new System.Windows.Forms.Label();
            this.folderbox = new System.Windows.Forms.CheckBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtHash = new System.Windows.Forms.TextBox();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.performancegroup = new System.Windows.Forms.GroupBox();
            this.progresscpu = new System.Windows.Forms.ProgressBar();
            this.lbltotalram = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblavaram = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cpupercentaje = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblinprocess = new System.Windows.Forms.Label();
            this.btnopt3 = new System.Windows.Forms.Button();
            this.btnopt2 = new System.Windows.Forms.Button();
            this.btnopt1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.antivirusgroup.SuspendLayout();
            this.performancegroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // antivirusgroup
            // 
            this.antivirusgroup.Controls.Add(this.radlvl3);
            this.antivirusgroup.Controls.Add(this.radlvl2);
            this.antivirusgroup.Controls.Add(this.radlvl1);
            this.antivirusgroup.Controls.Add(this.lblfilename);
            this.antivirusgroup.Controls.Add(this.btnCancel);
            this.antivirusgroup.Controls.Add(this.progressBar1);
            this.antivirusgroup.Controls.Add(this.filesqty);
            this.antivirusgroup.Controls.Add(this.label3);
            this.antivirusgroup.Controls.Add(this.lblcant);
            this.antivirusgroup.Controls.Add(this.folderbox);
            this.antivirusgroup.Controls.Add(this.lblResult);
            this.antivirusgroup.Controls.Add(this.lblStatus);
            this.antivirusgroup.Controls.Add(this.label2);
            this.antivirusgroup.Controls.Add(this.label1);
            this.antivirusgroup.Controls.Add(this.btnBrowse);
            this.antivirusgroup.Controls.Add(this.txtHash);
            this.antivirusgroup.Controls.Add(this.txtFilePath);
            this.antivirusgroup.Location = new System.Drawing.Point(12, 12);
            this.antivirusgroup.Name = "antivirusgroup";
            this.antivirusgroup.Size = new System.Drawing.Size(405, 195);
            this.antivirusgroup.TabIndex = 0;
            this.antivirusgroup.TabStop = false;
            this.antivirusgroup.Enter += new System.EventHandler(this.antivirusgroup_Enter);
            // 
            // radlvl3
            // 
            this.radlvl3.AutoSize = true;
            this.radlvl3.Location = new System.Drawing.Point(294, 140);
            this.radlvl3.Name = "radlvl3";
            this.radlvl3.Size = new System.Drawing.Size(58, 17);
            this.radlvl3.TabIndex = 1;
            this.radlvl3.Text = "Nivel 3";
            this.radlvl3.UseVisualStyleBackColor = true;
            // 
            // radlvl2
            // 
            this.radlvl2.AutoSize = true;
            this.radlvl2.Location = new System.Drawing.Point(164, 140);
            this.radlvl2.Name = "radlvl2";
            this.radlvl2.Size = new System.Drawing.Size(58, 17);
            this.radlvl2.TabIndex = 12;
            this.radlvl2.Text = "Nivel 2";
            this.radlvl2.UseVisualStyleBackColor = true;
            // 
            // radlvl1
            // 
            this.radlvl1.AutoSize = true;
            this.radlvl1.Checked = true;
            this.radlvl1.Location = new System.Drawing.Point(45, 140);
            this.radlvl1.Name = "radlvl1";
            this.radlvl1.Size = new System.Drawing.Size(58, 17);
            this.radlvl1.TabIndex = 1;
            this.radlvl1.TabStop = true;
            this.radlvl1.Text = "Nivel 1";
            this.radlvl1.UseVisualStyleBackColor = true;
            // 
            // lblfilename
            // 
            this.lblfilename.AutoSize = true;
            this.lblfilename.Location = new System.Drawing.Point(256, 117);
            this.lblfilename.Name = "lblfilename";
            this.lblfilename.Size = new System.Drawing.Size(0, 13);
            this.lblfilename.TabIndex = 11;
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(324, 65);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 163);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(387, 23);
            this.progressBar1.TabIndex = 9;
            // 
            // filesqty
            // 
            this.filesqty.AutoSize = true;
            this.filesqty.Location = new System.Drawing.Point(142, 69);
            this.filesqty.Name = "filesqty";
            this.filesqty.Size = new System.Drawing.Size(13, 13);
            this.filesqty.TabIndex = 8;
            this.filesqty.Text = "0";
            this.filesqty.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(168, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Escaneando:";
            // 
            // lblcant
            // 
            this.lblcant.AutoSize = true;
            this.lblcant.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcant.Location = new System.Drawing.Point(75, 69);
            this.lblcant.Name = "lblcant";
            this.lblcant.Size = new System.Drawing.Size(61, 13);
            this.lblcant.TabIndex = 7;
            this.lblcant.Text = "Cantidad:";
            this.lblcant.Visible = false;
            // 
            // folderbox
            // 
            this.folderbox.AutoSize = true;
            this.folderbox.Location = new System.Drawing.Point(6, 68);
            this.folderbox.Name = "folderbox";
            this.folderbox.Size = new System.Drawing.Size(63, 17);
            this.folderbox.TabIndex = 1;
            this.folderbox.Text = "Carpeta";
            this.folderbox.UseVisualStyleBackColor = true;
            this.folderbox.CheckedChanged += new System.EventHandler(this.folderbox_CheckedChanged);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(58, 117);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 6;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(9, 117);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(43, 13);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "MD5:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Antivirus";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(324, 40);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Buscar";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_ClickAsync);
            // 
            // txtHash
            // 
            this.txtHash.Location = new System.Drawing.Point(45, 93);
            this.txtHash.Name = "txtHash";
            this.txtHash.Size = new System.Drawing.Size(354, 20);
            this.txtHash.TabIndex = 1;
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(6, 42);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(312, 20);
            this.txtFilePath.TabIndex = 1;
            // 
            // performancegroup
            // 
            this.performancegroup.Controls.Add(this.progresscpu);
            this.performancegroup.Controls.Add(this.lbltotalram);
            this.performancegroup.Controls.Add(this.label7);
            this.performancegroup.Controls.Add(this.lblavaram);
            this.performancegroup.Controls.Add(this.label6);
            this.performancegroup.Controls.Add(this.cpupercentaje);
            this.performancegroup.Controls.Add(this.label5);
            this.performancegroup.Controls.Add(this.label4);
            this.performancegroup.Location = new System.Drawing.Point(423, 12);
            this.performancegroup.Name = "performancegroup";
            this.performancegroup.Size = new System.Drawing.Size(405, 195);
            this.performancegroup.TabIndex = 1;
            this.performancegroup.TabStop = false;
            this.performancegroup.Enter += new System.EventHandler(this.performancegroup_Enter);
            // 
            // progresscpu
            // 
            this.progresscpu.Location = new System.Drawing.Point(144, 40);
            this.progresscpu.Name = "progresscpu";
            this.progresscpu.Size = new System.Drawing.Size(240, 23);
            this.progresscpu.Step = 1;
            this.progresscpu.TabIndex = 6;
            this.progresscpu.Tag = "";
            // 
            // lbltotalram
            // 
            this.lbltotalram.AutoSize = true;
            this.lbltotalram.Location = new System.Drawing.Point(92, 75);
            this.lbltotalram.Name = "lbltotalram";
            this.lbltotalram.Size = new System.Drawing.Size(0, 13);
            this.lbltotalram.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "RAM Total:";
            // 
            // lblavaram
            // 
            this.lblavaram.AutoSize = true;
            this.lblavaram.Location = new System.Drawing.Point(118, 96);
            this.lblavaram.Name = "lblavaram";
            this.lblavaram.Size = new System.Drawing.Size(0, 13);
            this.lblavaram.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "RAM Disponible";
            // 
            // cpupercentaje
            // 
            this.cpupercentaje.AutoSize = true;
            this.cpupercentaje.Location = new System.Drawing.Point(97, 45);
            this.cpupercentaje.Name = "cpupercentaje";
            this.cpupercentaje.Size = new System.Drawing.Size(0, 13);
            this.cpupercentaje.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Uso de CPU:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(164, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Performance";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblinprocess);
            this.groupBox1.Controls.Add(this.btnopt3);
            this.groupBox1.Controls.Add(this.btnopt2);
            this.groupBox1.Controls.Add(this.btnopt1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(12, 213);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 195);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // lblinprocess
            // 
            this.lblinprocess.AutoSize = true;
            this.lblinprocess.ForeColor = System.Drawing.Color.Green;
            this.lblinprocess.Location = new System.Drawing.Point(152, 166);
            this.lblinprocess.Name = "lblinprocess";
            this.lblinprocess.Size = new System.Drawing.Size(97, 13);
            this.lblinprocess.TabIndex = 10;
            this.lblinprocess.Text = "Listo para optimizar";
            // 
            // btnopt3
            // 
            this.btnopt3.Location = new System.Drawing.Point(313, 39);
            this.btnopt3.Name = "btnopt3";
            this.btnopt3.Size = new System.Drawing.Size(86, 118);
            this.btnopt3.TabIndex = 9;
            this.btnopt3.Text = "Optimización 3\r\n\r\nElimina archivos temporales de toda la computadora";
            this.btnopt3.UseVisualStyleBackColor = true;
            this.btnopt3.Click += new System.EventHandler(this.btnopt3_Click);
            // 
            // btnopt2
            // 
            this.btnopt2.Location = new System.Drawing.Point(160, 39);
            this.btnopt2.Name = "btnopt2";
            this.btnopt2.Size = new System.Drawing.Size(86, 118);
            this.btnopt2.TabIndex = 8;
            this.btnopt2.Text = "Optimización 2\r\n\r\nDetiene servicios importantes";
            this.btnopt2.UseVisualStyleBackColor = true;
            this.btnopt2.Click += new System.EventHandler(this.btnopt2_Click);
            // 
            // btnopt1
            // 
            this.btnopt1.Location = new System.Drawing.Point(6, 39);
            this.btnopt1.Name = "btnopt1";
            this.btnopt1.Size = new System.Drawing.Size(86, 118);
            this.btnopt1.TabIndex = 7;
            this.btnopt1.Text = "Optimización 1\r\n\r\nDetiene servicios seguros";
            this.btnopt1.UseVisualStyleBackColor = true;
            this.btnopt1.Click += new System.EventHandler(this.btnopt1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(168, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Optimización";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 416);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.performancegroup);
            this.Controls.Add(this.antivirusgroup);
            this.Name = "Form1";
            this.Text = "g";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.antivirusgroup.ResumeLayout(false);
            this.antivirusgroup.PerformLayout();
            this.performancegroup.ResumeLayout(false);
            this.performancegroup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox antivirusgroup;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtHash;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.CheckBox folderbox;
        private System.Windows.Forms.Label filesqty;
        private System.Windows.Forms.Label lblcant;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblfilename;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radlvl3;
        private System.Windows.Forms.RadioButton radlvl2;
        private System.Windows.Forms.RadioButton radlvl1;
        private System.Windows.Forms.GroupBox performancegroup;
        private System.Windows.Forms.Label cpupercentaje;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblavaram;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbltotalram;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ProgressBar progresscpu;
        private System.Windows.Forms.Button btnopt3;
        private System.Windows.Forms.Button btnopt2;
        private System.Windows.Forms.Button btnopt1;
        private System.Windows.Forms.Label lblinprocess;
    }
}

