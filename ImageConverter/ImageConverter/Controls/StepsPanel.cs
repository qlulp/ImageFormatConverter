using Guna.UI.WinForms;
using ImageConverter.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageConverter.Controls
{
    public partial class StepsPanel : UserControl
    {
        private const int CountOfSteps = 4;
        private int _CurrentStep = 1;
        public int CurrentStep
        {
            get => _CurrentStep;
            set
            {
                if (value <= CountOfSteps && value > 0)
                {
                    _CurrentStep = value;
                    UpdateView();
                }
            }
        }
        public StepsPanel()
        {
            InitializeComponent();
        }

        private void StepsPanel_Load(object sender, EventArgs e)
        {
            UpdateView();
        }

        public void UpdateView()
        {
            foreach (Panel panel in Controls.OfType<Panel>())
            {
                panel.BackColor = Configuration.CurrentTheme.StepPanelDisabledColor;
            }

            foreach (GunaElipsePanel panel in Controls.OfType<GunaElipsePanel>())
            {
                panel.BackColor = Color.Transparent;
                panel.BaseColor = Configuration.CurrentTheme.StepPanelDisabledColor;
            }

            foreach (Label label in Controls.OfType<Label>())
            {
                label.ForeColor = Configuration.CurrentTheme.StepPanelDisabledColor;
            }

            for (int i = 1; i <= CurrentStep; i++)
            {
                switch (i)
                {
                    case 1:
                        Tip1Label.ForeColor = Configuration.CurrentTheme.ActiveColor;
                        Step1Panel.BaseColor = Configuration.CurrentTheme.ActiveColor;
                        Line1.BackColor = Configuration.CurrentTheme.ActiveColor;
                        break;
                    case 2:
                        Tip2Label.ForeColor = Configuration.CurrentTheme.ActiveColor;
                        Step2Panel.BaseColor = Configuration.CurrentTheme.ActiveColor;
                        Line2.BackColor = Configuration.CurrentTheme.ActiveColor;
                        break;
                    case 3:
                        Tip3Label.ForeColor = Configuration.CurrentTheme.ActiveColor;
                        Step3Panel.BaseColor = Configuration.CurrentTheme.ActiveColor;
                        Line3.BackColor = Configuration.CurrentTheme.ActiveColor;
                        break;
                    case 4:
                        Tip4Label.ForeColor = Configuration.CurrentTheme.ActiveColor;
                        Step4Panel.BaseColor = Configuration.CurrentTheme.ActiveColor;
                        break;
                }
            }
        }
    }
}
