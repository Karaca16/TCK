using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCK
{
    public partial class frm_questions : Form
    {
        public frm_questions()
        {
            InitializeComponent();
        }
        String Suc1 = "", Suc2 = "";
        void Crime1()
        { 

        }

        private void frm_questions_Load(object sender, EventArgs e)
        {
            lbl_crime1.Text = frm_TCK_ANASAYFA.Crime1;
            lbl_crime2.Text = frm_TCK_ANASAYFA.Crime2;
            Suc1 = frm_TCK_ANASAYFA.Suc1;
            Suc2 = frm_TCK_ANASAYFA.Suc2;
            if (Suc1 == "0000" || Suc1 == "0001")  //1.KISIM 1.BÖLÜM -- SOYKIRIM a) b)
            {
                grp1.Visible = true;
            }

            if (Suc1 == "0002" || Suc1 == "0003" || Suc1 == "0004") //1.KISIM 1.BÖLÜM -- SOYKIRIM c) d) e)
            {
                
                
            }
        }

    }
}
