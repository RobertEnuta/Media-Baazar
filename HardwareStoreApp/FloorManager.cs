using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HardwareStoreApp
{
    public partial class FloorManager : Form
    {
        // The save button will be hidden unless the admin clicks add or selects an employee on the list (which will allow him to edit said employees information)
        // furthermore all editing options aswell as the list itself will be hidden to a normal employee and the the fields will all be set to read only
        // also we gotta figure out a way to add admin accounts

        // VERY IMPORTANT TO WHOEVER IS CODING THIS: do input validation on everything u can imagine and test it twice. I coded smthn similar and it was very bug prone
        // -Ben


        public FloorManager()
        {
            InitializeComponent();
        }
    }
}
