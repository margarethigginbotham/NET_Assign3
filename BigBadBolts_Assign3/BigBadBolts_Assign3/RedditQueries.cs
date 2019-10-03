using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigBadBolts_Assign3
{
    public partial class RedditQueries : Form
    {
        static public SortedSet<Post> myPosts = new SortedSet<Post>();
        static public SortedSet<Comment> myComments = new SortedSet<Comment>();
        static public SortedSet<Subreddit> mySubReddits = new SortedSet<Subreddit>();
        static public SortedSet<User> myUsers = new SortedSet<User>();
        public RedditQueries()
        {
            InitializeComponent();
            HelperFunctions.getFileInput();
            PopulateDropDowns();
        }

        private void PopulateDropDowns()
        {
            foreach(Subreddit s in mySubReddits) //populate the subreddit award combo box
            {
                subbredditAwardComboBox.Items.Add(s);
            }
        }

        private void RedditQueries_Load(object sender, EventArgs e)
        {

        }

        private void SubAwardBtn_Click(object sender, EventArgs e)
        {
            if (subbredditAwardComboBox.SelectedIndex == -1) //no item selected from dropdown
            {
                MessageBox.Show("Please select a SubReddit to view.");
                return;
            }
            if (silverCheckBox.Checked)
            {
                MessageBox.Show("CHECKED");
            }
            else
            {
                MessageBox.Show("EMPTY");
            }
        }
    }
}
