using System;

using WatchKit;
using UIKit;
using Foundation;

namespace RockPaperScissorsXamarin.RockPaperScissorsWatchExtension
{

    public partial class InterfaceController : WKInterfaceController
    {

        private int Counter = 0;

        private enum Results { TIE, WIN, LOSE };
        private enum Moves { Rock, Paper, Scissors }

        private Moves[] Options = { Moves.Rock, Moves.Paper, Moves.Scissors };

        protected InterfaceController(IntPtr handle) : base(handle)
        {

        }

        public override void Awake(NSObject context)
        {
            base.Awake(context);

            RockButton.SetBackgroundImage(new UIImage("rock"));
            PaperButton.SetBackgroundImage(new UIImage("paper"));
            ScissorsButton.SetBackgroundImage(new UIImage("scissors"));

            Timer.Start();
        }

        public override void WillActivate()
        {
            Console.WriteLine("{0} will activate", this);
        }

        public override void DidDeactivate()
        {
            Console.WriteLine("{0} did deactivate", this);
        }

        partial void RockButton_Activated()
        {
            Check(Moves.Rock);
        }

        partial void PaperButton_Activated()
        {
            Check(Moves.Paper);
        }

        partial void ScissorsButton_Activated()
        {
            Check(Moves.Scissors);
        }

        private void Check(Moves selection) 
        {
            var random = new Random();

            var position = random.Next(0, Options.Length);
            var machineChoose = Options[position];


            if (selection == machineChoose)
            {
                ResultLabel.SetText(Results.TIE.ToString());
            }
            else if (selection == Moves.Rock && machineChoose == Moves.Scissors)
            {
                ResultLabel.SetText(Results.WIN.ToString());
                Counter += 1;
            }
            else if (selection == Moves.Rock && machineChoose == Moves.Paper)
            {
                ResultLabel.SetText(Results.LOSE.ToString());
            }
            else if (selection == Moves.Paper && machineChoose == Moves.Rock)
            {
                ResultLabel.SetText(Results.WIN.ToString());
                Counter += 1;
            }
            else if (selection == Moves.Paper && machineChoose == Moves.Scissors)
            {
                ResultLabel.SetText(Results.LOSE.ToString());
          }
            else if (selection == Moves.Scissors && machineChoose == Moves.Paper)
            {
                ResultLabel.SetText(Results.WIN.ToString());
                Counter += 1;
          }
            else if (selection == Moves.Scissors && machineChoose == Moves.Rock)
            {
                ResultLabel.SetText(Results.LOSE.ToString());
          }

            WinnerLabel.SetText($"Wins: {Counter}");
            OponentLabel.SetText($"Oponent: { machineChoose }");

        }
    }

}
