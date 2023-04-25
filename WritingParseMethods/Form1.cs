using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WritingParseMethods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            /*
            //Parse Method for value Type
            Vertex vertex;

            bool success = Vertex.Parse("323, 444, 66", out vertex);

            this.Text = vertex.ToString();*/

            //Parse Mehtod for Reference Type
            Vertex vertex = Vertex.Parse("33, 33, 33");
            this.Text = vertex.ToString();
        }
    }
}
