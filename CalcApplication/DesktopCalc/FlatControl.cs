using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.Design;

namespace DesktopCalc
{
    [Designer("System.Windows.Forms.Design.ParentControlDesigner, System.Design", typeof(IDesigner))]
    public partial class FlatControl : Panel
    {

        //protected override void OnControlAdded(ControlEventArgs e)
        //{
        //    //base.OnControlAdded(e);
        //    panel1.Controls.Add(e.Control);
        //}

        //protected override void OnControlRemoved(ControlEventArgs e)
        //{
        //    //base.OnControlRemoved(e);
        //    panel1.Controls.Remove(e.Control);
        //}
        public string Caption
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }
        public FlatControl()
        {
            InitializeComponent();
        }
    }
}
