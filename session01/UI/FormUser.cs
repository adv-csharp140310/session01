using session01.Model;
using session01.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace session01.UI;
public partial class FormUser : Form
{
    UserService service = new UserService();
    int currentIndex = 0;

    public FormUser()
    {
        InitializeComponent();
    }

    private void buttonSave_Click(object sender, EventArgs e)
    {
        var user = new User
        {
            Id = 1,
            FirstName = textBoxFirstName.Text,
        };
        service.Add(user);
    }

    private void FormUser_Load(object sender, EventArgs e)
    {
        loadUser();
    }

    private void loadUser()
    {
        var user = service.GetByIndex(currentIndex);
        textBoxID.Text = user.Id.ToString();
        textBoxFirstName.Text = user.FirstName;
        textBoxLastName.Text = user.LastName;
        textBoxEmail.Text = user.Email;
        textBoxTel.Text = user.Tel;
    }

    private void buttonNext_Click(object sender, EventArgs e)
    {
        currentIndex++;
        loadUser();
    }

    private void buttonPrev_Click(object sender, EventArgs e)
    {
        currentIndex--;
        loadUser();
    }

    private void buttonFirst_Click(object sender, EventArgs e)
    {
        currentIndex = 0;
        loadUser();
    }

    private void buttonLast_Click(object sender, EventArgs e)
    {
        currentIndex = service.UserCount - 1;
        loadUser();
    }

    private void buttonDelete_Click(object sender, EventArgs e)
    {

    }

    private void buttonNew_Click(object sender, EventArgs e)
    {

    }
}
