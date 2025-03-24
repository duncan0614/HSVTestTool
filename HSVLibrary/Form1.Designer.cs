
namespace HSVLibrary
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Bar_H_LowerLimit = new System.Windows.Forms.TrackBar();
            this.LBL_H_LowerLimit = new System.Windows.Forms.Label();
            this.Lbl_H_UpperLimit = new System.Windows.Forms.Label();
            this.Bar_H_UpperLimit = new System.Windows.Forms.TrackBar();
            this.Lbl_S_LowerLimit = new System.Windows.Forms.Label();
            this.Bar_S_LowerLimit = new System.Windows.Forms.TrackBar();
            this.Lbl_S_UpperLimit = new System.Windows.Forms.Label();
            this.Bar_S_UpperLimit = new System.Windows.Forms.TrackBar();
            this.Lbl_V_LowerLimit = new System.Windows.Forms.Label();
            this.Bar_V_LowerLimit = new System.Windows.Forms.TrackBar();
            this.Lbl_V_UpperLimit = new System.Windows.Forms.Label();
            this.Bar_V_UpperLimit = new System.Windows.Forms.TrackBar();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.Btn_Open = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Bar_H_LowerLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bar_H_UpperLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bar_S_LowerLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bar_S_UpperLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bar_V_LowerLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bar_V_UpperLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Bar_H_LowerLimit
            // 
            this.Bar_H_LowerLimit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Bar_H_LowerLimit.Location = new System.Drawing.Point(830, 44);
            this.Bar_H_LowerLimit.Maximum = 180;
            this.Bar_H_LowerLimit.Name = "Bar_H_LowerLimit";
            this.Bar_H_LowerLimit.Size = new System.Drawing.Size(150, 45);
            this.Bar_H_LowerLimit.TabIndex = 0;
            this.Bar_H_LowerLimit.Scroll += new System.EventHandler(this.Bar_H_LowerLimit_Scroll);
            // 
            // LBL_H_LowerLimit
            // 
            this.LBL_H_LowerLimit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LBL_H_LowerLimit.AutoSize = true;
            this.LBL_H_LowerLimit.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LBL_H_LowerLimit.Location = new System.Drawing.Point(839, 12);
            this.LBL_H_LowerLimit.Name = "LBL_H_LowerLimit";
            this.LBL_H_LowerLimit.Size = new System.Drawing.Size(112, 16);
            this.LBL_H_LowerLimit.TabIndex = 1;
            this.LBL_H_LowerLimit.Text = "H_LowerLimit";
            // 
            // Lbl_H_UpperLimit
            // 
            this.Lbl_H_UpperLimit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Lbl_H_UpperLimit.AutoSize = true;
            this.Lbl_H_UpperLimit.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lbl_H_UpperLimit.Location = new System.Drawing.Point(839, 109);
            this.Lbl_H_UpperLimit.Name = "Lbl_H_UpperLimit";
            this.Lbl_H_UpperLimit.Size = new System.Drawing.Size(111, 16);
            this.Lbl_H_UpperLimit.TabIndex = 3;
            this.Lbl_H_UpperLimit.Text = "H_UpperLimit";
            // 
            // Bar_H_UpperLimit
            // 
            this.Bar_H_UpperLimit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Bar_H_UpperLimit.Location = new System.Drawing.Point(830, 141);
            this.Bar_H_UpperLimit.Maximum = 180;
            this.Bar_H_UpperLimit.Name = "Bar_H_UpperLimit";
            this.Bar_H_UpperLimit.Size = new System.Drawing.Size(150, 45);
            this.Bar_H_UpperLimit.TabIndex = 2;
            this.Bar_H_UpperLimit.Value = 180;
            this.Bar_H_UpperLimit.Scroll += new System.EventHandler(this.Bar_H_UpperLimit_Scroll);
            // 
            // Lbl_S_LowerLimit
            // 
            this.Lbl_S_LowerLimit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Lbl_S_LowerLimit.AutoSize = true;
            this.Lbl_S_LowerLimit.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lbl_S_LowerLimit.Location = new System.Drawing.Point(839, 206);
            this.Lbl_S_LowerLimit.Name = "Lbl_S_LowerLimit";
            this.Lbl_S_LowerLimit.Size = new System.Drawing.Size(109, 16);
            this.Lbl_S_LowerLimit.TabIndex = 5;
            this.Lbl_S_LowerLimit.Text = "S_LowerLimit";
            // 
            // Bar_S_LowerLimit
            // 
            this.Bar_S_LowerLimit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Bar_S_LowerLimit.Location = new System.Drawing.Point(830, 238);
            this.Bar_S_LowerLimit.Maximum = 255;
            this.Bar_S_LowerLimit.Name = "Bar_S_LowerLimit";
            this.Bar_S_LowerLimit.Size = new System.Drawing.Size(150, 45);
            this.Bar_S_LowerLimit.TabIndex = 4;
            this.Bar_S_LowerLimit.Scroll += new System.EventHandler(this.Bar_S_LowerLimit_Scroll);
            // 
            // Lbl_S_UpperLimit
            // 
            this.Lbl_S_UpperLimit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Lbl_S_UpperLimit.AutoSize = true;
            this.Lbl_S_UpperLimit.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lbl_S_UpperLimit.Location = new System.Drawing.Point(839, 303);
            this.Lbl_S_UpperLimit.Name = "Lbl_S_UpperLimit";
            this.Lbl_S_UpperLimit.Size = new System.Drawing.Size(108, 16);
            this.Lbl_S_UpperLimit.TabIndex = 7;
            this.Lbl_S_UpperLimit.Text = "S_UpperLimit";
            // 
            // Bar_S_UpperLimit
            // 
            this.Bar_S_UpperLimit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Bar_S_UpperLimit.Location = new System.Drawing.Point(830, 335);
            this.Bar_S_UpperLimit.Maximum = 255;
            this.Bar_S_UpperLimit.Name = "Bar_S_UpperLimit";
            this.Bar_S_UpperLimit.Size = new System.Drawing.Size(150, 45);
            this.Bar_S_UpperLimit.TabIndex = 6;
            this.Bar_S_UpperLimit.Value = 255;
            this.Bar_S_UpperLimit.Scroll += new System.EventHandler(this.Bar_S_UpperLimit_Scroll);
            // 
            // Lbl_V_LowerLimit
            // 
            this.Lbl_V_LowerLimit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Lbl_V_LowerLimit.AutoSize = true;
            this.Lbl_V_LowerLimit.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lbl_V_LowerLimit.Location = new System.Drawing.Point(839, 400);
            this.Lbl_V_LowerLimit.Name = "Lbl_V_LowerLimit";
            this.Lbl_V_LowerLimit.Size = new System.Drawing.Size(112, 16);
            this.Lbl_V_LowerLimit.TabIndex = 9;
            this.Lbl_V_LowerLimit.Text = "V_LowerLimit";
            // 
            // Bar_V_LowerLimit
            // 
            this.Bar_V_LowerLimit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Bar_V_LowerLimit.Location = new System.Drawing.Point(830, 432);
            this.Bar_V_LowerLimit.Maximum = 255;
            this.Bar_V_LowerLimit.Name = "Bar_V_LowerLimit";
            this.Bar_V_LowerLimit.Size = new System.Drawing.Size(150, 45);
            this.Bar_V_LowerLimit.TabIndex = 8;
            this.Bar_V_LowerLimit.Scroll += new System.EventHandler(this.Bar_V_LowerLimit_Scroll);
            // 
            // Lbl_V_UpperLimit
            // 
            this.Lbl_V_UpperLimit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Lbl_V_UpperLimit.AutoSize = true;
            this.Lbl_V_UpperLimit.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lbl_V_UpperLimit.Location = new System.Drawing.Point(839, 497);
            this.Lbl_V_UpperLimit.Name = "Lbl_V_UpperLimit";
            this.Lbl_V_UpperLimit.Size = new System.Drawing.Size(111, 16);
            this.Lbl_V_UpperLimit.TabIndex = 11;
            this.Lbl_V_UpperLimit.Text = "V_UpperLimit";
            // 
            // Bar_V_UpperLimit
            // 
            this.Bar_V_UpperLimit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Bar_V_UpperLimit.Location = new System.Drawing.Point(830, 529);
            this.Bar_V_UpperLimit.Maximum = 255;
            this.Bar_V_UpperLimit.Name = "Bar_V_UpperLimit";
            this.Bar_V_UpperLimit.Size = new System.Drawing.Size(150, 45);
            this.Bar_V_UpperLimit.TabIndex = 10;
            this.Bar_V_UpperLimit.Value = 46;
            this.Bar_V_UpperLimit.Scroll += new System.EventHandler(this.Bar_V_UpperLimit_Scroll);
            // 
            // imageBox1
            // 
            this.imageBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageBox1.Location = new System.Drawing.Point(12, 12);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(812, 610);
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // Btn_Open
            // 
            this.Btn_Open.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Btn_Open.Location = new System.Drawing.Point(841, 594);
            this.Btn_Open.Name = "Btn_Open";
            this.Btn_Open.Size = new System.Drawing.Size(75, 23);
            this.Btn_Open.TabIndex = 12;
            this.Btn_Open.Text = "Open";
            this.Btn_Open.UseVisualStyleBackColor = true;
            this.Btn_Open.Click += new System.EventHandler(this.Btn_Open_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 634);
            this.Controls.Add(this.Btn_Open);
            this.Controls.Add(this.imageBox1);
            this.Controls.Add(this.Lbl_V_UpperLimit);
            this.Controls.Add(this.Bar_V_UpperLimit);
            this.Controls.Add(this.Lbl_V_LowerLimit);
            this.Controls.Add(this.Bar_V_LowerLimit);
            this.Controls.Add(this.Lbl_S_UpperLimit);
            this.Controls.Add(this.Bar_S_UpperLimit);
            this.Controls.Add(this.Lbl_S_LowerLimit);
            this.Controls.Add(this.Bar_S_LowerLimit);
            this.Controls.Add(this.Lbl_H_UpperLimit);
            this.Controls.Add(this.Bar_H_UpperLimit);
            this.Controls.Add(this.LBL_H_LowerLimit);
            this.Controls.Add(this.Bar_H_LowerLimit);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Bar_H_LowerLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bar_H_UpperLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bar_S_LowerLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bar_S_UpperLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bar_V_LowerLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bar_V_UpperLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar Bar_H_LowerLimit;
        private System.Windows.Forms.Label LBL_H_LowerLimit;
        private System.Windows.Forms.Label Lbl_H_UpperLimit;
        private System.Windows.Forms.TrackBar Bar_H_UpperLimit;
        private System.Windows.Forms.Label Lbl_S_LowerLimit;
        private System.Windows.Forms.TrackBar Bar_S_LowerLimit;
        private System.Windows.Forms.Label Lbl_S_UpperLimit;
        private System.Windows.Forms.TrackBar Bar_S_UpperLimit;
        private System.Windows.Forms.Label Lbl_V_LowerLimit;
        private System.Windows.Forms.TrackBar Bar_V_LowerLimit;
        private System.Windows.Forms.Label Lbl_V_UpperLimit;
        private System.Windows.Forms.TrackBar Bar_V_UpperLimit;
        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.Button Btn_Open;
    }
}

