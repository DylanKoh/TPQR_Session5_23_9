using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPQR_Session5_23_9
{
    public partial class EnterMarks : Form
    {
        public EnterMarks()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                if (dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString() == "Gd")
                {
                    dataGridView1[3, e.RowIndex].Value = Convert.ToDouble(dataGridView1[1, e.RowIndex].Value);
                }
                else if (dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString() == "Av")
                {
                    dataGridView1[3, e.RowIndex].Value = Convert.ToDouble(dataGridView1[1, e.RowIndex].Value) * 0.65;
                }
                else
                {
                    dataGridView1[3, e.RowIndex].Value = Convert.ToDouble(dataGridView1[1, e.RowIndex].Value) * 0.20;
                }
                CalculateTotal();
            }
        }

        private void CalculateTotal()
        {
            var total = 0.0;
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                total += Convert.ToDouble(dataGridView1[3, item.Index].Value);
            }
            lblTotal.Text = total.ToString();
        }

        private void EnterMarks_Load(object sender, EventArgs e)
        {
            LoadSkills();
        }
        private void LoadSkills()
        {
            lblTotal.Text = 0.ToString();
            dataGridView1.Rows.Clear();
            cbSkill.Items.Clear();
            cbCompetitorName.Items.Clear();
            cbSessionNo.Items.Clear();
            using (var context = new Session5Entities())
            {
                var getSkills = (from x in context.Skills
                                 select x.skillName).ToArray();
                cbSkill.Items.AddRange(getSkills);
            }
        }

        private void cbSessionNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTotal.Text = 0.ToString();
            dataGridView1.Rows.Clear();
            cbCompetitorName.Items.Clear();
            using (var context = new Session5Entities())
            {
                var getCompetitors = (from x in context.Competitors
                                      where x.Skill.skillName == cbSkill.SelectedItem.ToString()
                                      select x.competitorName).ToArray();
                cbCompetitorName.Items.AddRange(getCompetitors);
            }
        }

        private void cbSkill_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTotal.Text = 0.ToString();
            dataGridView1.Rows.Clear();
            cbCompetitorName.Items.Clear();
            cbSessionNo.Items.Clear();
            using (var context = new Session5Entities())
            {
                var getSessionNo = (from x in context.Competitions
                                    where x.Skill.skillName == cbSkill.SelectedItem.ToString()
                                    select x.sessionNo.ToString()).ToArray();
                cbSessionNo.Items.AddRange(getSessionNo);
            }
        }

        private void cbCompetitorName_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTotal.Text = 0.ToString();
            dataGridView1.Rows.Clear();
            using (var context = new Session5Entities())
            {
                var getCompetiton = (from x in context.Competitions
                                     where x.Skill.skillName == cbSkill.SelectedItem.ToString()
                                     where x.sessionNo.ToString() == cbSessionNo.SelectedItem.ToString()
                                     select x).FirstOrDefault();
                if (getCompetiton.q1MaxMarks != 0)
                {
                    var newRow = new List<string>()
                    {
                        "Question 1", getCompetiton.q1MaxMarks.ToString(), "", "0"
                    };
                    dataGridView1.Rows.Add(newRow.ToArray());
                }
                if (getCompetiton.q2MaxMarks != 0)
                {
                    var newRow = new List<string>()
                    {
                        "Question 2", getCompetiton.q2MaxMarks.ToString(), "", "0"
                    };
                    dataGridView1.Rows.Add(newRow.ToArray());
                }
                if (getCompetiton.q3MaxMarks != 0)
                {
                    var newRow = new List<string>()
                    {
                        "Question 3", getCompetiton.q3MaxMarks.ToString(), "", "0"
                    };
                    dataGridView1.Rows.Add(newRow.ToArray());
                }
                if (getCompetiton.q4MaxMarks != 0)
                {
                    var newRow = new List<string>()
                    {
                        "Question 4", getCompetiton.q4MaxMarks.ToString(), "", "0"
                    };
                    dataGridView1.Rows.Add(newRow.ToArray());
                }
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cbCompetitorName_SelectedIndexChanged(null, null);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            using (var context = new Session5Entities())
            {
                var getCompetitor = (from x in context.Competitors
                                     where x.Skill.skillName == cbSkill.SelectedItem.ToString() && x.competitorName == cbCompetitorName.SelectedItem.ToString()
                                     select x).FirstOrDefault();
                var getCompetition = (from x in context.Competitions
                                      where x.sessionNo.ToString() == cbSessionNo.SelectedItem.ToString() && x.Skill.skillName == cbSkill.SelectedItem.ToString()
                                      select x).FirstOrDefault();
                var newResult = new Result()
                {
                    competitionIdFK = getCompetition.competitionId,
                    recordsIdFK = getCompetitor.recordsId,
                    totalMarks = double.Parse(lblTotal.Text)
                };
                if (getCompetition.q1MaxMarks != 0)
                {
                    foreach (DataGridViewRow item in dataGridView1.Rows)
                    {
                        if (dataGridView1[0, item.Index].Value.ToString() == "Question 1")
                        {
                            newResult.q1Marks = Convert.ToDouble(dataGridView1[3, item.Index].Value);
                        }
                    }
                }
                else
                {
                    newResult.q1Marks = 0;
                }
                if (getCompetition.q2MaxMarks != 0)
                {
                    foreach (DataGridViewRow item in dataGridView1.Rows)
                    {
                        if (dataGridView1[0, item.Index].Value.ToString() == "Question 2")
                        {
                            newResult.q2Marks = Convert.ToDouble(dataGridView1[3, item.Index].Value);
                        }
                    }
                }
                else
                {
                    newResult.q2Marks = 0;
                }
                if (getCompetition.q3MaxMarks != 0)
                {
                    foreach (DataGridViewRow item in dataGridView1.Rows)
                    {
                        if (dataGridView1[0, item.Index].Value.ToString() == "Question 3")
                        {
                            newResult.q3Marks = Convert.ToDouble(dataGridView1[3, item.Index].Value);
                        }
                    }
                }
                else
                {
                    newResult.q3Marks = 0;
                }
                if (getCompetition.q4MaxMarks != 0)
                {
                    foreach (DataGridViewRow item in dataGridView1.Rows)
                    {
                        if (dataGridView1[0, item.Index].Value.ToString() == "Question 4")
                        {
                            newResult.q4Marks = Convert.ToDouble(dataGridView1[3, item.Index].Value);
                        }
                    }
                }
                else
                {
                    newResult.q4Marks = 0;
                }
                context.Results.Add(newResult);
                context.SaveChanges();
                MessageBox.Show("Saved results!");
                LoadSkills();

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
            (new AdminMain()).ShowDialog();
            Close();
        }
    }
}
