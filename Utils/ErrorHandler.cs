﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banditlord
{
    class ErrorHandler
    {

        public static void HandleException(Exception e)
        {
            MessageBox.Show(e.Message);
        }

    }
}