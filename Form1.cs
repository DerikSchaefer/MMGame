using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMGame
{
    public partial class Form1 : Form
    {
        private List<char> solution;
        private
        const int MAX_GUESSES = 10;
        private HttpClient client = new HttpClient();
        private int guesses;

        public Form1()
        {

            // exception handling
            try
            {
                InitializeComponent();
                // Hiding buttons that should not be pressed at this point in the game
                guessButton.Enabled = false;
                resetButton.Enabled = false;
                guessButton.Visible = false;
                resetButton.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while starting the game: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // calling my CreateSolution async method, trying to improve performance w/ the API
            CreateSolution();
            guessesRemainingLabel.Text = MAX_GUESSES.ToString();
        }
        private async Task CreateSolution()
        {
            // calling API, checking if succesful
            var numbers = await client.GetAsync("https://www.random.org/integers/?num=4&min=1&max=6&col=1&base=10&format=plain&rnd=new");
            if (numbers.IsSuccessStatusCode)
            {
                // API appears to return number + white space / line break. Trying to mitigate that here
                var message = await numbers.Content.ReadAsStringAsync();
                solution = new List<char>();
                string[] numsString = message.TrimEnd('\n').Split('\n');

                foreach (string num in numsString)
                {
                    solution.Add(char.Parse(num));
                }
            }
        }

        private async void startButton_Click_1(object sender, EventArgs e)
        {
            // Async, await on the API creating the solution
            await CreateSolution();
            MessageBox.Show("The game is starting! Please enter a 4 digit number as your guess. The format should be xxxx. You have " + MAX_GUESSES + " guesses to find the correct solution. Good luck!", "Game Started", MessageBoxButtons.OK, MessageBoxIcon.Information);
            guessButton.Enabled = true;
            resetButton.Enabled = true;
            guessButton.Visible = true;
            resetButton.Visible = true;
            // resetting guess amount and displaying that in the guesses remaining box
            guesses = 0;
            guessesRemainingLabel.Text = MAX_GUESSES.ToString();
            resultsLabel.Text = "";
        }
        private void guessButton_Click_1(object sender, EventArgs e)
        {
            // try / catch / finally exception handling 
            try
            {
                // First assess whether or not the player has guessed more times than allowed, if true then end the game
                if (guesses >= MAX_GUESSES)
                {
                    resultsLabel.Text = "Sorry, you did not guess the solution within " + MAX_GUESSES + " guesses. The solution was " + string.Join("", solution.ToArray());
                    guessButton.Enabled = false;
                    OneMoreBTN.Enabled = false;
                    return;
                }
                // parse the user's guess input, check for valid input (4 numbers), display message if incorrect input
                string guess = guessTextBox.Text;
                if (guess.Length != 4)
                {
                    resultsLabel.Text = "Invalid input. Please enter a 4 digit number.";
                    return;
                }
                // Adding user's guess to past guess box
                pastGuessesListBox.AppendText(guess + Environment.NewLine);
                guesses++;
                guessesRemainingLabel.Text = (MAX_GUESSES - guesses).ToString();

                // creating variables for correct digits and correct positions here and then assessing for truthyness
                int correctDigits = 0;
                int correctPositions = 0;

                for (int i = 0; i < 4; i++)
                {
                    if (guess[i] == solution[i])
                    {
                        correctPositions++;
                    }
                    else if (solution.Contains(guess[i]))
                    {
                        correctDigits++;
                    }
                }

                // Return results to user in results label
                resultsLabel.Text = correctPositions + " digits in the correct position, " + correctDigits + " digits correct but in the wrong position.";
                guessTextBox.Text = "";
            }
            catch (Exception ex)
            {
                // Generic catch block to handle exceptions
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void resetButton_Click_1(object sender, EventArgs e)
        {
            // Calling update UI method, recreating a new solution for a new game
            UpdateUI();
            await CreateSolution();
            pastGuessesListBox.Clear();
        }

        private void UpdateUI()
        {
            // Guess button not enabled until game is started, resetting guess amount and displaying that, clearing out text boxes. This will
            // give the apperane of starting a new game
            guessButton.Enabled = false;
            guesses = 0;
            guessesRemainingLabel.Text = MAX_GUESSES.ToString();
            guessTextBox.Clear();
            resultsLabel.Text = "";
        }

        private void OneMoreBTN_Click(object sender, EventArgs e)
        {
            // Additional feature I thought of, this gives the user an additional guess when they click this button. Only works if clicked
            // prior to exceeding max guesses
            if (guesses < MAX_GUESSES)
            {
                // I convert the information within the guessesremaining box to an int, add one to it and then convert back to a string
                guessesRemainingLabel.Text = (int.Parse(guessesRemainingLabel.Text) + 1).ToString();
            }
        }



        // check check github check
    }
}