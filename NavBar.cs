using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spottyfy
{
    public partial class NavBar : Component
    {
        public NavBar()
        {
            InitializeComponent();
        }

        public NavBar(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
