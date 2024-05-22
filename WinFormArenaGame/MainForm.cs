using ArenaGame;
using ArenaGame.Heroes;
using ArenaGame.Weapons;
using System;

namespace WinFormArenaGame
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        Random random = new Random();
        private void gameNotification(GameEngine.NotificationArgs args)
        {
            TextBox tbAttacker;
            if (args.Attacker is Knight)
                tbAttacker = tbKnight;
            else
                tbAttacker = tbAssassin;
            if(args.Attacker.Weapon is IceStaff)
            {
                if (random.NextDouble() < 0.1)
                {
                    tbAttacker.AppendText(
                    $"{args.Attacker.Name} freezed and attacked {args.Defender.Name} with {Math.Round(args.Attack, 2)} and caused {Math.Round(args.Damage, 2)} damage.\r\n");
                }
                else
                {
                    tbAttacker.AppendText(
                    $"{args.Attacker.Name} attacked {args.Defender.Name} with {Math.Round(args.Attack, 2)} and caused {Math.Round(args.Damage, 2)} damage.\r\n");
                }
            }
            else
            {
                tbAttacker.AppendText(
                    $"{args.Attacker.Name} attacked {args.Defender.Name} with {Math.Round(args.Attack, 2)} and caused {Math.Round(args.Damage, 2)} damage.\r\n");
            }

            DateTime dt = DateTime.Now;

            while (DateTime.Now - dt < TimeSpan.FromMilliseconds(300))
            {
                Application.DoEvents();
            }
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            lbWinner.Text = "";
            tbAssassin.Text = "";
            tbKnight.Text = "";
            lbWinner.Visible = false;

            GameEngine gameEngine = new GameEngine()
            {
                HeroA = new Knight("Knight", 10, 20, new IceStaff("Fire Axe")),
                HeroB = new Assassin("Assassin", 10, 5, new Dagger("Dagger")),
                NotificationsCallBack = gameNotification
            };

            imgFight.Enabled = true;
            gameEngine.Fight();
            imgFight.Enabled = false;

            lbWinner.Text = $"And the winner is:\n{gameEngine.Winner}";
            lbWinner.Visible = true;
        }

        private void lbWinner_Click(object sender, EventArgs e)
        {

        }

        private void tbAssassin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}