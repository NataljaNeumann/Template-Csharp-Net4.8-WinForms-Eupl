/*  Template v0.0
    Copyright (C) 2026 NataljaNeumann@gmx.de
    Licensed under the EUPL
*/

using System;
using System.Windows.Forms;

namespace Template
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            ThemeManager.Attach(this);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
