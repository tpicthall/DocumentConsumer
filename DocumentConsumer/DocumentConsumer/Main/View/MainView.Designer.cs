namespace DocumentConsumer.Main.View
{
    partial class MainView
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslConnection = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtFhirServer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSeachValue = new System.Windows.Forms.TextBox();
            this.btnDocumentReference = new System.Windows.Forms.Button();
            this.btnDocumentManifest = new System.Windows.Forms.Button();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSearchParameter = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRequestResponse = new System.Windows.Forms.TextBox();
            this.btnRequest = new System.Windows.Forms.Button();
            this.btnResponse = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(716, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslConnection});
            this.statusStrip1.Location = new System.Drawing.Point(0, 603);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(716, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslConnection
            // 
            this.tsslConnection.Name = "tsslConnection";
            this.tsslConnection.Size = new System.Drawing.Size(0, 17);
            // 
            // txtFhirServer
            // 
            this.txtFhirServer.Location = new System.Drawing.Point(87, 27);
            this.txtFhirServer.Name = "txtFhirServer";
            this.txtFhirServer.Size = new System.Drawing.Size(266, 20);
            this.txtFhirServer.TabIndex = 0;
            this.txtFhirServer.Text = "http://10.242.13.17:8090/FHIR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "FHIR Server:";
            // 
            // txtSeachValue
            // 
            this.txtSeachValue.Location = new System.Drawing.Point(168, 86);
            this.txtSeachValue.Name = "txtSeachValue";
            this.txtSeachValue.Size = new System.Drawing.Size(266, 20);
            this.txtSeachValue.TabIndex = 3;
            this.txtSeachValue.Text = "urn:oid:1.3.6.1.4.1.38674|70dca78a-fe7a-4841-adba-88b131fd963e";
            // 
            // btnDocumentReference
            // 
            this.btnDocumentReference.Enabled = false;
            this.btnDocumentReference.Location = new System.Drawing.Point(168, 112);
            this.btnDocumentReference.Name = "btnDocumentReference";
            this.btnDocumentReference.Size = new System.Drawing.Size(130, 23);
            this.btnDocumentReference.TabIndex = 4;
            this.btnDocumentReference.Text = "Document Reference";
            this.btnDocumentReference.UseVisualStyleBackColor = true;
            this.btnDocumentReference.Click += new System.EventHandler(this.btnDocumentReference_Click);
            // 
            // btnDocumentManifest
            // 
            this.btnDocumentManifest.Enabled = false;
            this.btnDocumentManifest.Location = new System.Drawing.Point(304, 112);
            this.btnDocumentManifest.Name = "btnDocumentManifest";
            this.btnDocumentManifest.Size = new System.Drawing.Size(130, 23);
            this.btnDocumentManifest.TabIndex = 5;
            this.btnDocumentManifest.Text = "Document Manifest";
            this.btnDocumentManifest.UseVisualStyleBackColor = true;
            this.btnDocumentManifest.Click += new System.EventHandler(this.btnDocumentManifest_Click);
            // 
            // dgvResults
            // 
            this.dgvResults.AllowUserToAddRows = false;
            this.dgvResults.AllowUserToDeleteRows = false;
            this.dgvResults.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Location = new System.Drawing.Point(12, 154);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.ReadOnly = true;
            this.dgvResults.Size = new System.Drawing.Size(692, 184);
            this.dgvResults.TabIndex = 5;
            this.dgvResults.TabStop = false;
            this.dgvResults.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResults_CellContentClick);
            this.dgvResults.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvResults_DataBindingComplete);
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutput.Location = new System.Drawing.Point(3, 16);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOutput.Size = new System.Drawing.Size(281, 237);
            this.txtOutput.TabIndex = 6;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(359, 27);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 20);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Results:";
            // 
            // txtSearchParameter
            // 
            this.txtSearchParameter.Location = new System.Drawing.Point(12, 86);
            this.txtSearchParameter.Name = "txtSearchParameter";
            this.txtSearchParameter.Size = new System.Drawing.Size(150, 20);
            this.txtSearchParameter.TabIndex = 2;
            this.txtSearchParameter.Text = "subject:Patient.identifier";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 344);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.txtOutput);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtRequestResponse);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Size = new System.Drawing.Size(692, 256);
            this.splitContainer1.SplitterDistance = 287;
            this.splitContainer1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Output:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Request / Response:";
            // 
            // txtRequestResponse
            // 
            this.txtRequestResponse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRequestResponse.Location = new System.Drawing.Point(3, 16);
            this.txtRequestResponse.Multiline = true;
            this.txtRequestResponse.Name = "txtRequestResponse";
            this.txtRequestResponse.ReadOnly = true;
            this.txtRequestResponse.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtRequestResponse.Size = new System.Drawing.Size(395, 228);
            this.txtRequestResponse.TabIndex = 1;
            // 
            // btnRequest
            // 
            this.btnRequest.Location = new System.Drawing.Point(440, 112);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(75, 23);
            this.btnRequest.TabIndex = 6;
            this.btnRequest.Text = "Request";
            this.btnRequest.UseVisualStyleBackColor = true;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // btnResponse
            // 
            this.btnResponse.Location = new System.Drawing.Point(521, 112);
            this.btnResponse.Name = "btnResponse";
            this.btnResponse.Size = new System.Drawing.Size(75, 23);
            this.btnResponse.TabIndex = 7;
            this.btnResponse.Text = "Response";
            this.btnResponse.UseVisualStyleBackColor = true;
            this.btnResponse.Click += new System.EventHandler(this.btnResponse_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 625);
            this.Controls.Add(this.btnResponse);
            this.Controls.Add(this.btnRequest);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.txtSearchParameter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.dgvResults);
            this.Controls.Add(this.btnDocumentManifest);
            this.Controls.Add(this.btnDocumentReference);
            this.Controls.Add(this.txtSeachValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFhirServer);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainView";
            this.Text = "Document Consumer";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TextBox txtFhirServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSeachValue;
        private System.Windows.Forms.Button btnDocumentReference;
        private System.Windows.Forms.Button btnDocumentManifest;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ToolStripStatusLabel tsslConnection;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSearchParameter;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRequestResponse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.Button btnResponse;
    }
}