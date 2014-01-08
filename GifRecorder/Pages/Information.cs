﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace ScreenToGif.Pages
{
    public partial class Information : UserControl
    {
        public Information()
        {
            InitializeComponent();

            this.labelVersion.Text = String.Format("Version: {0}", AssemblyVersion);
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        private void link1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start("http://www.codeproject.com/Articles/11505/NGif-Animated-GIF-Encoder-for-NET");
            }
            catch (Exception)
            {
                MessageBox.Show("Open this: http://www.codeproject.com/Articles/11505/NGif-Animated-GIF-Encoder-for-NET");
            }
        }

        private void link2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start("http://icons8.com/download-huge-windows8-set/");
            }
            catch (Exception)
            {
                MessageBox.Show("Open this: http://icons8.com/download-huge-windows8-set/");
                throw;
            }
        }

        private void linkCodeplex_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start("https://screentogif.codeplex.com/");
            }
            catch (Exception)
            {
                MessageBox.Show("Open this: https://screentogif.codeplex.com/");
                throw;
            }
        }
    }
}