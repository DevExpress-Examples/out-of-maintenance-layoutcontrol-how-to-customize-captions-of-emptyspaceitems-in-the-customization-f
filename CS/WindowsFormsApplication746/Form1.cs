using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Customization.Controls;

namespace WindowsFormsApplication746 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            layoutControl1.ShowCustomization += layoutControl1_ShowCustomization;
        }

        protected override void OnShown(EventArgs e) {
            layoutControl1.ShowCustomizationForm();
        }

        void layoutControl1_ShowCustomization(object sender, EventArgs e) {
            TabbedControlGroup group = GetCustomizationWindowTabbedControlGroup(sender as LayoutControl);
            if(group != null) {
                group.SelectedPageChanged += group_SelectedPageChanged;
            }
            group.SelectedTabPageIndex = 1; //for this example only. Remove this code in your application
        }

        private TabbedControlGroup GetCustomizationWindowTabbedControlGroup(LayoutControl layoutControl) {
            var lcControls = layoutControl.CustomizationForm.Controls.OfType<LayoutControl>().ToArray<LayoutControl>();
            if(lcControls.Count() == 0)
                return null;
            var tcgControls = lcControls[0].Items.OfType<TabbedControlGroup>().ToArray<TabbedControlGroup>();
            if(tcgControls.Count() == 0)
                return null;
            return tcgControls[0];
        }

        void group_SelectedPageChanged(object sender, LayoutTabPageChangedEventArgs e) {
            LayoutControlItem layoutControlItem = e.Page.Items[0] as LayoutControlItem;
            LayoutTreeView tree = layoutControlItem.Control as LayoutTreeView;
            if(tree == null) return;
            foreach(BaseLayoutItemTreeNode item in tree.Nodes[0].Nodes) {
                EmptySpaceItem esItem = (item as BaseLayoutItemTreeNode).Item as EmptySpaceItem;
                if(esItem != null) {
                    item.Text = "\"" + esItem.CustomizationFormText + "\""; //customize captions here
                }
            }
        }
    }
}
