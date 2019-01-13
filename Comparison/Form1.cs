using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comparison
{
    public partial class ETDComparison : Form
    {
        ComparisonViewModel _viewModel = new ComparisonViewModel();

        public ETDComparison()
        {           
            InitializeComponent();


  
            textBoxBusinessDate.DataBindings.Add("Text", _viewModel, "BusDate");

            var checkBoxList = (ListBox)checkedListBoxInstruments;
            checkBoxList.DataSource = _viewModel.Instruments;
            checkBoxList.DisplayMember = "Name";
            checkBoxList.ValueMember = "Checked";

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {

        }

        private void buttonExport_Click(object sender, EventArgs e)
        {

        }

        private void buttonRunTest_Click(object sender, EventArgs e)
        {

            var test = _viewModel.Instruments;
        }

        private void checkedListBoxInstruments_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBoxTypes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
