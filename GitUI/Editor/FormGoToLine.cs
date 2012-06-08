using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GitUI.Editor
{
    public partial class FormGoToLine : GitExtensionsForm
    {
        public FormGoToLine()
        {
            InitializeComponent();
            Translate();
        }

        public int GetLineNumber()
        {
            return (int)LineNumberUpDown.Value;
        }

        public void SetMaxLineNumber(int maxLineNumber)
        {
            LineNumberUpDown.Maximum = maxLineNumber;
            lineLabel.Text = lineLabel.Text + " (1 - " + maxLineNumber.ToString() + "):"; 
        }

        private void FormGoToLine_Load(object sender, EventArgs e)
        {
            LineNumberUpDown.Select(0, LineNumberUpDown.ToString().Length);
        }


    }
}
