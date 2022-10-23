using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sentidos
{
    internal class BotonColor
    {
        //tableLayoutPanel_menuSentidos.BackColor = ColorTranslator.FromHtml("#1a2223");//negro
        //tableLayoutPanel_menuSentidos.BackColor = ColorTranslator.FromHtml("#cd7a7f");//rosa
        //tableLayoutPanel_menuSentidos.BackColor = ColorTranslator.FromHtml("#bb8a00");//dorado
        //tableLayoutPanel_menuSentidos.BackColor = ColorTranslator.FromHtml("#e9eaed");//gris

        public void colorBotonMenu(Button btn)
        {
            btn.BackColor = ColorTranslator.FromHtml("#1a2223");
            btn.ForeColor = Color.White;
            btn.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#1a2223");
            btn.FlatAppearance.MouseDownBackColor = ColorTranslator.FromHtml("#cd7a7f");
            btn.Font = new Font("Arial Narrow", 12, FontStyle.Bold);
        }
        public void colorBotonGeneral(Button btn)
        {
            btn.BackColor = ColorTranslator.FromHtml("#cd7a7f");
            btn.ForeColor = Color.White;
            btn.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#cd7a7f");
            btn.FlatAppearance.MouseDownBackColor = ColorTranslator.FromHtml("#1a2223");
            btn.Font = new Font("Arial Narrow", 12, FontStyle.Bold);
        }
    }
}
