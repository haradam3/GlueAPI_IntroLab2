namespace GlueAPIIntro
{
    partial class GlueUI
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
            this.buttonLogin = new System.Windows.Forms.Button();
            this.labelResponse = new System.Windows.Forms.Label();
            this.textBoxResponse = new System.Windows.Forms.TextBox();
            this.labelRequest = new System.Windows.Forms.Label();
            this.textBoxRequest = new System.Windows.Forms.TextBox();
            this.buttonProjects = new System.Windows.Forms.Button();
            this.buttonModels = new System.Windows.Forms.Button();
            this.buttonView = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.labelCurProj = new System.Windows.Forms.Label();
            this.labelCurModel = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.comboBoxProjects = new System.Windows.Forms.ComboBox();
            this.comboBoxModels = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(406, 37);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(90, 25);
            this.buttonLogin.TabIndex = 1;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // labelResponse
            // 
            this.labelResponse.AutoSize = true;
            this.labelResponse.Location = new System.Drawing.Point(27, 338);
            this.labelResponse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelResponse.Name = "labelResponse";
            this.labelResponse.Size = new System.Drawing.Size(72, 17);
            this.labelResponse.TabIndex = 2;
            this.labelResponse.Text = "Response";
            // 
            // textBoxResponse
            // 
            this.textBoxResponse.Location = new System.Drawing.Point(27, 363);
            this.textBoxResponse.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxResponse.Multiline = true;
            this.textBoxResponse.Name = "textBoxResponse";
            this.textBoxResponse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResponse.Size = new System.Drawing.Size(512, 209);
            this.textBoxResponse.TabIndex = 3;
            // 
            // labelRequest
            // 
            this.labelRequest.AutoSize = true;
            this.labelRequest.Location = new System.Drawing.Point(27, 240);
            this.labelRequest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRequest.Name = "labelRequest";
            this.labelRequest.Size = new System.Drawing.Size(61, 17);
            this.labelRequest.TabIndex = 4;
            this.labelRequest.Text = "Request";
            // 
            // textBoxRequest
            // 
            this.textBoxRequest.Location = new System.Drawing.Point(27, 265);
            this.textBoxRequest.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRequest.Multiline = true;
            this.textBoxRequest.Name = "textBoxRequest";
            this.textBoxRequest.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxRequest.Size = new System.Drawing.Size(512, 61);
            this.textBoxRequest.TabIndex = 5;
            // 
            // buttonProjects
            // 
            this.buttonProjects.Location = new System.Drawing.Point(406, 145);
            this.buttonProjects.Margin = new System.Windows.Forms.Padding(4);
            this.buttonProjects.Name = "buttonProjects";
            this.buttonProjects.Size = new System.Drawing.Size(90, 25);
            this.buttonProjects.TabIndex = 6;
            this.buttonProjects.Text = "Projects";
            this.buttonProjects.UseVisualStyleBackColor = true;
            this.buttonProjects.Click += new System.EventHandler(this.buttonProjects_Click);
            // 
            // buttonModels
            // 
            this.buttonModels.Location = new System.Drawing.Point(406, 186);
            this.buttonModels.Margin = new System.Windows.Forms.Padding(4);
            this.buttonModels.Name = "buttonModels";
            this.buttonModels.Size = new System.Drawing.Size(90, 25);
            this.buttonModels.TabIndex = 7;
            this.buttonModels.Text = "Models";
            this.buttonModels.UseVisualStyleBackColor = true;
            this.buttonModels.Click += new System.EventHandler(this.buttonModels_Click);
            // 
            // buttonView
            // 
            this.buttonView.Location = new System.Drawing.Point(567, 547);
            this.buttonView.Margin = new System.Windows.Forms.Padding(4);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(90, 25);
            this.buttonView.TabIndex = 8;
            this.buttonView.Text = "View";
            this.buttonView.UseVisualStyleBackColor = true;
            this.buttonView.Click += new System.EventHandler(this.buttonView_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(567, 15);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(4);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(27, 25);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(525, 513);
            this.webBrowser1.TabIndex = 9;
            // 
            // labelCurProj
            // 
            this.labelCurProj.AutoSize = true;
            this.labelCurProj.Location = new System.Drawing.Point(23, 142);
            this.labelCurProj.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCurProj.Name = "labelCurProj";
            this.labelCurProj.Size = new System.Drawing.Size(52, 17);
            this.labelCurProj.TabIndex = 10;
            this.labelCurProj.Text = "Project";
            // 
            // labelCurModel
            // 
            this.labelCurModel.AutoSize = true;
            this.labelCurModel.Location = new System.Drawing.Point(24, 190);
            this.labelCurModel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCurModel.Name = "labelCurModel";
            this.labelCurModel.Size = new System.Drawing.Size(46, 17);
            this.labelCurModel.TabIndex = 11;
            this.labelCurModel.Text = "Model";
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(24, 43);
            this.labelUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(79, 17);
            this.labelUserName.TabIndex = 12;
            this.labelUserName.Text = "User Name";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(24, 88);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(69, 17);
            this.labelPassword.TabIndex = 13;
            this.labelPassword.Text = "Password";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(120, 40);
            this.textBoxUserName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(268, 22);
            this.textBoxUserName.TabIndex = 14;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(123, 85);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(268, 22);
            this.textBoxPassword.TabIndex = 15;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Enabled = false;
            this.buttonLogout.Location = new System.Drawing.Point(406, 82);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(90, 25);
            this.buttonLogout.TabIndex = 16;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(120, 337);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(0, 17);
            this.labelStatus.TabIndex = 17;
            // 
            // comboBoxProjects
            // 
            this.comboBoxProjects.FormattingEnabled = true;
            this.comboBoxProjects.Location = new System.Drawing.Point(123, 142);
            this.comboBoxProjects.Name = "comboBoxProjects";
            this.comboBoxProjects.Size = new System.Drawing.Size(268, 24);
            this.comboBoxProjects.TabIndex = 18;
            this.comboBoxProjects.SelectedIndexChanged += new System.EventHandler(this.comboBoxProjects_SelectedIndexChanged);
            // 
            // comboBoxModels
            // 
            this.comboBoxModels.FormattingEnabled = true;
            this.comboBoxModels.Location = new System.Drawing.Point(123, 187);
            this.comboBoxModels.Name = "comboBoxModels";
            this.comboBoxModels.Size = new System.Drawing.Size(268, 24);
            this.comboBoxModels.TabIndex = 19;
            // 
            // GlueUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 591);
            this.Controls.Add(this.comboBoxModels);
            this.Controls.Add(this.comboBoxProjects);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.labelCurModel);
            this.Controls.Add(this.labelCurProj);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.buttonView);
            this.Controls.Add(this.buttonModels);
            this.Controls.Add(this.buttonProjects);
            this.Controls.Add(this.textBoxRequest);
            this.Controls.Add(this.labelRequest);
            this.Controls.Add(this.textBoxResponse);
            this.Controls.Add(this.labelResponse);
            this.Controls.Add(this.buttonLogin);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GlueUI";
            this.Text = "Glue API Intro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label labelResponse;
        private System.Windows.Forms.TextBox textBoxResponse;
        private System.Windows.Forms.Label labelRequest;
        private System.Windows.Forms.TextBox textBoxRequest;
        private System.Windows.Forms.Button buttonProjects;
        private System.Windows.Forms.Button buttonModels;
        private System.Windows.Forms.Button buttonView;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label labelCurProj;
        private System.Windows.Forms.Label labelCurModel;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.ComboBox comboBoxProjects;
        private System.Windows.Forms.ComboBox comboBoxModels;
    }
}

