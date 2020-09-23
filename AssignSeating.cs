using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPQR_Session5_23_9
{
    public partial class AssignSeating : Form
    {
        public AssignSeating()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
            (new AdminMain()).ShowDialog();
            Close();
        }

        private void AssignSeating_Load(object sender, EventArgs e)
        {
            LoadSkills();
        }

        private void LoadSkills()
        {
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
            lbUnassigned.Items.Clear();
            lblAssigned.Text = 0.ToString();
            lblUnassigned.Text = 0.ToString();
            using (var context = new Session5Entities())
            {
                var getUnassigned = (from x in context.Competitors
                                     where x.assignedSeat == 0 && x.Skill.skillName == cbSkill.SelectedItem.ToString()
                                     select x);
                lblUnassigned.Text = getUnassigned.Count().ToString();
                foreach (var item in getUnassigned)
                {
                    lbUnassigned.Items.Add($"{item.competitorName}, {item.competitorCountry}");
                }
                var getTotal = (from x in context.Skills
                                where x.skillName == cbSkill.SelectedItem.ToString()
                                select x.noOfCompetitors).FirstOrDefault();
                if (getTotal % 2 == 0)
                {
                    var c1 = 1;
                    var c2 = 2;
                    for (int i = 1; i <= getTotal / 2; i++)
                    {
                        var newRow = new List<string>() { c1.ToString(), c2.ToString() };
                        dataGridView1.Rows.Add(newRow.ToArray());
                        c1 += 2;
                        c2 += 2;

                    }
                }
                else
                {
                    var c1 = 1;
                    var c2 = 2;
                    for (int i = 1; i <= (getTotal / 2) + 1; i++)
                    {
                        if (i != (getTotal / 2) + 1)
                        {
                            var newRow = new List<string>() { c1.ToString(), c2.ToString() };
                            dataGridView1.Rows.Add(newRow.ToArray());
                            c1 += 2;
                            c2 += 2;
                        }
                        else
                        {
                            var newRow = new List<string>() { c1.ToString(), "" };
                            dataGridView1.Rows.Add(newRow.ToArray());
                        }


                    }
                }

                var getAssigned = (from x in context.Competitors
                                   where x.Skill.skillName == cbSkill.SelectedItem.ToString() && x.assignedSeat != 0
                                   select x);
                lblAssigned.Text = getAssigned.Count().ToString();
                foreach (var item in getAssigned)
                {
                    var boolCheck = false;
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        foreach (DataGridViewColumn cell in dataGridView1.Columns)
                        {
                            if (dataGridView1[cell.Index, row.Index].Value.ToString() == item.assignedSeat.ToString())
                            {
                                dataGridView1[cell.Index, row.Index].Value = $"{item.assignedSeat}\n{item.competitorId}";
                                dataGridView1[cell.Index, row.Index].Style.ForeColor = Color.White;
                                dataGridView1[cell.Index, row.Index].Style.BackColor = Color.Blue;
                                boolCheck = true;
                            }
                            if (boolCheck)
                            {
                                break;
                            }
                        }
                        if (boolCheck)
                        {
                            break;
                        }
                    }
                }

            }
        }

        private void btnManualAssign_Click(object sender, EventArgs e)
        {
            if (lbUnassigned.SelectedItem == null || dataGridView1.SelectedCells.Count != 1)
            {
                MessageBox.Show("Please select only one competitor and one seat!");
            }
            else
            {
                using (var context = new Session5Entities())
                {
                    if (dataGridView1[dataGridView1.CurrentCell.ColumnIndex, dataGridView1.CurrentCell.RowIndex].Style.BackColor == Color.Blue)
                    {
                        var getAssignedID = dataGridView1.CurrentCell.Value.ToString().Split('\n')[1];
                        var seatNumber = dataGridView1.CurrentCell.Value.ToString().Split('\n')[0];
                        var getToAssign = (from x in context.Competitors
                                           where lbUnassigned.SelectedItem.ToString().Contains(x.competitorName + ", " + x.competitorCountry) && x.Skill.skillName == cbSkill.SelectedItem.ToString()
                                           select x).FirstOrDefault();
                        var getToUnassign = (from x in context.Competitors
                                             where getAssignedID == x.competitorId && x.Skill.skillName == cbSkill.SelectedItem.ToString()
                                             select x).FirstOrDefault();
                        var boolCheck = checkRules(dataGridView1.CurrentCell, getToAssign);
                        if (boolCheck == false)
                        {
                            MessageBox.Show("Unable to assign as front or/and back has a competitor of the same country!");
                        }
                        else
                        {
                            dataGridView1.CurrentCell.Value = $"{seatNumber}\n{getToAssign.competitorId}";
                            lbUnassigned.Items.Add($"{getToUnassign.competitorName}, {getToUnassign.competitorCountry}");
                            lbUnassigned.Items.Remove(lbUnassigned.SelectedItem);
                        }
                    }
                    else
                    {
                        var seatNumber = dataGridView1.CurrentCell.Value.ToString().Split('\n')[0];
                        var getToAssign = (from x in context.Competitors
                                           where lbUnassigned.SelectedItem.ToString().Contains(x.competitorName + ", " + x.competitorCountry) && x.Skill.skillName == cbSkill.SelectedItem.ToString()
                                           select x).FirstOrDefault();
                        var boolCheck = checkRules(dataGridView1.CurrentCell, getToAssign);
                        if (boolCheck == false)
                        {
                            MessageBox.Show("Unable to assign as front or/and back has a competitor of the same country!");
                        }
                        else
                        {
                            dataGridView1.CurrentCell.Value = $"{seatNumber}\n{getToAssign.competitorId}";
                            dataGridView1.CurrentCell.Style.BackColor = Color.Blue;
                            dataGridView1.CurrentCell.Style.ForeColor = Color.White;
                            lbUnassigned.Items.Remove(lbUnassigned.SelectedItem);
                            lblAssigned.Text = $"{int.Parse(lblAssigned.Text) + 1}";
                            lblUnassigned.Text = $"{int.Parse(lblUnassigned.Text) - 1}";
                        }
                    }
                }

            }
        }

        private bool checkRules(DataGridViewCell dataGridViewCell, Competitor toAssign)
        {
            using (var context = new Session5Entities())
            {
                var rowIndex = dataGridViewCell.RowIndex;
                if (rowIndex == 0)
                {
                    if (dataGridView1[dataGridViewCell.ColumnIndex, dataGridViewCell.RowIndex + 1].Style.BackColor == Color.Blue)
                    {
                        var getBottom = dataGridView1[dataGridViewCell.ColumnIndex, dataGridViewCell.RowIndex + 1].Value.ToString().Split('\n')[1];
                        var checkBottom = (from x in context.Competitors
                                           where x.Skill.skillName == cbSkill.SelectedItem.ToString() && x.competitorId == getBottom
                                           select x.competitorCountry).FirstOrDefault();
                        if (checkBottom == toAssign.competitorCountry)
                        {
                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    }
                    else
                    {
                        return true;
                    }

                }
                else if (rowIndex == dataGridView1.Rows.Count - 1)
                {
                    if (dataGridView1[dataGridViewCell.ColumnIndex, dataGridViewCell.RowIndex - 1].Style.BackColor == Color.Blue)
                    {
                        var getAbove = dataGridView1[dataGridViewCell.ColumnIndex, dataGridViewCell.RowIndex - 1].Value.ToString().Split('\n')[1];
                        var checkAbove = (from x in context.Competitors
                                          where x.Skill.skillName == cbSkill.SelectedItem.ToString() && x.competitorId == getAbove
                                          select x.competitorCountry).FirstOrDefault();
                        if (checkAbove == toAssign.competitorCountry)
                        {
                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    }
                    else
                    {
                        return true;
                    }
                }
                else
                {
                    var checkBottom = string.Empty;
                    var checkAbove = string.Empty;
                    if (dataGridView1[dataGridViewCell.ColumnIndex, dataGridViewCell.RowIndex + 1].Style.BackColor == Color.Blue)
                    {
                        var getBottom = dataGridView1[dataGridViewCell.ColumnIndex, dataGridViewCell.RowIndex + 1].Value.ToString().Split('\n')[1];
                        checkBottom = (from x in context.Competitors
                                       where x.Skill.skillName == cbSkill.SelectedItem.ToString() && x.competitorId == getBottom
                                       select x.competitorCountry).FirstOrDefault();
                    }
                    if (dataGridView1[dataGridViewCell.ColumnIndex, dataGridViewCell.RowIndex - 1].Style.BackColor == Color.Blue)
                    {
                        var getAbove = dataGridView1[dataGridViewCell.ColumnIndex, dataGridViewCell.RowIndex - 1].Value.ToString().Split('\n')[1];
                        checkAbove = (from x in context.Competitors
                                      where x.Skill.skillName == cbSkill.SelectedItem.ToString() && x.competitorId == getAbove
                                      select x.competitorCountry).FirstOrDefault();
                    }
                    if (checkAbove == toAssign.competitorCountry || checkBottom == toAssign.competitorCountry)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }

        }

        private void btnSwapSeat_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count != 2)
            {
                MessageBox.Show("Please select 2 assigned seatings to swap!");
            }
            else
            {
                var checkAssignmentBool = true;
                foreach (DataGridViewCell item in dataGridView1.SelectedCells)
                {
                    if (item.Style.BackColor != Color.Blue)
                    {
                        checkAssignmentBool = false;
                    }
                    if (checkAssignmentBool == false)
                    {
                        break;
                    }
                }
                if (checkAssignmentBool == false)
                {
                    MessageBox.Show("Ensure that the seats are already assigned!");
                }
                else
                {
                    using (var context = new Session5Entities())
                    {
                        var firstSeat = dataGridView1.SelectedCells[0].Value.ToString().Split('\n')[0];
                        var getAssigned1ID = dataGridView1.SelectedCells[0].Value.ToString().Split('\n')[1];
                        var secondSeat = dataGridView1.SelectedCells[1].Value.ToString().Split('\n')[0];
                        var getAssigned2ID = dataGridView1.SelectedCells[1].Value.ToString().Split('\n')[1];
                        var getAssigned1 = (from x in context.Competitors
                                            where x.competitorId == getAssigned1ID && x.Skill.skillName == cbSkill.SelectedItem.ToString()
                                            select x).FirstOrDefault();
                        var getAssigned2 = (from x in context.Competitors
                                            where x.competitorId == getAssigned2ID && x.Skill.skillName == cbSkill.SelectedItem.ToString()
                                            select x).FirstOrDefault();
                        var boolCheck1 = checkRules(dataGridView1.SelectedCells[1], getAssigned1);
                        var boolCheck2 = checkRules(dataGridView1.SelectedCells[0], getAssigned2);
                        if (boolCheck1 && boolCheck2)
                        {
                            dataGridView1.SelectedCells[0].Value = $"{firstSeat}\n{getAssigned2.competitorId}";
                            dataGridView1.SelectedCells[1].Value = $"{secondSeat}\n{getAssigned1.competitorId}";
                        }
                        else
                        {
                            MessageBox.Show("Unable to assign as front or/and back has a competitor of the same country!");
                        }
                    }
                }
            }
        }

        private void btnRandomAssign_Click(object sender, EventArgs e)
        {
            var checkBool = random();
            if (checkBool == false)
            {
                random();
            }
        }

        private bool random()
        {
            var getUnassigned = new List<DataGridViewCell>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewColumn cell in dataGridView1.Columns)
                {
                    if (dataGridView1[cell.Index, row.Index].Style.BackColor != Color.Blue && dataGridView1[cell.Index, row.Index].Value.ToString() != "")
                    {
                        getUnassigned.Add(dataGridView1[cell.Index, row.Index]);
                    }
                }
            }
            var random = new Random();
            var toRemove = new List<string>();
            foreach (var item in lbUnassigned.Items)
            {
                using (var context = new Session5Entities())
                {
                    var randInx = random.Next(0, getUnassigned.Count);
                    var newSeat = getUnassigned[randInx];
                    var getToAssign = (from x in context.Competitors
                                       where item.ToString().Contains(x.competitorName + ", " + x.competitorCountry) && x.Skill.skillName == cbSkill.SelectedItem.ToString()
                                       select x).FirstOrDefault();
                    var boolCheck = checkRules(newSeat, getToAssign);
                    if (boolCheck)
                    {
                        dataGridView1[newSeat.ColumnIndex, newSeat.RowIndex].Value = $"{newSeat.Value.ToString().Split('\n')[0]}\n{getToAssign.competitorId}";
                        dataGridView1[newSeat.ColumnIndex, newSeat.RowIndex].Style.ForeColor = Color.White;
                        dataGridView1[newSeat.ColumnIndex, newSeat.RowIndex].Style.BackColor = Color.Blue;
                        lblAssigned.Text = $"{int.Parse(lblAssigned.Text) + 1}";
                        lblUnassigned.Text = $"{int.Parse(lblUnassigned.Text) - 1}";
                        getUnassigned.Remove(newSeat);
                        toRemove.Add(item.ToString());
                    }
                    else
                    {
                        continue;
                    }
                }

            }
            foreach (var item in toRemove)
            {
                lbUnassigned.Items.Remove(item);
            }
            if (lbUnassigned.Items.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewColumn cell in dataGridView1.Columns)
                {
                    if (dataGridView1[cell.Index, row.Index].Style.BackColor == Color.Blue)
                    {
                        using (var context = new Session5Entities())
                        {
                            var getSeat = int.Parse(dataGridView1[cell.Index, row.Index].Value.ToString().Split('\n')[0]);
                            var getID = dataGridView1[cell.Index, row.Index].Value.ToString().Split('\n')[1];
                            var toAssign = (from x in context.Competitors
                                            where x.Skill.skillName == cbSkill.SelectedItem.ToString() && x.competitorId == getID
                                            select x).FirstOrDefault();
                            toAssign.assignedSeat = getSeat;
                            context.SaveChanges();
                        }
                    }
                }
            }

            foreach (var item in lbUnassigned.Items)
            {
                using (var context = new Session5Entities())
                {
                    var toUnassign = (from x in context.Competitors
                                      where item.ToString().Contains(x.competitorName + ", " + x.competitorCountry) && x.Skill.skillName == cbSkill.SelectedItem.ToString()
                                      select x).FirstOrDefault();
                    toUnassign.assignedSeat = 0;
                    context.SaveChanges();
                }
            }
            MessageBox.Show("Assigned seats successfully!");

        }
    }
}
