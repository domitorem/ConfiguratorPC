using ConfiguratorPC.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConfiguratorPC
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			TopMost = true;
			InitializeComponent();
			
		}

		private string CurrentState;
		private string NextState;

		private void Form1_Load_1(object sender, EventArgs e)
		{
			textBox1.ReadOnly = true;
			
			DataSet ds = new DataSet();
			string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=ConfigurationPCAssistant;Integrated Security=True;User Id=sa; Password =1;";// создаем строку подключения
			string commandString = "SELECT ID, Sl, Ind_Stop FROM dbo.Events WHERE (Ind_Stast = 1)";
			SqlDataAdapter adapter = new SqlDataAdapter(commandString, connectionString);
			
			adapter.Fill(ds);

			//находим количество строк в таблице
			int rows_ = ds.Tables[0].Rows.Count;
			if(rows_ > 0)
			{
				DataRow row = ds.Tables[0].Rows[0];
				string ii_str;
				ii_str = row["Sl"].ToString();
				textBox1.Text = ii_str;
				ii_str = row["ID"].ToString();
				CurrentState = ii_str;
			}
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			textBox2.Text = "1";
		}

		private void button2_Click_1(object sender, EventArgs e)
		{
			textBox2.Text = "0";
		}

		private void button3_Click_1(object sender, EventArgs e)
		{
			DataSet ds = new DataSet();
			string Rj__ = "0", Si__;
			while (!YesRadioBtn.Checked || !NoRadioBtn.Checked)
			{
				if(YesRadioBtn.Checked) 
				{
					Rj__ = "1";
					break;
				}

				if(NoRadioBtn.Checked)
				{
					Rj__ = "0";
					break;	
				}
			}

			//Rj__ = textBox2.Text;
			Si__ = CurrentState;
			string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=ConfigurationPCAssistant;Integrated Security=True;User Id=sa; Password =1;";// создаем строку подключения
			string commandString = "SELECT        TOP (100) PERCENT ID, Si, Rj, Sk, Memo  FROM            dbo.Rules WHERE        (Si =" + Si__ + ") AND (Rj =" + Rj__ + ")";// создаем запрос
			SqlDataAdapter adapter = new SqlDataAdapter(commandString, connectionString);
			adapter.Fill(ds);

			int rows_;
			rows_ = ds.Tables[0].Rows.Count;
			if(rows_ > 0)
			{
				DataRow row = ds.Tables[0].Rows[0];
				string ii_str = row["Sk"].ToString();
				NextState = ii_str;
			}
			button4_Click_1(sender, e);
		}

		private void button4_Click_1(object sender, EventArgs e)
		{
			DataSet ds = new DataSet();
			string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=ConfigurationPCAssistant;Integrated Security=True;User Id=sa; Password =1;";// создаем строку подключения
			string S__NEXT, STOP_;
			S__NEXT = NextState;
			string commandString = "SELECT        ID, Sl, Ind_Stop  FROM            dbo.Events  WHERE        (ID = " + S__NEXT + ")";// создаем запрос
			SqlDataAdapter adapter = new SqlDataAdapter(commandString, connectionString);
			adapter.Fill(ds);
			int rows_ = 0;
			rows_ = ds.Tables[0].Rows.Count;
			if(rows_ > 0)
			{
				DataRow row = ds.Tables[0].Rows[0];
				string ii_str;
				ii_str = row["Sl"].ToString();
				textBox1.Text = ii_str;
				ii_str = row["ID"].ToString();
				CurrentState = ii_str;
				ii_str = row["Ind_Stop"].ToString();
				STOP_ = ii_str;
				if (STOP_ == "True") 
				{
					string config = row["Sl"].ToString();
					MessageBox.Show("Исходя из ваших ответов на вопросы, для ваших нужд подойдет конфигурация " + config);
				}
			}
		}


		private void YesRadioBtn_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void NoRadioBtn_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
