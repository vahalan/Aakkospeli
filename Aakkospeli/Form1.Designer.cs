namespace Aakkospeli
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
      this.components = new System.ComponentModel.Container();
      this.button1 = new System.Windows.Forms.Button();
      this.tbText1 = new System.Windows.Forms.TextBox();
      this.tbText2 = new System.Windows.Forms.TextBox();
      this.tbText3 = new System.Windows.Forms.TextBox();
      this.tbOikein = new System.Windows.Forms.TextBox();
      this.tbVaarin = new System.Windows.Forms.TextBox();
      this.tbAika = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(105, 227);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 0;
      this.button1.Text = "Aloita";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // tbText1
      // 
      this.tbText1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbText1.Location = new System.Drawing.Point(12, 101);
      this.tbText1.Name = "tbText1";
      this.tbText1.Size = new System.Drawing.Size(111, 22);
      this.tbText1.TabIndex = 1;
      this.tbText1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // tbText2
      // 
      this.tbText2.BackColor = System.Drawing.Color.Gold;
      this.tbText2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbText2.Location = new System.Drawing.Point(125, 101);
      this.tbText2.Name = "tbText2";
      this.tbText2.Size = new System.Drawing.Size(21, 22);
      this.tbText2.TabIndex = 2;
      this.tbText2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // tbText3
      // 
      this.tbText3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbText3.Location = new System.Drawing.Point(148, 101);
      this.tbText3.Name = "tbText3";
      this.tbText3.Size = new System.Drawing.Size(124, 22);
      this.tbText3.TabIndex = 3;
      // 
      // tbOikein
      // 
      this.tbOikein.Location = new System.Drawing.Point(172, 12);
      this.tbOikein.Name = "tbOikein";
      this.tbOikein.Size = new System.Drawing.Size(100, 20);
      this.tbOikein.TabIndex = 4;
      this.tbOikein.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // tbVaarin
      // 
      this.tbVaarin.Location = new System.Drawing.Point(172, 39);
      this.tbVaarin.Name = "tbVaarin";
      this.tbVaarin.Size = new System.Drawing.Size(100, 20);
      this.tbVaarin.TabIndex = 5;
      this.tbVaarin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // tbAika
      // 
      this.tbAika.Location = new System.Drawing.Point(172, 65);
      this.tbAika.Name = "tbAika";
      this.tbAika.Size = new System.Drawing.Size(100, 20);
      this.tbAika.TabIndex = 6;
      this.tbAika.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(129, 15);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(37, 13);
      this.label1.TabIndex = 7;
      this.label1.Text = "Oikein";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(129, 42);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(37, 13);
      this.label2.TabIndex = 8;
      this.label2.Text = "Väärin";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(129, 68);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(28, 13);
      this.label3.TabIndex = 9;
      this.label3.Text = "Aika";
      // 
      // timer1
      // 
      this.timer1.Interval = 10;
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 262);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.tbAika);
      this.Controls.Add(this.tbVaarin);
      this.Controls.Add(this.tbOikein);
      this.Controls.Add(this.tbText3);
      this.Controls.Add(this.tbText2);
      this.Controls.Add(this.tbText1);
      this.Controls.Add(this.button1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.TextBox tbText1;
    private System.Windows.Forms.TextBox tbText2;
    private System.Windows.Forms.TextBox tbText3;
    private System.Windows.Forms.TextBox tbOikein;
    private System.Windows.Forms.TextBox tbVaarin;
    private System.Windows.Forms.TextBox tbAika;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Timer timer1;
  }
}

