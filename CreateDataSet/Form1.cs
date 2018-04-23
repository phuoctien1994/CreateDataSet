using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateDataSet
{
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            btnCreate.Click += BtnCreate_Click;
            btnClear.Click += BtnClear_Click;
            btnName.Click += BtnName_Click;
            btnValue.Click += BtnValue_Click;
            btnInsert.Click += BtnInsert_Click;
            btnUpdate.Click += BtnUpdate_Click;
            btnGetDataByCondition.Click += BtnGetDataByCondition_Click;
            btnSaveData2.Click += BtnSaveData2_Click;
            btnClear.Click += BtnClear_Click1;
        }

        private void BtnClear_Click1(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            txtAddNewAndValue.Text = string.Empty;
            txtParamName.Text = string.Empty;
            txtParamValue.Text = string.Empty;
            txtReturn.Text = string.Empty;
            txtStore.Text = string.Empty;
        }

        private void BtnSaveData2_Click(object sender, EventArgs e)
        {
            txtClass.Text = Regex.Replace(txtClass.Text.Trim(), @"\t|\n|\r|", "");
            txtStore.Text = Regex.Replace(txtStore.Text.Trim(), @"\t|\n|\r|", "");

            txtParamName.Text = Regex.Replace(txtParamName.Text.Trim(), @"\t|\n|\r| ", "");
            txtParamName.Text = Regex.Replace(txtParamName.Text.Trim(), ",", ", ");

            txtParamValue.Text = Regex.Replace(txtParamValue.Text.Trim(), @"\t|\n|\r| ", "");
            txtParamValue.Text = Regex.Replace(txtParamValue.Text.Trim(), ",", ", ");

            string strReturn = "_CommunicateClass.RunFunctionStr(Services.MailerManagement, \"SaveData2\"," + Environment.NewLine +
                                "                               new object[] { Globals.ACCESS_KEY(), " + txtClass.Text.Trim() + txtStore.Text.Trim() + "," + Environment.NewLine +
                                "                                       new string[] { " + txtParamName.Text.Trim() + " }," + Environment.NewLine +
                                "                                       new object[] { " + txtParamValue.Text.Trim() + " } });";
            //strReturn = Regex.Replace(strReturn, @"\t|\n|\r|", "");
            txtReturn.Text = strReturn;
        }

        private void BtnGetDataByCondition_Click(object sender, EventArgs e)
        {
            txtClass.Text =  Regex.Replace(txtClass.Text.Trim(), @"\t|\n|\r|", "");
            txtStore.Text = Regex.Replace(txtStore.Text.Trim(), @"\t|\n|\r|", "");

            txtParamName.Text = Regex.Replace(txtParamName.Text.Trim(), @"\t|\n|\r| ", "");
            txtParamName.Text = Regex.Replace(txtParamName.Text.Trim(), ",", ", ");

            txtParamValue.Text = Regex.Replace(txtParamValue.Text.Trim(), @"\t|\n|\r| ", "");
            txtParamValue.Text = Regex.Replace(txtParamValue.Text.Trim(), ",", ", ");

            string strReturn =  "_CommunicateClass.RunFunctionDS(Services.MailerManagement, \"GetDataByCondition\"," + Environment.NewLine +
                                "                               new object[] { Globals.ACCESS_KEY(), " + txtClass.Text.Trim() + txtStore.Text.Trim() + ","+ Environment.NewLine +
                                "                                       new string[] { " + txtParamName.Text.Trim() + " },"+ Environment.NewLine +
                                "                                       new object[] { " + txtParamValue.Text.Trim() + " } });";
            //strReturn = Regex.Replace(strReturn, @"\t|\n|\r|", "");
            txtReturn.Text = strReturn;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            string store = txtAddNewAndValue.Text.Trim();
            txtReturn.Text = "base.StatusText = Messages.STATUS_UPDATE;\nDataSet ds = CreateDataSet();\nstring strDataset = StringHelper.DataSetToString(ds);\n"
                 + "object[] args = new object[]{Globals.ACCESS_KEY(),\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tnew string[]{\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t" + store + "\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t}" +
                 ",\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tstrDataset};\n" +
                 "string strReturn = _CommunicateClass.RunFunctionStr(Services.MailerManagement, \"SaveData\", args);\narr_Argument_Of_bw.Add(strReturn);\ne.Result = arr_Argument_Of_bw;\nbreak;";
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            string store = txtAddNewAndValue.Text.Trim();
            txtReturn.Text = "base.StatusText = Messages.STATUS_INSERT;\nDataSet ds = CreateDataSet();\nstring strDataset = StringHelper.DataSetToString(ds);\n"
                 + "object[] args = new object[]{Globals.ACCESS_KEY(),\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tnew string[]{\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t" + store + "\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t}" + 
                 ",\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tstrDataset};\n" +
                 "string strReturn = _CommunicateClass.RunFunctionStr(Services.MailerManagement, \"SaveData\", args);\narr_Argument_Of_bw.Add(strReturn);\ne.Result = arr_Argument_Of_bw;\nbreak;";
        }

        private void BtnValue_Click(object sender, EventArgs e)
        {
            string strSource = txtAddNewAndValue.Text.Trim();
            strSource = Regex.Replace(strSource, @"\t|\n|\r| ", "");
            string[] lstSource = strSource.Split(',');
            int i = 0;
            foreach (string n in lstSource)
            {
                dt.Rows[i].BeginEdit();
                dt.Rows[i]["value"] = n;
                dt.Rows[i].EndEdit();
                i++;
            }
        }

        private void BtnName_Click(object sender, EventArgs e)
        {
            dt.Clear();
            string strSource = txtAddNewAndValue.Text.Trim();
            strSource = Regex.Replace(strSource, @"\t|\n|\r| ", "");
            string[] lstSource = strSource.Split(',');
            foreach(string n in lstSource)
            {
                DataRow dr = dt.NewRow();
                dr["name"] = n;
                dr["typeof"] = "string";
                dt.Rows.Add(dr);
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            grid.UpdateData();
            dt.AcceptChanges();
            StringBuilder strReturn = new StringBuilder();

            strReturn.Append("DataSet ds = new DataSet();" + Environment.NewLine);
            strReturn.Append("DataTable dtMaster = new DataTable();" + Environment.NewLine);
            foreach (DataRow dr in dt.Rows)
            {
                strReturn.Append("dtMaster.Columns.Add("+ dr["name"].ToString().Trim() +", typeof(" + dr["typeof"].ToString().Trim() + "));" + Environment.NewLine);
            }
            strReturn.Append("DataRow dr = dtMaster.NewRow();" + Environment.NewLine);
            foreach (DataRow dr in dt.Rows)
            {
                strReturn.Append("dr["+ dr["name"].ToString().Trim() + "] = "+ dr["value"].ToString().Trim() + ";" + Environment.NewLine);
            }
            strReturn.Append("dtMaster.Rows.Add(dr);" + Environment.NewLine);
            strReturn.Append("ds.Tables.Add(dtMaster);" + Environment.NewLine);
            strReturn.Append("return ds;");
            txtReturn.Text = strReturn.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            dt.Columns.Add("name",typeof(string));
            dt.Columns.Add("typeof", typeof(string));
            dt.Columns.Add("value", typeof(string));
            grid.DataSource = dt;
            grid.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
            grid.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            grid.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;

            DataTable dtStatus = new DataTable();
            dtStatus.Columns.Add("typeof", typeof(string));
            DataRow dr = dtStatus.NewRow();
            dr["typeof"] = "string";
            dtStatus.Rows.Add(dr);

            dr = dtStatus.NewRow();
            dr["typeof"] = "bool";
            dtStatus.Rows.Add(dr);

            dr = dtStatus.NewRow();
            dr["typeof"] = "DateTime";
            dtStatus.Rows.Add(dr);

            dr = dtStatus.NewRow();
            dr["typeof"] = "short";
            dtStatus.Rows.Add(dr);

            dr = dtStatus.NewRow();
            dr["typeof"] = "double";
            dtStatus.Rows.Add(dr);

            dr = dtStatus.NewRow();
            dr["typeof"] = "int";
            dtStatus.Rows.Add(dr);

            dr = dtStatus.NewRow();
            dr["typeof"] = "float";
            dtStatus.Rows.Add(dr);
            
            grid.DropDowns["typeof"].DataSource = dtStatus;
            grid.DropDowns["typeof"].RetrieveStructure();
            grid.DropDowns["typeof"].DisplayMember = "typeof";
            grid.DropDowns["typeof"].ValueMember = "typeof";
        }
    }
}
