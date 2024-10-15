
namespace APIGoogle
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
            this.button1 = new System.Windows.Forms.Button();
            this.textPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textFileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textFileId = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textCalendarID = new System.Windows.Forms.TextBox();
            this.textSummary = new System.Windows.Forms.TextBox();
            this.labelSummary = new System.Windows.Forms.Label();
            this.textDescription = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxStartEvent = new System.Windows.Forms.TextBox();
            this.textBoxEndEvent = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.filePathLocal = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.FindFileName = new System.Windows.Forms.TextBox();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(415, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Guardar Archivo en drive";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textPath
            // 
            this.textPath.Location = new System.Drawing.Point(164, 41);
            this.textPath.Name = "textPath";
            this.textPath.Size = new System.Drawing.Size(342, 23);
            this.textPath.TabIndex = 3;
            this.textPath.Text = "C:\\Users\\nayel\\Documents\\SoyUnaPruebaDeGoogleDrive.txt\r\n";
            this.textPath.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPath_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Resultado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Direccion del archivo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(223, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Resultado";
            // 
            // textFileName
            // 
            this.textFileName.Location = new System.Drawing.Point(309, 74);
            this.textFileName.Name = "textFileName";
            this.textFileName.Size = new System.Drawing.Size(100, 23);
            this.textFileName.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nuevo nombre del archivo en drive (opcional):\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(151, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "ID de la carpeta Drive";
            // 
            // textFileId
            // 
            this.textFileId.Location = new System.Drawing.Point(275, 6);
            this.textFileId.Name = "textFileId";
            this.textFileId.Size = new System.Drawing.Size(342, 23);
            this.textFileId.TabIndex = 10;
            this.textFileId.Text = "1z3ltFWtE1Wj-ReUH-WBCBB7ZogwPiQ9c";
            this.textFileId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textFileId_KeyPress);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(248, 534);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Guardar evento";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(515, 266);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 41);
            this.button3.TabIndex = 13;
            this.button3.Text = "Eventos guardados";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(184, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "ID del calendario:";
            // 
            // textCalendarID
            // 
            this.textCalendarID.Location = new System.Drawing.Point(285, 216);
            this.textCalendarID.Name = "textCalendarID";
            this.textCalendarID.Size = new System.Drawing.Size(342, 23);
            this.textCalendarID.TabIndex = 15;
            this.textCalendarID.Text = "a18490969@itmexicali.edu.mx";
            this.textCalendarID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCalendarID_KeyPress);
            // 
            // textSummary
            // 
            this.textSummary.Location = new System.Drawing.Point(161, 263);
            this.textSummary.Name = "textSummary";
            this.textSummary.Size = new System.Drawing.Size(342, 23);
            this.textSummary.TabIndex = 17;
            this.textSummary.Text = "Titulo Ejemplo";
            this.textSummary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textSummary_KeyPress);
            // 
            // labelSummary
            // 
            this.labelSummary.AutoSize = true;
            this.labelSummary.Location = new System.Drawing.Point(57, 266);
            this.labelSummary.Name = "labelSummary";
            this.labelSummary.Size = new System.Drawing.Size(98, 15);
            this.labelSummary.TabIndex = 16;
            this.labelSummary.Text = "Titulo del evento:";
            // 
            // textDescription
            // 
            this.textDescription.Location = new System.Drawing.Point(161, 298);
            this.textDescription.Name = "textDescription";
            this.textDescription.Size = new System.Drawing.Size(342, 23);
            this.textDescription.TabIndex = 19;
            this.textDescription.Text = "Soy una descripcion de evento\r\n";
            this.textDescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textDescription_KeyPress);
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(25, 301);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(130, 15);
            this.labelDescription.TabIndex = 18;
            this.labelDescription.Text = "Descripcion del evento:";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(34, 333);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 20;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 504);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 15);
            this.label7.TabIndex = 22;
            this.label7.Text = "Inicio del evento:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(300, 504);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 15);
            this.label8.TabIndex = 23;
            this.label8.Text = "Final del evento:";
            // 
            // textBoxStartEvent
            // 
            this.textBoxStartEvent.Location = new System.Drawing.Point(137, 505);
            this.textBoxStartEvent.Name = "textBoxStartEvent";
            this.textBoxStartEvent.Size = new System.Drawing.Size(149, 23);
            this.textBoxStartEvent.TabIndex = 24;
            this.textBoxStartEvent.TextChanged += new System.EventHandler(this.textBoxStartEvent_TextChanged);
            // 
            // textBoxEndEvent
            // 
            this.textBoxEndEvent.Location = new System.Drawing.Point(399, 504);
            this.textBoxEndEvent.Name = "textBoxEndEvent";
            this.textBoxEndEvent.Size = new System.Drawing.Size(149, 23);
            this.textBoxEndEvent.TabIndex = 25;
            this.textBoxEndEvent.TextChanged += new System.EventHandler(this.textBoxEndEvent_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 15);
            this.label9.TabIndex = 27;
            this.label9.Text = "Direccion de carpeta";
            // 
            // filePathLocal
            // 
            this.filePathLocal.Location = new System.Drawing.Point(164, 113);
            this.filePathLocal.Name = "filePathLocal";
            this.filePathLocal.Size = new System.Drawing.Size(342, 23);
            this.filePathLocal.TabIndex = 26;
            this.filePathLocal.Text = "C:\\Users\\nayel\\Documents\\GuardarArchivosDeGoogleDrive\\\r\n\r\n\r\n\r\n\r\n";
            this.filePathLocal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.filePathLocal_KeyPress);
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(366, 151);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(144, 23);
            this.button4.TabIndex = 28;
            this.button4.Text = "Guardar Archivo local";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(40, 151);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(214, 15);
            this.label10.TabIndex = 30;
            this.label10.Text = "Nombre del archivo en drive (opcional)";
            // 
            // FindFileName
            // 
            this.FindFileName.Location = new System.Drawing.Point(260, 148);
            this.FindFileName.Name = "FindFileName";
            this.FindFileName.Size = new System.Drawing.Size(100, 23);
            this.FindFileName.TabIndex = 29;
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Location = new System.Drawing.Point(300, 333);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 31;
            this.monthCalendar2.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar2_DateChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 568);
            this.Controls.Add(this.monthCalendar2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.FindFileName);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.filePathLocal);
            this.Controls.Add(this.textBoxEndEvent);
            this.Controls.Add(this.textBoxStartEvent);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.textDescription);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.textSummary);
            this.Controls.Add(this.labelSummary);
            this.Controls.Add(this.textCalendarID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textFileId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textFileName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textPath);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Metodos con Google";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textFileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textFileId;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textCalendarID;
        private System.Windows.Forms.TextBox textSummary;
        private System.Windows.Forms.Label labelSummary;
        private System.Windows.Forms.TextBox textDescription;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxStartEvent;
        private System.Windows.Forms.TextBox textBoxEndEvent;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox filePathLocal;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox FindFileName;
        private System.Windows.Forms.MonthCalendar monthCalendar2;
    }
}

