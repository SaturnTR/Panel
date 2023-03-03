using realLife.Contents.Assets.Humans.LocalCharacter;

namespace DefaultLocalCharacter
{
    public partial class DefaultCharacter : Form
    {
        public int yourIQ = 80;
        public int yourDollarsByValue = 500;
        public int yourDollars;
        private int rich = 50000000;
        
        public DefaultCharacter()
        {
           InitializeComponent();
        }
        public static void Character(String[] args)
        }
            // Why You Still Reading This? You Wasted Your Seconds For Only 1 Line Of Text Right Now, Sir!
        }        
        public void DefaultCharacter_Load(object sender, EventArgs e)
        {
           try
           {
              if(yourIQ < 80 == true)
              {
                  Application.Exit();
              }
              if(yourDollars = yourDollarsByValue + 1000000)
              {
                  if(yourDollarsByValue + 1000000 == rich)
                  {
                     MessageBox.Show("Rich Boy Confirmed!");
                  }
              }
           }
           catch(Exception ex)
           {
              MessageBox.Show(ex.Message + MessageBoxIcons.Trollface + MessageBoxButton.OK);
           }
        }
    }
}
