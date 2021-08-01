using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusTicketBookingApplication
{
    public partial class Form1 : Form
    {
        Button btn = new Button();

        int NoOf_FamilyMembers;
        List<int> ages = new List<int>();
        int sum1, sum2, sum3, TotalSum;
       
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonMembersAge_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(textBoxNoOfMembers.Text))
            {

                NoOf_FamilyMembers = int.Parse(textBoxNoOfMembers.Text);
                int PositionX_Label = 180;
                int PositionY = 200;
                int PositionX_TextBox = 380;

                for (int i = 0; i < NoOf_FamilyMembers; i++)
                {
                    Label lbl = new Label();
                    TextBox txt = new TextBox();

                    this.Controls.Add(lbl);
                    this.Controls.Add(txt);

                    lbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                    lbl.Location = new Point(PositionX_Label, PositionY);
                    lbl.Size = new Size(193, 36);
                    lbl.Text = "Member : " + (i + 1).ToString();
                    lbl.TextAlign = ContentAlignment.MiddleCenter;

                    txt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                    txt.Location = new Point(PositionX_TextBox, PositionY);
                    txt.Size = new Size(134, 28);
                    txt.Name = "textboxAge" + i.ToString();
                    txt.TextAlign = HorizontalAlignment.Center;

                    PositionY += 30;
                }
                btn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                btn.Name = "buttonCalculate";
                btn.Text = "Calculate Amount";
                btn.Size = new Size(172, 44);
                btn.Location = new Point(577, 385);

            }

          
            btn.Click += (s, e1) =>
            {
                for (int i = 1; i <= NoOf_FamilyMembers; i++)
                {
                    TextBox txtage = (TextBox)this.Controls.Find("textboxAge" + i.ToString(), true)[0];
                    if (txtage != null)
                    {
                        ages.Add(int.Parse(txtage.Text));
                        if (int.Parse(txtage.Text) < 5)
                        {
                            sum1++;
                        }
                        if (int.Parse(txtage.Text) >= 6 && int.Parse(txtage.Text) <= 12)
                        {
                            sum2++;
                        }
                        if (int.Parse(txtage.Text) >= 13)
                        {
                            sum3++;
                        }
                    }
                }
                TotalSum = (sum1 * 50) + (sum2 * 100) + (sum3 * 300);
                MessageBox.Show("The total amount of " + NoOf_FamilyMembers + " to pay for bus ticket is = " + TotalSum.ToString());


            };
            Controls.Add(btn);
        }

        
    }

    
}

