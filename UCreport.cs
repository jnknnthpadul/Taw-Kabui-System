using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taw_Kabui_Management_System
{
    public partial class UCreport : UserControl
    {
        private static UCreport _instance;
        public static UCreport Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UCreport();
                return _instance;
            }
        }
        public UCreport()
        {
            InitializeComponent();
        }
    }
}
