using SuperSimpleTcp;
using System.Text;

namespace Metaverse_Assignment_2___Client
{
    public partial class Form1 : Form
    {

        Random Random = new Random();

        List<string> icon = new List<string>() // a list of the symbols that are used for the matching pairs game
        {
            "1", "1", "2", "2", "3", "3", "4", "4",
            "5", "5", "6","6", "7", "7", "8", "8"
        };

        Label firstClick, secondClick; // varibles to see what symbols were clicked
        bool start = false; // bool to see if the game has started
        int randomNumber;

        SimpleTcpClient client; // inistalsiing the supersimple tcp client 

        public Form1()
        {
            InitializeComponent();
        }

        private void numberToSquares() // a function that allocates the numbers (icons) to the squares int he matching pairs game
        {
            Label label;

            for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++) // for loop that checks if i is less than the amount of squares in the matching pairs game
            {
                if (tableLayoutPanel1.Controls[i] is Label) // if the square is a label it then sets the label variable to be equal 
                {

                    label = (Label)tableLayoutPanel1.Controls[i];

                }
                else // if the if staement is not met then it just continues on to the next part of the fuction
                    continue; 

                randomNumber = Random.Next(0, icon.Count); // sets the random nuber variable to a number between 0 and the amount of icons

                label.Text = icon[randomNumber]; // sets the text of the label to one of the random icons

                icon.RemoveAt(randomNumber); // removes the icon 

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void sendMessage_Click(object sender, EventArgs e) // this function occurs when the client clicks the send message button
        {

            if (client.IsConnected) // checks to see if the client is connected to the server
            {
                if (!string.IsNullOrEmpty(txtMessage.Text)) // if statement to check if the message box is not empty 
                {
                    client.Send(txtMessage.Text); // sends the message the client typed to the server
                    chatBox.Text += $"Me: {txtMessage.Text}{Environment.NewLine}"; // displays the clients message in the chat box so they can see it 
                    txtMessage.Text = string.Empty; // sets the text in the message box to empty (clears the message box)
                }

            }

        }

        private void connect_Click(object sender, EventArgs e) // this function occurs when the client clicks the connect button
        {
            try // trys to connect the client to the server 
            {
                client.Connect(); // connects the client to the server
                sendMessage.Enabled = true; // sets the send message button to active
                connect.Enabled = false; // sets the connect button to inactive

            }
            catch (Exception ex) // catches an exception 
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void Form1_Load(object sender, EventArgs e) // this function occurs when the form is first loaded
        {
            client = new(txtIP.Text); // sets the client to be equal to their IpPort
            client.Events.Connected += Events_Connected; // initalizes the connected, data received and disconnected events
            client.Events.DataReceived += Events_DataReceived;
            client.Events.Disconnected += Events_Disconnected;
            sendMessage.Enabled = false; // sets the send message button to inactive

        }

        private void Events_Disconnected(object? sender, ConnectionEventArgs e) // when the server is turns offline this function occurs
        {
            this.Invoke((MethodInvoker)delegate
            {
                chatBox.Text += $"Server Disconnected. {Environment.NewLine}";
            });
        }

        private void Events_DataReceived(object? sender, DataReceivedEventArgs e) // this function occurs when the client recieves any data
        {
            this.Invoke((MethodInvoker)delegate
            {
                if (Encoding.UTF8.GetString(e.Data).Contains("Server") && Encoding.UTF8.GetString(e.Data).Contains("Game Start!")) // if the data from the server contains the words server and game start the following code is exected
                {
                    chatBox.Text += $"{Encoding.UTF8.GetString(e.Data)}{Environment.NewLine}"; // adds the data the client recieved to the text box 
                    numberToSquares(); // executes the number to squares function
                    start = true; // sets the start bool true
                    MessageBox.Show("Game has Started!"); // message box pops up saying the game has started
                  
                }
                else if (Encoding.UTF8.GetString(e.Data).Contains("Server") && !(Encoding.UTF8.GetString(e.Data).Contains("Other Player Has Won!"))) // if the data the client recieves contains the words server and other player has won the follwoing code is executed
                {
                    chatBox.Text += $"{Encoding.UTF8.GetString(e.Data)}{Environment.NewLine}";// adds the data the client recieved to the text box 
                }
                else if (Encoding.UTF8.GetString(e.Data).Contains("Other Player Has Won!")) // if the data the client recieves contains only other player has won the following code is executed
                {
                    chatBox.Text += $"{Encoding.UTF8.GetString(e.Data)}{Environment.NewLine}";// adds the data the client recieved to the text box 
                    start = false; // sets start bool to false

                }
                else
                {
                    // if none of the above statements are met the message has come from the other player and the following code is executed
                    chatBox.Text += $"Player 2: {Encoding.UTF8.GetString(e.Data)}{Environment.NewLine}";
                }

                
            });

        }

        private void Events_Connected(object? sender, ConnectionEventArgs e) // when the server connects to the clients it tells the clients 
        {
            this.Invoke((MethodInvoker)delegate
            {
                chatBox.Text += $"Server Connected. {Environment.NewLine}";
            });
        }

        private void Label_Click(object sender, EventArgs e) // this piece of code is executed when the client clicks on a sqaure from the matching pairs game
        {

            if (start == true) // an if staement to check if start is equal to true
            {

                if (firstClick != null && secondClick != null) { return; } // if both first click is and second click are not null (the user hasn't clicked on anything) do nothing

                Label clickedLabel = sender as Label; // sets clicked label equal to sender

                if (clickedLabel == null) { return; } // if the clicked lable is null (the user hasnt clicked on it) do nothing

                if (clickedLabel.ForeColor == Color.Black) { return; } // if the colour of the icon is black do nothing

                if (firstClick == null) // if the first clicked square is null  execute the follwing code
                {
                    firstClick = clickedLabel; // sets the first clicked variable to be equal to clicked label
                    firstClick.ForeColor = Color.Black; // sets the colour to black
                    return; // end the if statement
                }

                secondClick = clickedLabel; // sets second click variable to be equal to clicked label
                secondClick.ForeColor = Color.Black; // sets the colour to black

                winner(); // executes the winner function

                if (firstClick.Text == secondClick.Text) // if the text of the first and second clicked incons is the same sets both to null
                {
                    firstClick = null;
                    secondClick = null;
                }
                else
                {
                    timer1.Start(); // starts a timer so that the icons are reset if they are not the same
                }

            }

        }

        private void winner()
        {
            Label label;
            for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++) // for loop that checsk if i is less than the amount of squares in the matching pairs game
            {
                label = tableLayoutPanel1.Controls[i] as Label; 

                if (label != null && label.ForeColor == label.BackColor) // checks each sqaure and if all icosn are black it retuns and continues with the code
                {
                    return;
                }

            }

            MessageBox.Show("You have won!"); // opens a message bow telling the person they have won
            start = false; // sets start to false so the game stops for the other player
            client.Send("I have Won"); // sends a message telling it they have won
        }

        private void timer1_Tick(object sender, EventArgs e) // setup for the timer
        {
            timer1.Stop();
            firstClick.ForeColor = firstClick.BackColor;
            secondClick.ForeColor = secondClick.BackColor;

            firstClick = null;
            secondClick = null;

        }
    }
}