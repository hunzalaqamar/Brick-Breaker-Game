
namespace Assignment_5
{
    partial class welcomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(welcomeForm));
            this.tablePanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Easy = new System.Windows.Forms.Button();
            this.btn_Medium = new System.Windows.Forms.Button();
            this.btn_Hard = new System.Windows.Forms.Button();
            this.btn_Legendary = new System.Windows.Forms.Button();
            this.tablePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tablePanel1
            // 
            this.tablePanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablePanel1.BackColor = System.Drawing.Color.Transparent;
            this.tablePanel1.ColumnCount = 4;
            this.tablePanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.04979F));
            this.tablePanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.95021F));
            this.tablePanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 146F));
            this.tablePanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 359F));
            this.tablePanel1.Controls.Add(this.lbl1, 0, 1);
            this.tablePanel1.Controls.Add(this.label1, 0, 2);
            this.tablePanel1.Controls.Add(this.btn_Easy, 1, 3);
            this.tablePanel1.Controls.Add(this.btn_Medium, 2, 3);
            this.tablePanel1.Controls.Add(this.btn_Hard, 1, 4);
            this.tablePanel1.Controls.Add(this.btn_Legendary, 2, 4);
            this.tablePanel1.Location = new System.Drawing.Point(3, 2);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.RowCount = 6;
            this.tablePanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 69.63563F));
            this.tablePanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.36437F));
            this.tablePanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tablePanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tablePanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tablePanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 155F));
            this.tablePanel1.Size = new System.Drawing.Size(994, 624);
            this.tablePanel1.TabIndex = 0;
            // 
            // lbl1
            // 
            this.lbl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.Black;
            this.tablePanel1.SetColumnSpan(this.lbl1, 4);
            this.lbl1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.White;
            this.lbl1.Location = new System.Drawing.Point(3, 158);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(988, 69);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Welcome to The Brick Breaker Game";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.tablePanel1.SetColumnSpan(this.label1, 4);
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(988, 108);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Difficulty";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Easy
            // 
            this.btn_Easy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Easy.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Easy.Location = new System.Drawing.Point(335, 338);
            this.btn_Easy.Name = "btn_Easy";
            this.btn_Easy.Size = new System.Drawing.Size(150, 63);
            this.btn_Easy.TabIndex = 2;
            this.btn_Easy.Text = "Easy";
            this.btn_Easy.UseVisualStyleBackColor = true;
            this.btn_Easy.Click += new System.EventHandler(this.btn_Easy_Click);
            // 
            // btn_Medium
            // 
            this.btn_Medium.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Medium.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Medium.Location = new System.Drawing.Point(491, 338);
            this.btn_Medium.Name = "btn_Medium";
            this.btn_Medium.Size = new System.Drawing.Size(140, 63);
            this.btn_Medium.TabIndex = 3;
            this.btn_Medium.Text = "Medium";
            this.btn_Medium.UseVisualStyleBackColor = true;
            this.btn_Medium.Click += new System.EventHandler(this.btn_Medium_Click);
            // 
            // btn_Hard
            // 
            this.btn_Hard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Hard.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Hard.Location = new System.Drawing.Point(335, 407);
            this.btn_Hard.Name = "btn_Hard";
            this.btn_Hard.Size = new System.Drawing.Size(150, 58);
            this.btn_Hard.TabIndex = 4;
            this.btn_Hard.Text = "Hard";
            this.btn_Hard.UseVisualStyleBackColor = true;
            this.btn_Hard.Click += new System.EventHandler(this.btn_Hard_Click);
            // 
            // btn_Legendary
            // 
            this.btn_Legendary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Legendary.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Legendary.Location = new System.Drawing.Point(491, 407);
            this.btn_Legendary.Name = "btn_Legendary";
            this.btn_Legendary.Size = new System.Drawing.Size(140, 58);
            this.btn_Legendary.TabIndex = 5;
            this.btn_Legendary.Text = "Legendary";
            this.btn_Legendary.UseVisualStyleBackColor = true;
            this.btn_Legendary.Click += new System.EventHandler(this.btn_Legendary_Click);
            // 
            // welcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1001, 632);
            this.Controls.Add(this.tablePanel1);
            this.DoubleBuffered = true;
            this.Name = "welcomeForm";
            this.Text = "Brick Breaker Game";
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tablePanel1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Easy;
        private System.Windows.Forms.Button btn_Medium;
        private System.Windows.Forms.Button btn_Hard;
        private System.Windows.Forms.Button btn_Legendary;
    }
}

