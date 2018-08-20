namespace WindowsFormsApp1
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
            this.OpenFileDialogAgentResult = new System.Windows.Forms.OpenFileDialog();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.AgentLabel = new System.Windows.Forms.Label();
            this.Submit = new System.Windows.Forms.Button();
            this.ResultText = new System.Windows.Forms.TextBox();
            this.ResultButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AgentText = new System.Windows.Forms.TextBox();
            this.AgentButton = new System.Windows.Forms.Button();
            this.dataGridViewResults = new System.Windows.Forms.DataGridView();
            this.dataGridViewJobs = new System.Windows.Forms.DataGridView();
            this.label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJobs)).BeginInit();
            this.SuspendLayout();
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ResultLabel.Location = new System.Drawing.Point(448, -27);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(72, 17);
            this.ResultLabel.TabIndex = 12;
            this.ResultLabel.Text = "ResultLog";
            // 
            // AgentLabel
            // 
            this.AgentLabel.AutoSize = true;
            this.AgentLabel.BackColor = System.Drawing.Color.Transparent;
            this.AgentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgentLabel.Location = new System.Drawing.Point(110, -27);
            this.AgentLabel.Name = "AgentLabel";
            this.AgentLabel.Size = new System.Drawing.Size(69, 17);
            this.AgentLabel.TabIndex = 10;
            this.AgentLabel.Text = "AgentLog";
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Submit.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Submit.Location = new System.Drawing.Point(390, 117);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 23);
            this.Submit.TabIndex = 20;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // ResultText
            // 
            this.ResultText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultText.Location = new System.Drawing.Point(567, 75);
            this.ResultText.Name = "ResultText";
            this.ResultText.Size = new System.Drawing.Size(172, 20);
            this.ResultText.TabIndex = 18;
            // 
            // ResultButton
            // 
            this.ResultButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ResultButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResultButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ResultButton.Location = new System.Drawing.Point(475, 73);
            this.ResultButton.Name = "ResultButton";
            this.ResultButton.Size = new System.Drawing.Size(75, 23);
            this.ResultButton.TabIndex = 16;
            this.ResultButton.Text = "Load";
            this.ResultButton.UseVisualStyleBackColor = false;
            this.ResultButton.Click += new System.EventHandler(this.ResultButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(524, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 49);
            this.label1.TabIndex = 17;
            this.label1.Text = "ResultLog";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(190, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "AgentLog";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AgentText
            // 
            this.AgentText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AgentText.Location = new System.Drawing.Point(228, 76);
            this.AgentText.Name = "AgentText";
            this.AgentText.Size = new System.Drawing.Size(157, 20);
            this.AgentText.TabIndex = 14;
            // 
            // AgentButton
            // 
            this.AgentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AgentButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.AgentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AgentButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.AgentButton.Location = new System.Drawing.Point(134, 74);
            this.AgentButton.Name = "AgentButton";
            this.AgentButton.Size = new System.Drawing.Size(75, 23);
            this.AgentButton.TabIndex = 13;
            this.AgentButton.Text = "Load";
            this.AgentButton.UseVisualStyleBackColor = false;
            this.AgentButton.Click += new System.EventHandler(this.AgentButton_Click);
            // 
            // dataGridViewResults
            // 
            this.dataGridViewResults.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewResults.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridViewResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResults.Location = new System.Drawing.Point(426, 206);
            this.dataGridViewResults.Name = "dataGridViewResults";
            this.dataGridViewResults.Size = new System.Drawing.Size(408, 381);
            this.dataGridViewResults.TabIndex = 22;
            // 
            // dataGridViewJobs
            // 
            this.dataGridViewJobs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewJobs.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridViewJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewJobs.Location = new System.Drawing.Point(26, 206);
            this.dataGridViewJobs.Name = "dataGridViewJobs";
            this.dataGridViewJobs.Size = new System.Drawing.Size(401, 381);
            this.dataGridViewJobs.TabIndex = 21;
            this.dataGridViewJobs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewJobs_CellContentClick);
            // 
            // label
            // 
            this.label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label.Location = new System.Drawing.Point(26, 154);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(401, 56);
            this.label.TabIndex = 23;
            this.label.Text = "JOBS";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(426, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(408, 56);
            this.label3.TabIndex = 24;
            this.label3.Text = "RESULTS";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(860, 599);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label);
            this.Controls.Add(this.dataGridViewJobs);
            this.Controls.Add(this.dataGridViewResults);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.ResultText);
            this.Controls.Add(this.ResultButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AgentText);
            this.Controls.Add(this.AgentButton);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.AgentLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJobs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Label ResultLabel;
        internal System.Windows.Forms.Label AgentLabel;
        internal System.Windows.Forms.Button Submit;
        internal System.Windows.Forms.TextBox ResultText;
        internal System.Windows.Forms.Button ResultButton;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox AgentText;
        internal System.Windows.Forms.Button AgentButton;
        internal System.Windows.Forms.OpenFileDialog OpenFileDialogAgentResult;
        private System.Windows.Forms.DataGridView dataGridViewResults;
        public System.Windows.Forms.DataGridView dataGridViewJobs;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label3;
    }
}

