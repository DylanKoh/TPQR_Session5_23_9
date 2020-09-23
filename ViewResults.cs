using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPQR_Session5_23_9.Properties;

namespace TPQR_Session5_23_9
{
    public partial class ViewResults : Form
    {
        List<string> moreGold = new List<string>();
        List<double> moreGoldMarks = new List<double>();
        List<string> moreSilver = new List<string>();
        List<double> moreSilverMarks = new List<double>();

        public ViewResults()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
            (new AdminMain()).ShowDialog();
            Close();
        }

        private void ViewResults_Load(object sender, EventArgs e)
        {
            LoadSkills();
        }
        private void LoadSkills()
        {
            dataGridView1.Rows.Clear();
            cbSkill.Items.Clear();
            using (var context = new Session5Entities())
            {
                var getSkills = (from x in context.Skills
                                 select x.skillName).ToArray();
                cbSkill.Items.AddRange(getSkills);
            }
        }

        private void cbSkill_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            lblCompleted.Text = 0.ToString();
            lblTotal.Text = 0.ToString();
            pbBronze1.Image = null;
            pbBronze2.Image = null;
            pbSilver1.Image = null;
            pbSilver2.Image = null;
            pbGold1.Image = null;
            pbGold2.Image = null;
            btnGold.Visible = false;
            btnSilver.Visible = false;
            btnBronze.Visible = false;
            using (var context = new Session5Entities())
            {
                var getSessions = (from x in context.Competitions
                                   where x.Skill.skillName == cbSkill.SelectedItem.ToString()
                                   select x);
                var totalMarks = (double)getSessions.Sum(x => x.q1MaxMarks + x.q2MaxMarks + x.q3MaxMarks + x.q4MaxMarks);
                var getTotalCompetitors = (from x in context.Skills
                                           where x.skillName == cbSkill.SelectedItem.ToString()
                                           select x.noOfCompetitors).FirstOrDefault();
                lblTotal.Text = getSessions.Count().ToString();
                foreach (var item in getSessions)
                {
                    var countResults = (from x in context.Results
                                        where x.competitionIdFK == item.competitionId
                                        select x).Count();
                    if (countResults == getTotalCompetitors)
                    {
                        lblTotal.Text = $"{int.Parse(lblTotal.Text) + 1}";
                    }
                }
                var getResults = (from x in context.Results
                                  where x.Competitor.Skill.skillName == cbSkill.SelectedItem.ToString()
                                  group new { x.totalMarks, x.Competitor.competitorCountry} by x.Competitor.competitorName into y
                                  select y);
                foreach (var item in getResults)
                {
                    var newRow = new List<string>()
                    {
                        item.Key, item.Select(x => x.competitorCountry).FirstOrDefault(),item.Sum(x => x.totalMarks).ToString()
                    };
                    dataGridView1.Rows.Add(newRow.ToArray());
                }
                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    if (Convert.ToDouble(dataGridView1[2, item.Index].Value) > totalMarks * 0.8)
                    {
                        if (moreGold.Count == 0)
                        {
                            pbGold1.Image = getFlags(dataGridView1[1, item.Index].Value.ToString());
                            moreGold.Add(dataGridView1[1, item.Index].Value.ToString());
                            moreGoldMarks.Add(Convert.ToDouble(dataGridView1[2, item.Index].Value));
                        }
                        else if (moreGold.Count == 1)
                        {

                        }
                        else
                        {

                        }
                    }
                }
            }
        }

        private Bitmap getFlags(string country)
        {
            var countryName = country.ToLower();
            switch (countryName)
            {
                case "singapore":
                    return Resources.singapore_flag1;
                case "malaysia":
                    return Resources.flagmalaysia;
                case "indonesia":
                    return Resources.indonesia2;
                case "philippines":
                    return Resources.flg_philippine1;
                case "thailand":
                    return Resources.flg_thailand;
                case "brunei":
                    return Resources.brunei_flag;
                case "cambodia":
                    return Resources.flag_cambodia;
                default:
                    return null;
            }
        }
    }
}
