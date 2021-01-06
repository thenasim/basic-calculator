
namespace SimpleCalculator
{
  partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.btnAns = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDeleteDigit = new System.Windows.Forms.Button();
            this.btnClearCurrent = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnPlusMinus = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtOperation = new System.Windows.Forms.TextBox();
            this.txtIO = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAns
            // 
            this.btnAns.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAns.Location = new System.Drawing.Point(289, 304);
            this.btnAns.Name = "btnAns";
            this.btnAns.Size = new System.Drawing.Size(90, 70);
            this.btnAns.TabIndex = 0;
            this.btnAns.Text = "Ans";
            this.btnAns.UseVisualStyleBackColor = true;
            this.btnAns.Click += new System.EventHandler(this.btnAns_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDeleteDigit);
            this.panel1.Controls.Add(this.btnClearCurrent);
            this.panel1.Controls.Add(this.btnClearAll);
            this.panel1.Controls.Add(this.btnPlusMinus);
            this.panel1.Controls.Add(this.btn1);
            this.panel1.Controls.Add(this.btn4);
            this.panel1.Controls.Add(this.btn7);
            this.panel1.Controls.Add(this.btnSum);
            this.panel1.Controls.Add(this.btnSubtract);
            this.panel1.Controls.Add(this.btnDot);
            this.panel1.Controls.Add(this.btn3);
            this.panel1.Controls.Add(this.btn6);
            this.panel1.Controls.Add(this.btn0);
            this.panel1.Controls.Add(this.btn2);
            this.panel1.Controls.Add(this.btn5);
            this.panel1.Controls.Add(this.btnMulti);
            this.panel1.Controls.Add(this.btn9);
            this.panel1.Controls.Add(this.btn8);
            this.panel1.Controls.Add(this.btnDiv);
            this.panel1.Controls.Add(this.btnAns);
            this.panel1.Location = new System.Drawing.Point(0, 141);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 376);
            this.panel1.TabIndex = 1;
            // 
            // btnDeleteDigit
            // 
            this.btnDeleteDigit.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteDigit.Location = new System.Drawing.Point(193, 0);
            this.btnDeleteDigit.Name = "btnDeleteDigit";
            this.btnDeleteDigit.Size = new System.Drawing.Size(90, 70);
            this.btnDeleteDigit.TabIndex = 23;
            this.btnDeleteDigit.Text = "⇽";
            this.btnDeleteDigit.UseVisualStyleBackColor = true;
            this.btnDeleteDigit.Click += new System.EventHandler(this.btnDeleteDigit_Click);
            // 
            // btnClearCurrent
            // 
            this.btnClearCurrent.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearCurrent.Location = new System.Drawing.Point(1, 0);
            this.btnClearCurrent.Name = "btnClearCurrent";
            this.btnClearCurrent.Size = new System.Drawing.Size(90, 70);
            this.btnClearCurrent.TabIndex = 22;
            this.btnClearCurrent.Text = "CE";
            this.btnClearCurrent.UseVisualStyleBackColor = true;
            this.btnClearCurrent.Click += new System.EventHandler(this.btnClearCurrent_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAll.Location = new System.Drawing.Point(97, 0);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(90, 70);
            this.btnClearAll.TabIndex = 21;
            this.btnClearAll.Text = "C";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnPlusMinus
            // 
            this.btnPlusMinus.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlusMinus.Location = new System.Drawing.Point(1, 304);
            this.btnPlusMinus.Name = "btnPlusMinus";
            this.btnPlusMinus.Size = new System.Drawing.Size(90, 70);
            this.btnPlusMinus.TabIndex = 16;
            this.btnPlusMinus.Text = "±";
            this.btnPlusMinus.UseVisualStyleBackColor = true;
            this.btnPlusMinus.Click += new System.EventHandler(this.btnPlusMinus_Click);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(1, 228);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(90, 70);
            this.btn1.TabIndex = 15;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btnNumberClick);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(1, 152);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(90, 70);
            this.btn4.TabIndex = 14;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btnNumberClick);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(1, 76);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(90, 70);
            this.btn7.TabIndex = 13;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btnNumberClick);
            // 
            // btnSum
            // 
            this.btnSum.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSum.Location = new System.Drawing.Point(289, 228);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(90, 70);
            this.btnSum.TabIndex = 12;
            this.btnSum.Text = "+";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnOperationPerform);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtract.Location = new System.Drawing.Point(289, 152);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(90, 70);
            this.btnSubtract.TabIndex = 11;
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.btnOperationPerform);
            // 
            // btnDot
            // 
            this.btnDot.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDot.Location = new System.Drawing.Point(193, 304);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(90, 70);
            this.btnDot.TabIndex = 10;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = true;
            this.btnDot.Click += new System.EventHandler(this.btnDot_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(193, 228);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(90, 70);
            this.btn3.TabIndex = 9;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btnNumberClick);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(193, 152);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(90, 70);
            this.btn6.TabIndex = 8;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btnNumberClick);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(97, 304);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(90, 70);
            this.btn0.TabIndex = 7;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btnNumberClick);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(97, 228);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(90, 70);
            this.btn2.TabIndex = 6;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btnNumberClick);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(97, 152);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(90, 70);
            this.btn5.TabIndex = 5;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btnNumberClick);
            // 
            // btnMulti
            // 
            this.btnMulti.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMulti.Location = new System.Drawing.Point(289, 76);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(90, 70);
            this.btnMulti.TabIndex = 4;
            this.btnMulti.Text = "x";
            this.btnMulti.UseVisualStyleBackColor = true;
            this.btnMulti.Click += new System.EventHandler(this.btnOperationPerform);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(193, 76);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(90, 70);
            this.btn9.TabIndex = 3;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btnNumberClick);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(97, 76);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(90, 70);
            this.btn8.TabIndex = 2;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btnNumberClick);
            // 
            // btnDiv
            // 
            this.btnDiv.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiv.Location = new System.Drawing.Point(289, 0);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(90, 70);
            this.btnDiv.TabIndex = 1;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnOperationPerform);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtOperation);
            this.panel2.Controls.Add(this.txtIO);
            this.panel2.Location = new System.Drawing.Point(1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(379, 141);
            this.panel2.TabIndex = 2;
            // 
            // txtOperation
            // 
            this.txtOperation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOperation.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOperation.Location = new System.Drawing.Point(-1, 3);
            this.txtOperation.Name = "txtOperation";
            this.txtOperation.ReadOnly = true;
            this.txtOperation.Size = new System.Drawing.Size(380, 27);
            this.txtOperation.TabIndex = 1;
            this.txtOperation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtOperation.WordWrap = false;
            // 
            // txtIO
            // 
            this.txtIO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIO.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIO.Location = new System.Drawing.Point(-1, 59);
            this.txtIO.Name = "txtIO";
            this.txtIO.ReadOnly = true;
            this.txtIO.Size = new System.Drawing.Size(380, 36);
            this.txtIO.TabIndex = 0;
            this.txtIO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtIO.WordWrap = false;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(381, 516);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Basic Calculator";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnAns;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button btnSum;
    private System.Windows.Forms.Button btnSubtract;
    private System.Windows.Forms.Button btnDot;
    private System.Windows.Forms.Button btn3;
    private System.Windows.Forms.Button btn6;
    private System.Windows.Forms.Button btn0;
    private System.Windows.Forms.Button btn2;
    private System.Windows.Forms.Button btn5;
    private System.Windows.Forms.Button btnMulti;
    private System.Windows.Forms.Button btn9;
    private System.Windows.Forms.Button btn8;
    private System.Windows.Forms.Button btnDiv;
    private System.Windows.Forms.Button btnPlusMinus;
    private System.Windows.Forms.Button btn1;
    private System.Windows.Forms.Button btn4;
    private System.Windows.Forms.Button btn7;
    private System.Windows.Forms.Button btnDeleteDigit;
    private System.Windows.Forms.Button btnClearCurrent;
    private System.Windows.Forms.Button btnClearAll;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.TextBox txtIO;
    private System.Windows.Forms.TextBox txtOperation;
  }
}

