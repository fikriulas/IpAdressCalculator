using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubnetProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {

            try
            {
                byte[] ipAdressBytes = IPAddress.Parse(txtIpAdd.Text).GetAddressBytes(); //ipleri byte formatına çevirir.
                byte[] subnetMaskBytes = IPAddress.Parse(txtSubnet.Text).GetAddressBytes();
                if (ipAdressBytes.Length != subnetMaskBytes.Length)
                {  // subnet ve ip uzunlukları eşit değilse hata verir.
                    MessageBox.Show("Lengths of IP address and subnet mask do not match.");
                }
                else
                {
                    byte[] broadcastAddress = new byte[ipAdressBytes.Length];
                    for (int i = 0; i < broadcastAddress.Length; i++)                     // broadcast ip bulur.
                    {
                        broadcastAddress[i] = (byte)(ipAdressBytes[i] | (subnetMaskBytes[i] ^ 255));
                    }
                    txtBroad.Text = BintoIp(broadcastAddress).ToString();

                    byte[] networkAddress = new byte[ipAdressBytes.Length];
                    for (int i = 0; i < networkAddress.Length; i++)
                    {                                                                      // network IP bulur.
                        networkAddress[i] = (byte)(ipAdressBytes[i] & (subnetMaskBytes[i]));
                    }
                    txtNetwork.Text = BintoIp(networkAddress).ToString();

                }
            }
            catch (Exception en)       //ip adres cevirmede problem olursa hata verir.
            {                           
                MessageBox.Show(en.Message);                
            }

        }
        public static IPAddress BintoIp(byte[] bin)
        {
            return new IPAddress(bin);     // binary formattaki ip'yi ipAddress formatına çevirir.
        }
        public static string getSubnetAddressFromIPNetMask(string netMask)
        {   // prefix üzerinden subnet maskı bulan method.
            string subNetMask = string.Empty;
            int calSubNet = 0;
            double result = 0;
            if (!string.IsNullOrEmpty(netMask))
            {
                calSubNet = 32 - Convert.ToInt32(netMask);
                if (calSubNet >= 0 && calSubNet <= 8)
                {
                    for (int ipower = 0; ipower < calSubNet; ipower++)
                    {
                        result += Math.Pow(2, ipower);
                    }
                    double finalSubnet = 255 - result;
                    subNetMask = "255.255.255." + Convert.ToString(finalSubnet);
                }
                else if (calSubNet > 8 && calSubNet <= 16)
                {
                    int secOctet = 16 - calSubNet;

                    secOctet = 8 - secOctet;

                    for (int ipower = 0; ipower < secOctet; ipower++)
                    {
                        result += Math.Pow(2, ipower);
                    }
                    double finalSubnet = 255 - result;
                    subNetMask = "255.255." + Convert.ToString(finalSubnet) + ".0";
                }
                else if (calSubNet > 16 && calSubNet <= 24)
                {
                    int thirdOctet = 24 - calSubNet;

                    thirdOctet = 8 - thirdOctet;

                    for (int ipower = 0; ipower < thirdOctet; ipower++)
                    {
                        result += Math.Pow(2, ipower);
                    }
                    double finalSubnet = 255 - result;
                    subNetMask = "255." + Convert.ToString(finalSubnet) + ".0.0";
                }
                else if (calSubNet > 24 && calSubNet <= 32)
                {
                    int fourthOctet = 32 - calSubNet;

                    fourthOctet = 8 - fourthOctet;

                    for (int ipower = 0; ipower < fourthOctet; ipower++)
                    {
                        result += Math.Pow(2, ipower);
                    }
                    double finalSubnet = 255 - result;
                    subNetMask = Convert.ToString(finalSubnet) + ".0.0.0";
                }
            }
            return subNetMask;
        }

        private void TxtPrefix_TextChanged(object sender, EventArgs e)
        {   //1. kısımda girilen prefix değeri otomatik olarak subnet ve wild cardı yazdırır.
            txtSubnet.Text = getSubnetAddressFromIPNetMask(txtPrefix.Text);
            string wild = getWildCard(txtSubnet.Text);
            txtWildCart.Text = wild;
        }
        public string getWildCard(string subnet)
        {
            // subnet masktan wildcard'a dönüştürme.
            if (!String.IsNullOrEmpty(subnet))
            {
                byte[] subnetAddress = IPAddress.Parse(subnet).GetAddressBytes();
                int p1 = 255 - subnetAddress[0];
                int p2 = 255 - subnetAddress[1];
                int p3 = 255 - subnetAddress[2];
                int p4 = 255 - subnetAddress[3];
                string wildcart = p1 + "." + p2 + "." + p3 + "." + p4;
                return wildcart;
            }
            return null;
        }
        public string getSubFromWild(string wild)
        {
            //wildcard'dan subnet maska dönüştürme.
            if (!String.IsNullOrEmpty(wild))
            {
                byte[] wildAddress = IPAddress.Parse(wild).GetAddressBytes();
                int p1 = 255 - wildAddress[0];
                int p2 = 255 - wildAddress[1];
                int p3 = 255 - wildAddress[2];
                int p4 = 255 - wildAddress[3];
                string subnetMask = p1 + "." + p2 + "." + p3 + "." + p4;
                return subnetMask;
            }
            return null;

        }

        private void Txtsub_TextChanged(object sender, EventArgs e)
        {
            //subnet mask from wild cart
            txtWild.Text = getWildCard(txtsub.Text);
        }

        private void TxtWild2_TextChanged(object sender, EventArgs e)
        {
            //wild cart from subnet mask
            txtSub2.Text = getSubFromWild(txtWild2.Text);
        }

        private void BtnClearSub_Click(object sender, EventArgs e)
        {
            // 2.bölgede temizlik yapar.
            txtWild.Text = string.Empty;
            txtsub.Text = string.Empty;
            txtPrefix1.Text = string.Empty;
        }

        private void BtnClearWild_Click(object sender, EventArgs e)
        {
            txtSub2.Text = "";
            txtWild2.Text = "";
        }

        private void TxtPrefix1_TextChanged(object sender, EventArgs e)
        {
            txtsub.Text = getSubnetAddressFromIPNetMask(txtPrefix1.Text);
        }

        private void BtnClearMain_Click(object sender, EventArgs e)
        {
            txtIpAdd.Text = string.Empty;
            txtSubnet.Text = string.Empty;
            txtWildCart.Text = string.Empty; 
            txtBroad.Text = string.Empty;
            txtNetwork.Text = string.Empty;
            txtPrefix.Text = string.Empty;
        }
    }
}
