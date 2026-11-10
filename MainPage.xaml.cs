namespace MAUIRockPaperScissors
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
        }

        private void bt_Clicked(object? sender, EventArgs e)
        {   // Cast sender to Button to identify which button was clicked
            Button? clickedButton = sender as Button;
            if (clickedButton == null) return;
            // Get the user's move from the button text
            string userMove = clickedButton.Text;
            llUser.Text = $"You: {userMove}";
            // Define possible moves
            string[] moves = { "✊", "✋", "✌" }; // Rock, Paper, Scissors
            // Generate random move for the computer
            string computerMove = moves[Random.Shared.Next(moves.Length)];
            llComputer.Text = $"Computer: {computerMove}";
            // Determine the result
            string result;
            if (userMove == computerMove)
            {   result = "It's a tie!";
            }
            else if ((userMove == "✊" && computerMove == "✌") ||
                     (userMove == "✋" && computerMove == "✊") ||
                     (userMove == "✌" && computerMove == "✋"))
               result = "You win!";
            else
                result = "Computer wins!";
            llResult.Text = result;
        }
    }

}
