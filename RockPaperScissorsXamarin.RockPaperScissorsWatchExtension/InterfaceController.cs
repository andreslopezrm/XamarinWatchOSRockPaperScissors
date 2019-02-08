using System;

using WatchKit;
using UIKit;
using Foundation;

namespace RockPaperScissorsXamarin.RockPaperScissorsWatchExtension
{
    public partial class InterfaceController : WKInterfaceController
    {
        private string[] Options = { "rock", "paper", "scissors" };
        private int Counter = 0;

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
            Check("rock");
        }

        partial void PaperButton_Activated()
        {
            Check("paper");
        }

        partial void ScissorsButton_Activated()
        {
            Check("scissors");
        }

        private void Check(string selection) 
        {
            var random = new Random();

            var position = random.Next(0, Options.Length);
            var machineChoose = Options[position];


            if (selection == machineChoose)
            {
                ResultLabel.SetText("TIE");
            }
            else if (selection == "rock" && machineChoose == "scissors")
            {
                ResultLabel.SetText("WIN");
                Counter += 1;
            }
            else if (selection == "rock" && machineChoose == "paper")
            {
                ResultLabel.SetText("LOSE");
            }
            else if (selection == "paper" && machineChoose == "rock")
            {
                ResultLabel.SetText("WIN");
                Counter += 1;
            }
            else if (selection == "paper" && machineChoose == "scissors")
            {
                ResultLabel.SetText("LOSE");
          }
            else if (selection == "scissors" && machineChoose == "paper")
            {
                ResultLabel.SetText("WIN");
                Counter += 1;
          }
            else if (selection == "scissors" && machineChoose == "rock")
            {
                ResultLabel.SetText("LOSE");
          }

            WinnerLabel.SetText($"Wins: {Counter}");
            OponentLabel.SetText($"Oponent: { machineChoose }");

        }
    }

}
