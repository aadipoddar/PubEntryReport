using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp;
using static PubEntryReport.MainForm;

namespace PubEntryReport
{
	public partial class MainForm : Form
	{
		public class Person
		{
			public string Id { get; set; }
			public string Name { get; set; }
			public string Number { get; set; }
		}

		List<Person> persons;
		IFirebaseConfig config = new FirebaseConfig
		{
			AuthSecret = "GBZsC8h9K24WuvS48u4h5Ao3ltH8EKDDlJG5ea4g",
			BasePath = "https://pubentryreport-default-rtdb.asia-southeast1.firebasedatabase.app/"
		};

		FirebaseClient client;

		public MainForm()
		{
			InitializeComponent();
			client = new FirebaseClient(config);
			persons = new List<Person>();
			FillListBox();
		}

		private async void FillListBox()
		{
			persons.Clear();
			persons = await GetData();

			personListBox.Items.Clear();
			foreach (var person in persons)
			{
				personListBox.Items.Add(person);
				personListBox.DisplayMember = "Name";
				personListBox.ValueMember = "Id";
			}
		}

		async Task<List<Person>> GetData()
		{
			var per = await client.GetAsync("Persons");
			if (per.Body != "null")
				foreach (var VARIABLE in (await client.GetAsync("Persons")).ResultAs<Person[]>())
					if (VARIABLE != null)
						persons.Add(VARIABLE);

			return persons;
		}

		private async void insertButton_Click(object sender, EventArgs e)
		{
			persons = await GetData();
			Person person = new Person();
			person.Name = nameTextBox.Text;
			person.Number = numberTextBox.Text;

			if (persons.Count != 0)
				person.Id = (Convert.ToInt64(persons.LastOrDefault().Id) + 1).ToString();

			await client.SetAsync($"Persons/{persons.Count}", person);

			ClearForm();
			FillListBox();
		}

		private void ClearForm()
		{
			nameTextBox.Text = string.Empty;
			numberTextBox.Text = string.Empty;
		}

		private void getDataButton_Click(object sender, EventArgs e)
		{
			FillListBox();
		}

		private void personListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (personListBox.SelectedIndex != -1)
			{
				nameTextBox.Text = persons.ElementAt(personListBox.SelectedIndex).Name.ToString();
				numberTextBox.Text = persons.ElementAt(personListBox.SelectedIndex).Number.ToString();
			}
		}

		private async void updateButton_Click(object sender, EventArgs e)
		{
			if (personListBox.SelectedIndex != -1)
			{
				Person person = new Person();
				person.Name = nameTextBox.Text;
				person.Number = numberTextBox.Text;
				person.Id = persons.ElementAt(personListBox.SelectedIndex).Id;

				int c = 0, i = 0;
				foreach (var VARIABLE in (await client.GetAsync("Persons")).ResultAs<Person[]>())
					c++;

				for (i = 0; i < c; i++)
				{
					int id = 0;
					var getId = await client.GetAsync($"Persons/{i}/Id");
					if (getId.Body != "null")
						id = (int)Convert.ToInt64(getId.Body.Substring(1, getId.Body.Length - 2));
					if (id == (int)Convert.ToInt64(person.Id))
						break;
				}

				await client.UpdateAsync($"Persons/{i}", person);

				ClearForm();
				FillListBox();
			}
		}

		private async void deleteButton_Click(object sender, EventArgs e)
		{
			if (personListBox.SelectedIndex != -1)
			{
				int c = 0, i = 0;
				foreach (var VARIABLE in (await client.GetAsync("Persons")).ResultAs<Person[]>())
					c++;

				for (i = 0; i < c; i++)
				{
					int id = 0;
					var getId = await client.GetAsync($"Persons/{i}/Id");
					if (getId.Body != "null")
						id = (int)Convert.ToInt64(getId.Body.Substring(1, getId.Body.Length - 2));
					if (id == (int)Convert.ToInt64(persons.ElementAt(personListBox.SelectedIndex).Id))
						break;
				}

				await client.DeleteAsync($"Persons/{i}");
			}

			ClearForm();
			FillListBox();
		}
	}
}