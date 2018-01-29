using CalcDB.Repositories;
using CalcLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopCalc
{
    public partial class Form1 : Form
    {

        private Calc Calc { set; get; }
        public Form1()
        {
            InitializeComponent();
            Calc = new Calc();
        }
        //заметка:
        //Алан Купер - отмена выполненной операций лучше, чем куча вопросов Вы уверены?
        private void Form1_Load(object sender, EventArgs e)
        {
            lbOperations.Items.Clear();
            lbOperations.Items.AddRange(Calc.GetOperationNames());
            //timer1.Start();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            if (lbOperations.SelectedItem == null)
                return;
            var oper = lbOperations.SelectedItem.ToString();
            var result = Calc.Exec(oper, tbInput.Text.Trim().Split(' '));
            label1.Text = result.ToString();

            #region Сохранение в БД

            var or = new CalcDB.Models.OperationResult()
            {
                OperationId = lbOperations.SelectedIndex,
                Result = result,
                ExecutionTime = new Random().Next(100, 4000),
                Error = "",
                Args = tbInput.Text.Trim()
            };

            var operResultRepository = new OperResultRepository();
            operResultRepository.Save(or);

            //operResultRepository.Get(3);
            //operResultRepository.GetAll();
            //operResultRepository.GetByOperation(4);
            operResultRepository.Delete(3);

            #endregion
        }

        private void lbOperations_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbInput.Enabled = lbOperations.SelectedItems != null;
        }

        string s1 = "";

        private void tbInput_TextChanged(object sender, EventArgs e)
        {
            btnClick.Enabled = !string.IsNullOrWhiteSpace(tbInput.Text);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string s2 = tbInput.Text;

            if (s1 != s2)
            {
                if (lbOperations.SelectedItem == null)
                    return;
                var oper = lbOperations.SelectedItem.ToString();
                var result = Calc.Exec(oper, tbInput.Text.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
                label1.Text = result.ToString();
            }
            s1 = s2;
        }

        private void tbInput_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.X < 5)
                tbInput.Text = "";
        }
    }
}
