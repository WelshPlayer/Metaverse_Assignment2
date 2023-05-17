using SuperSimpleTcp;
using System.Text;

namespace Metaverse_Assignment_2___Server
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }



        SimpleTcpServer server;

        private void start_Click(object sender, EventArgs e) // executed when the start button is clicked
        {
            server.Start(); // starts the server
            chatBox.Text += $"Starting the server....{Environment.NewLine}"; // adds the text to the chat box saying the server is starting
            start.Enabled = false; // sets the start button to disabled
            sendMessage.Enabled = true; // sets the send message button to enabled
        }

        private void Form1_Load(object sender, EventArgs e) // executed when the form is loaded
        {
            sendMessage.Enabled = false; // sets the send message button to disabled
            server = new SimpleTcpServer(txtIP.Text); // sets the server to be equal to its ip
            server.Events.ClientConnected += Events_ClientConnected; // initalizes the clliet connected, disconnected and data recieved functions
            server.Events.ClientDisconnected += Events_ClientDisconnected;
            server.Events.DataReceived += Events_DataReceived;
        }

        private void Events_DataReceived(object? sender, DataReceivedEventArgs e) // executed when the server recieves data
        {
            this.Invoke((MethodInvoker)delegate
            {
                chatBox.Text += $"{e.IpPort}: {Encoding.UTF8.GetString(e.Data)} {Environment.NewLine}"; // adds the clients message to the chat box
                for (int i = 0; i < lbclientIPs.Items.Count; i++) // for loop to incriment i if its less than the amount of people connected to the server
                {
                    if (e.IpPort != lbclientIPs.Items[i].ToString() && Encoding.UTF8.GetString(e.Data).Contains("I have Won")) // if the string the client sends inclues the words i have won it executed the following code
                    { 
                        server.Send(lbclientIPs.Items[i].ToString(), $"Server: Other Player Has Won!"); // sends a message to the client that did not win the game
                    }
                    else if (e.IpPort != lbclientIPs.Items[i].ToString() && !(Encoding.UTF8.GetString(e.Data).Contains("I have Won"))) // same as the above if stament but checking if it does not contain i have won 
                    {
                        server.Send(lbclientIPs.Items[i].ToString(), $"{Encoding.UTF8.GetString(e.Data)}"); // sends the clients messzage to all other clients
                    }
                }


            });
        }

        private void Events_ClientDisconnected(object? sender, ConnectionEventArgs e) // tells the server which client has disconnected in the chat box and removes them from the ip list
        {
            this.Invoke((MethodInvoker)delegate
            {

                chatBox.Text += $"{e.IpPort} disonnected from the server. {Environment.NewLine}";
                lbclientIPs.Items.Remove(e.IpPort);

            });
        }

        private void Events_ClientConnected(object? sender, ConnectionEventArgs e) // tells the server which client has connected and adds them to the ip list
        {
            this.Invoke((MethodInvoker)delegate
            {
                chatBox.Text += $"{e.IpPort} has connected to the server. {Environment.NewLine}";
                lbclientIPs.Items.Add(e.IpPort);
            });
        }

        private void sendMessage_Click(object sender, EventArgs e) // executed when the server clicks the send message button
        {
            if (server.IsListening) // checks to see if the server is lsitening (online)
            {

                if (!string.IsNullOrEmpty(txtMessage.Text) && lbclientIPs.SelectedItem != null) // checks to see if the message bow is not empty and that the server has selcted which ip they want to send the message to
                {
                    server.Send(lbclientIPs.SelectedItem.ToString(), $"Server: {txtMessage.Text}"); // sends a message to the client whos ip was selected
                    txtMessage.Text = string.Empty; // clears the message bow
                }
            }

        }

        private void Game_Start_Clicked(object sender, EventArgs e) // executed when the game start buttn is clicked
        {
            if (server.IsListening) // checks to see if the the server is listening (online)
            {
                for (int i = 0; i < lbclientIPs.Items.Count; i++)
                {

                    server.Send(lbclientIPs.Items[i].ToString(), "Server: Game Start!"); // sends a message to all clients who are connected telling them the game has started
                    GameStart.Enabled = false; // sets the game start button to disabled


                }

            }

        }
    }
}