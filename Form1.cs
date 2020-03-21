using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace LabPrakt4zad
{
    public partial class Form1 : Form
    {
		DataSet alldata = new DataSet();
		DataTable AddIntoDataSet(NpgsqlCommand comma,string name_table)
		{
			DataTable table = new DataTable(name_table);
			table.Load(comma.ExecuteReader());
			return table;
		}
		void LoadList()
		{
			DataTable Univ;
			DataTable Fac;
			DataTable Stud;
			using (var connect = new NpgsqlConnection("host = localhost; username = postgres; password = 22443311q; database = prakt"))
			{
				connect.Open();
				using (var commandUniiverse = new NpgsqlCommand("select * from \"University\";", connect))
				{
					Univ = AddIntoDataSet(commandUniiverse,"university");
					alldata.Tables.Add(Univ);
				}
				using (var commandFac = new NpgsqlCommand("select * from \"Faculties\";", connect))
				{
					Fac = AddIntoDataSet(commandFac, "faculties");
					alldata.Tables.Add(Fac);
				}
				using (var commandStud = new NpgsqlCommand("select * from \"Students\";", connect))
				{
					Stud = AddIntoDataSet(commandStud, "students");
					DataColumn computedColumn = new DataColumn("studinfo", typeof(string));
					computedColumn.Expression = "[name_of_st] + ' ' + [surname_of_st] + ' ' +[course] + ' курс' ";
					Stud.Columns.Add(computedColumn);
					alldata.Tables.Add(Stud);
				}
				connect.Close();


			}
			alldata.Relations.Add(new DataRelation("University_faculties", Univ.Columns["id"], Fac.Columns["id_universe"]));
			alldata.Relations.Add(new DataRelation("Faculties_students", Fac.Columns["id"], Stud.Columns["id_fac"]));



		}
		public Form1()
        {
            InitializeComponent();
			LoadList();
			University.DataSource = alldata;
			University.DisplayMember = "university.name";
			Faculties.ValueMember = "university.id";


			Faculties.DataSource = alldata;
			Faculties.DisplayMember = "university.University_faculties.name_of_fac";

			
			Students.DataSource = alldata;
			Students.DisplayMember = "university.University_faculties.Faculties_students.studinfo";
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}
