using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace NetworkOnSubnets
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btClear_Click(object sender, EventArgs e) { if (dataGridView1.Rows.Count > 0) dataGridView1.Rows.Clear(); }

        private void button1_Click(object sender, EventArgs e) { NetworkOnSubnetworks(); }

        private void NetworkOnSubnetworks()
        {
            int[] mainNetworkDecIntArr = Jija.InputIPToDecIntArr(tbIP_Network.Text);
            int[] mainMaskDecIntArr;

            if (tbMaskFull.Text != "") mainMaskDecIntArr = Jija.InputIPToDecIntArr(tbMaskFull.Text); 
            else mainMaskDecIntArr = Jija.InputMaskShortToDecIntArr(tbMaskShort.Text);

            int[] broadcastDecIntArr = Jija.FindBroadcast(mainNetworkDecIntArr, mainMaskDecIntArr);
            int allIPsAmount = Jija.AmountOfIP(mainNetworkDecIntArr, broadcastDecIntArr);
            int allComps = Jija.AmountOfComputers(allIPsAmount);

            dataGridView1.Rows.Add("Main network", Jija.DecIntArrToStrOut(mainNetworkDecIntArr), Jija.DecIntArrToStrOut(mainMaskDecIntArr), allIPsAmount, 
                                                  allComps, "from " + Jija.DecIntArrToStrOut(mainNetworkDecIntArr) + " to " + Jija.DecIntArrToStrOut(broadcastDecIntArr));

            dataGridView1.Rows[0].DefaultCellStyle.BackColor = Color.Aqua;

            if (Jija.isPowerOfTwo(int.Parse(tbSubnets.Text))) DoIfSubnetIsPowerOfTwo(mainNetworkDecIntArr, allIPsAmount);
            else DoIfSubnetIsNotPowerOfTwo(mainNetworkDecIntArr, allIPsAmount);
        }

        private void DoIfSubnetIsPowerOfTwo(int[] ipDecIntArr, int ipAmount)
        {
            var oneIPsAmount = ipAmount / int.Parse(tbSubnets.Text);

            if (oneIPsAmount >= int.Parse(tbComputers.Text) + 2)
            {
                GetInfo(out int compsAmount, out int[] mask, out int[] broadcastDecIntArr, oneIPsAmount, ipDecIntArr);

                dataGridView1.Rows.Add("Subnet1", Jija.DecIntArrToStrOut(ipDecIntArr), Jija.DecIntArrToStrOut(mask), oneIPsAmount, compsAmount,
                                                                            "from " + Jija.DecIntArrToStrOut(ipDecIntArr) + " to " + Jija.DecIntArrToStrOut(broadcastDecIntArr));

                InfoOut(1, compsAmount, mask, broadcastDecIntArr, oneIPsAmount);
            }
            else
            {
                var firstIPsAmount = oneIPsAmount;

                while (firstIPsAmount < int.Parse(tbComputers.Text) + 2) firstIPsAmount *= 2;

                GetInfo(out int firstCompAmount, out int[] firstMask, out int[] firstBroadcastDecIntArr, firstIPsAmount, ipDecIntArr);

                dataGridView1.Rows.Add("Subnet1", Jija.DecIntArrToStrOut(ipDecIntArr), Jija.DecIntArrToStrOut(firstMask), firstIPsAmount, firstCompAmount,
                                                                        "from " + Jija.DecIntArrToStrOut(ipDecIntArr) + " to " + Jija.DecIntArrToStrOut(firstBroadcastDecIntArr));

                var lastIpsAmount = ipAmount - firstIPsAmount;
                var lastOneIpAmount = lastIpsAmount / int.Parse(tbSubnets.Text);
                var secondIPsAmount = lastOneIpAmount * 2;
                var secondSubnetIP = Jija.SubnetNetworkIP(firstBroadcastDecIntArr);

                GetInfo(out int secondCompAmount, out int[] secondMask, out int[] secondBroadcastDecIntArr, secondIPsAmount, secondSubnetIP);

                dataGridView1.Rows.Add("Subnet2", Jija.DecIntArrToStrOut(secondSubnetIP), Jija.DecIntArrToStrOut(secondMask), secondIPsAmount, secondCompAmount,
                                                                        "from " + Jija.DecIntArrToStrOut(secondSubnetIP) + " to " + Jija.DecIntArrToStrOut(secondBroadcastDecIntArr));

                var compsAmount = Jija.AmountOfComputers(lastOneIpAmount);
                int zeroCount = (int)Math.Log2(lastOneIpAmount);
                var mask = Jija.CreateMask(zeroCount);
                var broadcastDecIntArr = secondBroadcastDecIntArr;

                InfoOut(2, compsAmount, mask, broadcastDecIntArr, lastOneIpAmount);
            }
        }

        private void DoIfSubnetIsNotPowerOfTwo(int[] ipDecIntArr, int ipAmount)
        {
            var devideBy = 2;
            var subnetsAmount = int.Parse(tbSubnets.Text);

            while (true)
            {
                if (devideBy < subnetsAmount) devideBy *= 2;
                else break;
            }

            var multiplyBy = devideBy - subnetsAmount + 1;
            var oneIPsAmount = ipAmount / devideBy;
            var firstIPsAmount = oneIPsAmount * multiplyBy;

            if (firstIPsAmount >= int.Parse(tbComputers.Text) + 2)
            {
                GetInfo(out int firstCompAmount, out int[] firstMask, out int[] firstBroadcastDecIntArr, firstIPsAmount, ipDecIntArr);

                dataGridView1.Rows.Add("Subnet1", Jija.DecIntArrToStrOut(ipDecIntArr), Jija.DecIntArrToStrOut(firstMask), firstIPsAmount, firstCompAmount,
                                                                        "from " + Jija.DecIntArrToStrOut(ipDecIntArr) + " to " + Jija.DecIntArrToStrOut(firstBroadcastDecIntArr));

                var compsAmount = Jija.AmountOfComputers(oneIPsAmount);
                int zeroCount = (int)Math.Log2(oneIPsAmount);
                var mask = Jija.CreateMask(zeroCount);
                var broadcastDecIntArr = firstBroadcastDecIntArr;

                InfoOut(1, compsAmount, mask, broadcastDecIntArr, oneIPsAmount);
            }
            else
            {

                while (firstIPsAmount < int.Parse(tbComputers.Text) + 2) firstIPsAmount *= 2;

                GetInfo(out int firstCompAmount, out int[] firstMask, out int[] firstBroadcastDecIntArr, firstIPsAmount, ipDecIntArr);

                dataGridView1.Rows.Add("Subnet1", Jija.DecIntArrToStrOut(ipDecIntArr), Jija.DecIntArrToStrOut(firstMask), firstIPsAmount, firstCompAmount,
                                                                        "from " + Jija.DecIntArrToStrOut(ipDecIntArr) + " to " + Jija.DecIntArrToStrOut(firstBroadcastDecIntArr));

                if (!Jija.isPowerOfTwo(subnetsAmount - 1))
                {
                    var lastOneIpsAmount = (ipAmount - firstIPsAmount) / devideBy;
                    var newMiltiplyBy = devideBy - subnetsAmount + 2;
                    var secondIPsAmount = lastOneIpsAmount * newMiltiplyBy;
                    var secondSubnetIP = Jija.SubnetNetworkIP(firstBroadcastDecIntArr);

                    GetInfo(out int secondCompAmount, out int[] secondMask, out int[] secondBroadcastDecIntArr, secondIPsAmount, secondSubnetIP);

                    dataGridView1.Rows.Add("Subnet2", Jija.DecIntArrToStrOut(secondSubnetIP), Jija.DecIntArrToStrOut(secondMask), secondIPsAmount, secondCompAmount,
                                                                            "from " + Jija.DecIntArrToStrOut(secondSubnetIP) + " to " + Jija.DecIntArrToStrOut(secondBroadcastDecIntArr));

                    var compsAmount = Jija.AmountOfComputers(lastOneIpsAmount);
                    int zeroCount = (int)Math.Log2(lastOneIpsAmount);
                    var mask = Jija.CreateMask(zeroCount);
                    var broadcastDecIntArr = secondBroadcastDecIntArr;

                    InfoOut(2, compsAmount, mask, broadcastDecIntArr, lastOneIpsAmount);
                }
                else
                {
                    devideBy /= 2;
                    var lastOneIpsAmount = (ipAmount - firstIPsAmount) / devideBy;

                    var compsAmount = Jija.AmountOfComputers(lastOneIpsAmount);
                    int zeroCount = (int)Math.Log2(lastOneIpsAmount);
                    var mask = Jija.CreateMask(zeroCount);
                    var broadcastDecIntArr = firstBroadcastDecIntArr;

                    InfoOut(2, compsAmount, mask, broadcastDecIntArr, lastOneIpsAmount);
                }
                
            }
        }

        private void GetInfo(out int compsAmount, out int[] mask, out int[] broadcast, int oneIPsAmount, int[] ip)
        {
            compsAmount = Jija.AmountOfComputers(oneIPsAmount);
            var zeroCount = (int)Math.Log2(oneIPsAmount);
            mask = Jija.CreateMask(zeroCount);
            broadcast = Jija.FindBroadcast(ip, mask);
        }

        private void InfoOut(int rowsAlreadyExist, int compsAmount, int[] mask, int[] broadcastDecIntArr, int oneIpAmount)
        {
            for (int i = 0; i < int.Parse(tbSubnets.Text) - rowsAlreadyExist; i++)
            {
                var subnetIP = Jija.SubnetNetworkIP(broadcastDecIntArr);
                broadcastDecIntArr = Jija.FindBroadcast(subnetIP, mask);
                int num = i + 3;
                dataGridView1.Rows.Add("Subnet" + num, Jija.DecIntArrToStrOut(subnetIP), Jija.DecIntArrToStrOut(mask), oneIpAmount, compsAmount,
                                                                "from " + Jija.DecIntArrToStrOut(subnetIP) + " to " + Jija.DecIntArrToStrOut(broadcastDecIntArr));
            }
        }
    }
    
}