using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedBuff_Kerkrade
{
    internal class PanelControl
    {
        public void TogglePanels(Control control, List<Panel> ExcludedPanels, params Panel[] activePanels)
        {
            // Traverse the control tree and toggle visibility of all panels except the active and permanently enabled ones
            foreach (Control c in control.Controls)
            {
                if (c is Panel panel)
                {
                    bool isActivePanel = activePanels.Contains(panel);
                    bool isPermanentlyEnabledPanel = ExcludedPanels.Contains(panel);

                    panel.Visible = isActivePanel || isPermanentlyEnabledPanel;
                    TogglePanelsChildControl(panel, isActivePanel || isPermanentlyEnabledPanel);
                }
                else
                {
                    TogglePanels(c, ExcludedPanels, activePanels);
                }
            }
        }

        private void TogglePanelsChildControl(Control control, bool visible)
        {
            // Recursively toggle visibility of child panels
            foreach (Control c in control.Controls)
            {
                if (c is Panel panel)
                {
                    panel.Visible = visible;
                    TogglePanelsChildControl(panel, visible);
                }
            }
        }

        public void ToggleChildPanel(Panel parentPanel, Panel selectedPanel, List<Panel> excludedPanels = null)
        {
            // Toggle the visibility of the selected panel and disable all other child panels except for the excluded panels
            foreach (Control childControl in parentPanel.Controls)
            {
                if (childControl is Panel childPanel)
                {
                    if (childPanel == selectedPanel)
                    {
                        childPanel.Visible = true;
                    }
                    else if (excludedPanels == null || !excludedPanels.Contains(childPanel))
                    {
                        childPanel.Visible = false;
                    }
                }
            }
        }
    }
}
