using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AramBoost
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

		#region HeadUstPanel
		int Move;
		int Mouse_X;
		int Mouse_Y;


		private void HeadUstPanel_MouseUp(object sender, MouseEventArgs e)
		{
			Move = 0;
		}

		private void HeadUstPanel_MouseDown(object sender, MouseEventArgs e)
		{
			Move = 1;
			Mouse_X = e.X;
			Mouse_Y = e.Y;
		}

		private void HeadUstPanel_MouseMove(object sender, MouseEventArgs e)
		{
			if (Move == 1)
			{
				this.SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y);
			}
		}
		#endregion

		#region HeadUstPanel-Txt
		private void label1_MouseUp(object sender, MouseEventArgs e)
		{
			Move = 0;
		}

		private void label1_MouseDown(object sender, MouseEventArgs e)
		{
			Move = 1;
			Mouse_X = e.X;
			Mouse_Y = e.Y;
		}

		private void label1_MouseMove(object sender, MouseEventArgs e)
		{
			if (Move == 1)
			{
				this.SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y);
			}
		}
		#endregion

		#region HeadUstPanel-Btn
		private void KapatTxtBtn_Tıkla(object sender, EventArgs e)
		{
			Application.ExitThread();
		}

		private void MinimizeTxtBtn_Tıkla(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void website_Tıkla(object sender, EventArgs e)
		{
			Process.Start("https://doxria.com");
		}
		#endregion

		#region Main bölüm
		static ValueTuple<string, string> GetInfo()
		{
			string arguman = "";
			string arguman2 = "";
			ManagementClass managementClass = new ManagementClass("Win32_Process");
			foreach (ManagementBaseObject managementBaseObject in managementClass.GetInstances())
			{
				ManagementObject managementObject = (ManagementObject)managementBaseObject;
				if (managementObject["Name"].Equals("LeagueClientUx.exe"))
				{
					foreach (object obj in Regex.Matches(managementObject["CommandLine"].ToString(), string_0, regexOptions_0))
					{
						Match match = (Match)obj;
						if (!string.IsNullOrEmpty(match.Groups["port"].ToString()))
						{
							arguman2 = match.Groups["port"].ToString();
						}
						else if (!string.IsNullOrEmpty(match.Groups["token"].ToString()))
						{
							arguman = match.Groups["token"].ToString();
						}
					}
				}
			}
			if (string.IsNullOrEmpty(arguman) || string.IsNullOrEmpty(arguman2))
			{
				Console.WriteLine("LoL istemcisi bulunamadı!");
			}
			return new ValueTuple<string, string>(arguman, arguman2);
		}

		static void PostRequest(string string_1, string string_2)
		{
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
			ServicePointManager.ServerCertificateValidationCallback = (RemoteCertificateValidationCallback)Delegate.Combine(ServicePointManager.ServerCertificateValidationCallback, new RemoteCertificateValidationCallback(Class1.NewClass.Main));
			RestClient restClient = new RestClient("https://127.0.0.1:" + string_2)
			{
				Authenticator = new HttpBasicAuthenticator("riot", string_1)
			};
			RestRequest istek = new RestRequest("/lol-champ-select/v1/team-boost/purchase", Method.POST);
			restClient.Execute(istek);
		}

		static readonly string string_0 = "\"--remoting-auth-token=(?'token'.*?)\" | \"--app-port=(?'port'|.*?)\"";
		static readonly RegexOptions regexOptions_0 = RegexOptions.Multiline;

		public class Class1
		{
			internal bool Main(object object_0, X509Certificate x509Certificate_0, X509Chain x509Chain_0, SslPolicyErrors sslPolicyErrors_0)
			{
				return true;
			}

			public static readonly Class1 NewClass = new Class1();
			static RemoteCertificateValidationCallback callback;
		}
        #endregion

        #region Buton
        private void AktifBtnTikla(object sender, EventArgs e)
        {
			try
			{
				ValueTuple<string, string> valueTuple = GetInfo();
				PostRequest(valueTuple.Item1, valueTuple.Item2);
				Thread.Sleep(1500);
			}
			catch (Exception)
			{
				MessageBox.Show("Hata", "LoL istemcisi bulunamadı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
        #endregion
    }
}
