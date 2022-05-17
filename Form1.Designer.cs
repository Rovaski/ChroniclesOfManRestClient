namespace ChroniclesOfManRestClient
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtRestUrl = new System.Windows.Forms.TextBox();
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.submitRest = new System.Windows.Forms.Button();
            this.searchBoxInput = new System.Windows.Forms.TextBox();
            this.searchRest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rest URL";
            // 
            // txtRestUrl
            // 
            this.txtRestUrl.Location = new System.Drawing.Point(71, 6);
            this.txtRestUrl.Name = "txtRestUrl";
            this.txtRestUrl.Size = new System.Drawing.Size(452, 23);
            this.txtRestUrl.TabIndex = 1;
            // 
            // txtResponse
            // 
            this.txtResponse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResponse.Location = new System.Drawing.Point(12, 35);
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResponse.Size = new System.Drawing.Size(776, 403);
            this.txtResponse.TabIndex = 2;
            // 
            // submitRest
            // 
            this.submitRest.Location = new System.Drawing.Point(529, 5);
            this.submitRest.Name = "submitRest";
            this.submitRest.Size = new System.Drawing.Size(75, 23);
            this.submitRest.TabIndex = 3;
            this.submitRest.Text = "Consume";
            this.submitRest.UseVisualStyleBackColor = true;
            this.submitRest.Click += new System.EventHandler(this.submitRest_Click);
            // 
            // searchBoxInput
            // 
            this.searchBoxInput.Location = new System.Drawing.Point(610, 6);
            this.searchBoxInput.Name = "searchBoxInput";
            this.searchBoxInput.Size = new System.Drawing.Size(100, 23);
            this.searchBoxInput.TabIndex = 4;
            // 
            // searchRest
            // 
            this.searchRest.Location = new System.Drawing.Point(713, 5);
            this.searchRest.Name = "searchRest";
            this.searchRest.Size = new System.Drawing.Size(75, 23);
            this.searchRest.TabIndex = 5;
            this.searchRest.Text = "Search";
            this.searchRest.UseVisualStyleBackColor = true;
            this.searchRest.Click += new System.EventHandler(this.searchRest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchRest);
            this.Controls.Add(this.searchBoxInput);
            this.Controls.Add(this.submitRest);
            this.Controls.Add(this.txtResponse);
            this.Controls.Add(this.txtRestUrl);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Chronicles of Man REST Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRestUrl;
        private System.Windows.Forms.TextBox txtResponse;
        private System.Windows.Forms.Button submitRest;
        private System.Windows.Forms.TextBox searchBoxInput;
        private System.Windows.Forms.Button searchRest;
    }
}
