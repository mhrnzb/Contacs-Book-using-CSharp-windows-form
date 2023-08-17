using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactsBook
{
    public partial class frmAddOrEdit : Form
    {
        ContactsRepository repository; 



        public frmAddOrEdit()
        {
            InitializeComponent();

            repository = new ContactsRepository();
        }


        bool ValidateInputs()
        {
            

            if (txtName.Text == "")
            {
                
                MessageBox.Show("لطفا نام را وارد کنید ", "هشدار", MessageBoxButtons.OK , MessageBoxIcon.Error);
                return false;
            }

            if (txtEmail.Text == "")
            {

                MessageBox.Show("لطفا ایمیل  را وارد کنید ", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtFamily.Text == "")
            {

                MessageBox.Show("لطفا نام خانوادگی  را وارد کنید ", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtAge.Value == 0)
            {

                MessageBox.Show("لطفا سن  را وارد کنید ", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtMobile.Text == "")
            {

                MessageBox.Show("لطفا موبایل  را وارد کنید ", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }



            return true; 
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {//btnSubmit
            if (ValidateInputs())
            {

            }
        }
    }
}
