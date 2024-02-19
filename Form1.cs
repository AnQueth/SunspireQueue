using System.Windows.Forms;

namespace SunspireQueue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void PushKey(Keys key)
        {
 

            if (key == Keys.N)
            {
                Person? p = SetCurrentPerson();
                if (p is null)
                    return;

                p.LastWent = DateTimeOffset.Now;
                OrderQueue();



                return;
            }

            if (key >= Keys.D1 && key <= Keys.D8)
            {
                int value = (int)key - (int)Keys.D0;



                foreach (Person item in lbPeopleInQueue.Items)
                {
                    if (item.Key == value)
                    {
                        lbPeopleInQueue.Items.Remove(item);
                        lbPeopleDead.Items.Add(item);
                        SetCurrentPerson();
                        return;
                    }
                }
                foreach (Person item in lbPeopleDead.Items)
                {
                    if (item.Key == value)
                    {
                        lbPeopleDead.Items.Remove(item);
                        lbPeopleInQueue.Items.Add(item);
                        SetCurrentPerson();
                        OrderQueue();
                        return;
                    }
                }
            }

        }

        private void OrderQueue()
        {

            List<Person> l = new List<Person>();
            foreach (Person item in lbPeopleInQueue.Items)
            {
                l.Add(new Person(item.Name, item.Key, item.LastWent));


            }
            lbPeopleInQueue.Items.Clear();
            l.Sort((a, b) =>
            {
                return a.LastWent.GetValueOrDefault().CompareTo(b.LastWent.GetValueOrDefault());
            });

            foreach (Person item in l)
            {
                lbPeopleInQueue.Items.Add(item);
            }
        }

        private Person? SetCurrentPerson()
        {
            if(lbPeopleInQueue.Items.Count == 0)
            {
                lblCurrentTombPerson.Text = string.Empty;
                return null;

            }
            Person p = (Person)lbPeopleInQueue.Items[0];
            lblCurrentTombPerson.Text = p.Name;
            return p;
        }

        private void btnAddToQueue_Click(object sender, EventArgs e)
        {
            AddPerson();

        }

        private void AddPerson()
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                return;

            }
            Person p = new Person(txtName.Text, lbPeopleInQueue.Items.Count + 1);
            lbPeopleInQueue.Items.Add(p);
            txtName.Text = string.Empty;
        }

        private void txtName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddPerson();
            }
        }

        private void lbPeopleInQueue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                lbPeopleInQueue.Items.RemoveAt(lbPeopleInQueue.SelectedIndex);
            }
            int x = 1;


            List<Person> l = new List<Person>();
            foreach (Person item in lbPeopleInQueue.Items)
            {
                l.Add(new Person(item.Name, x));
                x++;

            }
            lbPeopleInQueue.Items.Clear();

            foreach (Person item in l)
            {
                lbPeopleInQueue.Items.Add(item);
            }

        }

        private void lbPeopleInQueue_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index == -1)
                return;

            int seconds = 30;
            int.TryParse(txtSeconds.Text, out seconds);

            Person item = lbPeopleInQueue.Items[e.Index] as Person;
            if (item != null)
            {
                Brush myBrush = new SolidBrush(Color.Green);
                e.DrawBackground();
                if (item.LastWent.GetValueOrDefault() > DateTimeOffset.Now.AddSeconds(-1 * seconds))
                {
                    myBrush = new SolidBrush(Color.Red);
                }

                e.Graphics.DrawString(item.ToString(), e.Font, myBrush, e.Bounds, StringFormat.GenericDefault);
                e.DrawFocusRectangle();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbPeopleInQueue.Refresh();
        }
    }

    public record Person(string Name, int Key, DateTimeOffset? LastWent = null)
    {
        public DateTimeOffset? LastWent { get; set; } = LastWent;

        public override string ToString()
        {
            return $"{Key} -- {Name} -- {LastWent.GetValueOrDefault():mm':'ss}";
        }
    }
}
