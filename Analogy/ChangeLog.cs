﻿using DevExpress.XtraEditors;
using System;

namespace Philips.Analogy
{
    public partial class ChangeLog : XtraForm
    {
        public ChangeLog()
        {
            InitializeComponent();
        }

        private void sBtnOk_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
