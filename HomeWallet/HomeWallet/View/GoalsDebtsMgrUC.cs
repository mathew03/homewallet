using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using HomeWallet.Model;

namespace HomeWallet.View
{
    public partial class GoalsDebtsMgrUC : UserControl
    {
        public delegate void TargetsEventHandler(List<Target> targets);
        public delegate void TargetEventHandler(Target target);

        public event TargetsEventHandler DeleteTargets;
        public event TargetEventHandler AddTarget;
        public event TargetEventHandler EditTarget;
        public event EventHandler LoadTargets;
        public GoalsDebtsMgrUC()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            Visible = false;
        }

        private void button_deleteGoals_Click(object sender, EventArgs e)
        {
            if (checkedListBox_Goals.SelectedItems.Count == 0)
                return;

            List<Target> goalsToDelete = checkedListBox_Goals.SelectedItems.Cast<Target>().ToList();
            DeleteTargets?.Invoke(goalsToDelete);
        }

        private void button_AddGoal_Click(object sender, EventArgs e)
        {
            Target newGoal = new Target(textBox_GoalName.Text, int.Parse(textBox_GoalValue.Text), TargetType.Goal);
            AddTarget?.Invoke(newGoal);
        }

        private void button_EditGoal_Click(object sender, EventArgs e)
        {
            Target targetEdit = (Target)checkedListBox_Goals.SelectedItem;
            if (targetEdit == null)
                return;

            EditTarget?.Invoke(targetEdit);
        }

        private void button_DeleteDebts_Click(object sender, EventArgs e)
        {
            if (checkedListBox_Debts.SelectedItems.Count == 0)
                return;

            List<Target> debtsToDelete = checkedListBox_Debts.SelectedItems.Cast<Target>().ToList();
            DeleteTargets?.Invoke(debtsToDelete);
        }

        private void button_AddDebt_Click(object sender, EventArgs e)
        {
            Target newDebt = new Target(textBox_DebtName.Text, int.Parse(textBox_DebtValue.Text), TargetType.Debt);
            AddTarget?.Invoke(newDebt);
        }

        private void button_EditDebt_Click(object sender, EventArgs e)
        {
            Target targetEdit = (Target)checkedListBox_Debts.SelectedItem;
            if (targetEdit == null)
                return;

            EditTarget?.Invoke(targetEdit);
        }
    }
}
