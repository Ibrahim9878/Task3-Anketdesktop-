namespace WinFormsApp3;

public partial class Form1 : Form
{
    List<User> users = new List<User>();
    public Form1()
    {
        InitializeComponent();
        listBox1.DataSource = users;
    }

    private void Add_Click(object sender, EventArgs e)
    {
        User u = new(NameBox.Text, SurnameBox.Text, MailBox.Text, PhoneBox.Text, DateTime.Parse(dateTimePicker1.Text));
        users.Add(u);
        listBox1.DataSource = null;
        listBox1.DataSource = users;
        NameBox.Text = string.Empty;
        SurnameBox.Text = string.Empty;
        MailBox.Text = string.Empty;
        PhoneBox.Text = string.Empty;
    }

    private void buttonSave_Click(object sender, EventArgs e)
    {
        Functions.WriteUserTojson(users, FileBox.Text);
        users.Clear();
        listBox1.DataSource = null;
        listBox1.DataSource = users;
        FileBox.Text = string.Empty;
    }

    private void buttonLoad_Click(object sender, EventArgs e)
    {
        users = Functions.ReadUserToJson(FileBox.Text);
        FileBox.Text = string.Empty;
        listBox1.DataSource = null;
        listBox1.DataSource = users;
    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        NameBox.Text = users[listBox1.SelectedIndex].Name;
        SurnameBox.Text = users[listBox1.SelectedIndex].Surname;
        MailBox.Text = users[listBox1.SelectedIndex].Email;
        PhoneBox.Text = users[listBox1.SelectedIndex].Phone;
        dateTimePicker1.Text = users[listBox1.SelectedIndex].Date.ToString();
    }

    private void buttonChange_Click(object sender, EventArgs e)
    {
        User u = new(NameBox.Text, SurnameBox.Text, MailBox.Text, PhoneBox.Text, DateTime.Parse(dateTimePicker1.Text));
        users[listBox1.SelectedIndex] = u;
        listBox1.DataSource = null;
        listBox1.DataSource = users;
        NameBox.Text = string.Empty;
        SurnameBox.Text = string.Empty;
        MailBox.Text = string.Empty;
        PhoneBox.Text = string.Empty;
    }
}