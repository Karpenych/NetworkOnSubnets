using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace NetworkOnSubnets
{
    internal static class Jija
    {
        static public string DecIntArrToStrOut(int[] decInt)  //   int[] { 0, 0, 0, 0 }    IN      string  0.0.0.0
        {
            string decString = "";

            foreach (var number in decInt) decString += number + ".";

            return decString[..^1];
        }

        static public int[] InputIPToDecIntArr(string input)   //  string  0.0.0.0       IN       int[] { 0, 0, 0, 0 }
        {
            var decStrArr = input.Split('.');
            var decIntArr = new int[4];

            for (int i = 0; i < 4; ++i) decIntArr[i] = Convert.ToInt32(decStrArr[i]);

            return decIntArr;
        }

        static public int[] InputMaskShortToDecIntArr(string input)       //  string  /0       IN       int[] { 0, 0, 0, 0 }
        {
            var decIntArr = new int[4];
            StringBuilder sb = new();

            var oneLength = int.Parse(input[1..]);
            for (int i = 0; i < oneLength; i++) sb.Append('1');

            var zeroLength = 32 - oneLength;  
            for (int i = 0; i < zeroLength; i++) sb.Append('0');

            var binStr = sb.ToString();
            var index = 0;

            for (int i = 0; i < 32; i += 8)
            {
                var tmp = binStr.Substring(i, 8);
                decIntArr[index] = Convert.ToInt32(tmp, 2);
                index++;
            }

            return decIntArr;
        }

        static public int[] FindBroadcast(int[] ip, int[] mask)     // find BROADCAST with ip and mask
        {
            var ipBinArrStr   = new string[4];
            var maskBinArrStr = new string[4];
            string ipBinStr = "", maskBinStr = "";
            int ipDec, notMaskDec, broadcastDec;
            var broadcastDecIntArr = new int[4];

            for (int i = 0; i < 4; ++i)
            {
                ipBinArrStr[i] = Convert.ToString(ip[i], 2).PadLeft(8, '0');
                ipBinStr += ipBinArrStr[i];

                maskBinArrStr[i] = Convert.ToString(mask[i], 2).PadLeft(8, '0');
                maskBinStr += maskBinArrStr[i];
            }

            StringBuilder notMaskSB = new();
            for (int i = 0; i < 32; ++i)
                if (maskBinStr[i] == '0') notMaskSB.Append('1');
                else notMaskSB.Append('0');
            
            ipDec   = Convert.ToInt32(ipBinStr,   2);
            notMaskDec = Convert.ToInt32(notMaskSB.ToString(), 2);
            broadcastDec = ipDec | notMaskDec;
            string broadcastBinStr = Convert.ToString(broadcastDec, 2).PadLeft(32, '0');

            var index = 0;
            for (int i = 0; i < 32; i += 8)
            {
                var tmp = broadcastBinStr.Substring(i, 8);
                broadcastDecIntArr[index] = Convert.ToInt32(tmp, 2);
                index++;
            }

            return broadcastDecIntArr;
        }

        static public int[] SubnetNetworkIP(int[] broadcast)      //   SUBNET'S IP address (broadcast + 1)
        {
            var broadcastBinArrStr = new string[4];
            string broadcastBinStr = "";
            int broadcastDec, ipSubnetDec;
            var ipSubnetDecIntArr = new int[4];

            for (int i = 0; i < 4; ++i)
            {
                broadcastBinArrStr[i] = Convert.ToString(broadcast[i], 2).PadLeft(8, '0');
                broadcastBinStr += broadcastBinArrStr[i];
            }

            broadcastDec = Convert.ToInt32(broadcastBinStr, 2);
            ipSubnetDec = broadcastDec + 1;
            string ipSubnetBinStr = Convert.ToString(ipSubnetDec, 2).PadLeft(32, '0');

            var index = 0;
            for (int i = 0; i < 32; i += 8)
            {
                var tmp = ipSubnetBinStr.Substring(i, 8);
                ipSubnetDecIntArr[index] = Convert.ToInt32(tmp, 2);
                index++;
            }

            return ipSubnetDecIntArr;
        }
        
        static public int AmountOfIP(int[] ipDecIntArr, int[] broadcastDecIntArr)   // AMOUNT of ALL available IPs
        {
            var ipBinArrStr   = new string[4];
            var broadcastBinArrStr = new string[4];
            var ipBinStr = "";
            var broadcastBinStr = "";

            for (int i = 0; i < 4; ++i)
            {
                ipBinArrStr[i] = Convert.ToString(ipDecIntArr[i], 2).PadLeft(8, '0');
                ipBinStr += ipBinArrStr[i];

                broadcastBinArrStr[i] = Convert.ToString(broadcastDecIntArr[i], 2).PadLeft(8, '0');
                broadcastBinStr += broadcastBinArrStr[i];
            }

            var ipDec = Convert.ToInt32(ipBinStr, 2);
            var broadcastDec = Convert.ToInt32(broadcastBinStr, 2);

            return broadcastDec - ipDec + 1;
        }

        static public int AmountOfComputers(int amountOfIP) => amountOfIP - 2;   // AMOUNT of COMPUTERS for this IPs
        
        static public bool isPowerOfTwo(int val)    // Check if value is power of 2
        {
            if (val == 2) return true;

            int tmp;
            do
            {
                tmp = val % 2;
                if (tmp == 0) val /= 2;
            }
            while (tmp != 1);

            if ((tmp == 1) && (val == 1)) return true;
            else return false;
        }

        static public int[] CreateMask(int zeroCount)    //  Create mask for subnet
        {
            var oneAmount = 32 - zeroCount;
            StringBuilder sb = new();

            for (int i = 0; i < oneAmount; i++) sb.Append('1');
            for (int i = 0; i < zeroCount; i++) sb.Append('0');

            var maskDecIntArr = new int[4];
            var maskBinStr = sb.ToString();

            var index = 0;
            for (int i = 0; i < 32; i += 8)
            {
                var tmp = maskBinStr.Substring(i, 8);
                maskDecIntArr[index] = Convert.ToInt32(tmp, 2);
                index++;
            }

            return maskDecIntArr;
        }
    }
}
