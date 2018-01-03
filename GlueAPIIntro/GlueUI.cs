#region Copyright
//
// Copyright (C) 2013-2018 by Autodesk, Inc.
//
// Permission to use, copy, modify, and distribute this software in
// object code form for any purpose and without fee is hereby granted,
// provided that the above copyright notice appears in all copies and
// that both that copyright notice and the limited warranty and
// restricted rights notice below appear in all supporting
// documentation.
//
// AUTODESK PROVIDES THIS PROGRAM "AS IS" AND WITH ALL FAULTS.
// AUTODESK SPECIFICALLY DISCLAIMS ANY IMPLIED WARRANTY OF
// MERCHANTABILITY OR FITNESS FOR A PARTICULAR USE.  AUTODESK, INC.
// DOES NOT WARRANT THAT THE OPERATION OF THE PROGRAM WILL BE
// UNINTERRUPTED OR ERROR FREE.
//
// Use, duplication, or disclosure by the U.S. Government is subject to
// restrictions set forth in FAR 52.227-19 (Commercial Computer
// Software - Restricted Rights) and DFAR 252.227-7013(c)(1)(ii)
// (Rights in Technical Data and Computer Software), as applicable.
//
// Written by M.Harada 
#endregion // Copyright

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
// Added for RestSharp. 
using RestSharp;

namespace GlueAPIIntro
{

    public partial class GlueUI : Form
    {
        // Save info needed. 
        private static string m_authToken = "";
        private static List<Project> m_proj_list;
        private static List<ModelInfo> m_model_list;

        public GlueUI()
        {
            InitializeComponent();
        }

        //=========================================================
        //  Login/Logout
        //=========================================================
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            // Get the user name and password from the user. 
            string userName = textBoxUserName.Text;
            string password = textBoxPassword.Text;

            InitRequestResponse();
            this.Update();

            // Here is the main part that we call Glue login 
            m_authToken = Glue.Login(userName, password);

            // If success, change the button to logout.
            if (m_authToken != null && m_authToken.Length > 0)
            {
                buttonLogin.Enabled = false;
                buttonLogout.Enabled = true;
            }

            // Show the request and response in the form. 
            // This is for learning purpose. 
            ShowRequestResponse();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            InitRequestResponse();
            this.Update();

            // Here is the main part that we call Glue login 
            bool logoutResponse = Glue.Logout(m_authToken);

            m_authToken= "";
            buttonLogin.Enabled = true;
            buttonLogout.Enabled = false;

            // Show the request and response in the form. 
            // This is for learning purpose. 
            ShowRequestResponse();
        }

        //==========================================================
        // Helper functions 
        //==========================================================
        private void InitRequestResponse()
        {
            // initialize the request and response text in the form.
            textBoxRequest.Text = "Request comes here";
            labelStatus.Text = "";
            textBoxResponse.Text = "Response comes here. This may take seconds. Please wait...";
        }
        private void ShowRequestResponse()
        {
            // show the request and response in the form. 
            IRestResponse response = Glue.m_lastResponse;
            textBoxRequest.Text = response.ResponseUri.AbsoluteUri;
            labelStatus.Text = "Status: " + response.StatusCode.ToString();
            textBoxResponse.Text = response.Content;
        }

        //=========================================================
        //  Projects 
        //=========================================================
        private void buttonProjects_Click(object sender, EventArgs e)
        {
            InitRequestResponse();
            this.Update();

            m_proj_list = Glue.ProjectList(m_authToken);

            ShowRequestResponse();

            if (m_proj_list == null) { return; }

            // Set up a project list
            m_proj_list = m_proj_list.OrderBy(x => x.project_name).ToList();
            comboBoxProjects.DataSource = new BindingSource(m_proj_list, null);
            comboBoxProjects.DisplayMember = "project_name";
            comboBoxProjects.ValueMember = "project_id";
            comboBoxProjects.SelectedIndex = 0;
        }

        private void comboBoxProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            // clear model list
            comboBoxModels.DataSource = null; 
        }

        //=========================================================
        //  Models 
        //=========================================================
        private void buttonModels_Click(object sender, EventArgs e)
        {
            InitRequestResponse();
            this.Update();

            Project proj = (Project)comboBoxProjects.SelectedItem;
            string project_id = proj.project_id;

            m_model_list = Glue.ModelList(m_authToken, project_id);

            // Show the request and response in the form. 
            // This is for learning purpose. 
            ShowRequestResponse();

            if (m_model_list == null) { return; }

            // Set up a model list
            m_model_list = m_model_list.OrderBy(x => x.model_name).ToList();
            comboBoxModels.DataSource = new BindingSource(m_model_list, null);
            comboBoxModels.DisplayMember = "model_name";
            comboBoxModels.ValueMember = "model_id";
            comboBoxModels.SelectedIndex = 0;
        }

        //=========================================================
        // Viewer
        // July 2016: deplicated.  
        // https://fieldofviewblog.wordpress.com/2015/05/06/google-chrome-drops-npapi-plugin-support/ 
        // TBD: maybe in future we will extend this portion to use Forge Viewer. 
        // If we do, however, it will be an advanced lab and not as intro. 
        //=========================================================
        private void buttonView_Click(object sender, EventArgs e)
        {
            InitRequestResponse();
            this.Update();

            Project proj = (Project)comboBoxProjects.SelectedItem;
            string project_id = proj.project_id;
            ModelInfo model = (ModelInfo)comboBoxModels.SelectedItem;
            string model_id = model.model_id;

            // The response we get here is URL that we embed in iframe. 
            // Let's see what we got by showing in the response text box.
            // If you take this string and copy&paste in a simple html 
            // file with an ifarme, you will see a model.
            // Note: viewer is not supported in windows control.
            // ScriptErrorsSuppressed is set to true to suppress script errors. 
            // We are using it here to learn web services API. 

            string url = Glue.View(m_authToken, project_id, model_id);

            textBoxRequest.Text = url;
            textBoxResponse.Text = "displaying model...";
            this.Update();

            // a view embedded form's web browser by URL.
            webBrowser1.Url = new System.Uri(url);

        }

    }
}
