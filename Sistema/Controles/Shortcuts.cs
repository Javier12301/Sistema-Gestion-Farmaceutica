﻿using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Sistema.Controles
{
    public class Shortcuts
    {

        //Shortcuts para limpiar texto hasta el espacio
        public void LimpiarTextoHastaelEspacio(TextBoxBase txtSelected, KeyEventArgs e)
        {
            
            if ((e.KeyCode == Keys.Back) && e.Control)
            {
                e.SuppressKeyPress = true;
                int selStart = txtSelected.SelectionStart;
                while (selStart > 0 && txtSelected.Text.Substring(selStart - 1, 1) == " ")
                {
                    selStart--;
                }
                int prevSpacePos = -1;
                if (selStart != 0)
                {
                    prevSpacePos = txtSelected.Text.LastIndexOfAny(new char[] { ' ', '@', '.' }, selStart - 1);
                }
                txtSelected.Select(prevSpacePos + 1, txtSelected.SelectionStart - prevSpacePos - 1);
                txtSelected.SelectedText = "";
            }
        }        




    }
}
