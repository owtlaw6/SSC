using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace ConsoleApplication1_dva
{
    class Program
    {
        static double[] returnTime(int size)
        {
            RSACryptoServiceProvider myrsa = new RSACryptoServiceProvider(1600);
            System.Diagnostics.Stopwatch swatch = new System.Diagnostics.Stopwatch();
            double[] results = new double[5] { 0, 0, 0, 0, 0 };
            int size1;
            int count = 100;
            swatch.Start();
            for (int i = 0; i < count; i++)
            {
                myrsa = new RSACryptoServiceProvider(size);
                size1 = myrsa.KeySize;
            }
            swatch.Stop();
            results[0] = (double)swatch.ElapsedMilliseconds / (double)count;
            Console.WriteLine("Generation time at " + (Convert.ToString(size)) + " bit ... " + results[0].ToString() + " ms");

            byte[] plain = new byte[20];
            byte[] ciphertext = myrsa.Encrypt(plain, true);
            swatch.Reset();
            swatch.Start();

            for (int i = 0; i < count; i++)
            {
                ciphertext = myrsa.Encrypt(plain, true);
            }
            swatch.Stop();
            results[1] = (double)swatch.ElapsedMilliseconds / (double)count;
            Console.WriteLine("Encryption time at " + (Convert.ToString(size)) + " bit ... " + results[1].ToString() + " ms");

            swatch.Reset();
            swatch.Start();
            for (int i = 0; i < count; i++)
            {
                plain = myrsa.Decrypt(ciphertext, true);
            }
            swatch.Stop();
            results[2] = (double)swatch.ElapsedMilliseconds / (double)count;
            Console.WriteLine("Decryption time at " + (Convert.ToString(size)) + " bit ... " + results[2].ToString() + " ms");
            //Console.ReadKey();

            swatch.Reset();
            swatch.Start();
            SHA256Managed myHash = new SHA256Managed();
            string some_text = "this is an important message";
            //sign the message
            byte[] signature;
            for (int i = 0; i < count - 1; i++)
            {
                signature = myrsa.SignData(System.Text.Encoding.ASCII.GetBytes(some_text), myHash);
            }
            signature = myrsa.SignData(System.Text.Encoding.ASCII.GetBytes(some_text), myHash);
            swatch.Stop();
            results[3] = (double)swatch.ElapsedMilliseconds / (double)count;
            Console.WriteLine("Signing time at " + (Convert.ToString(size)) + " bit ... " + results[3].ToString() + " ms");

            swatch.Reset();
            swatch.Start();
            //verified a signature on a given message
            bool verified;
            for (int i = 0; i < count - 1; i++)
            {
                verified = myrsa.VerifyData(System.Text.Encoding.ASCII.GetBytes(some_text), myHash, signature);
            }
            swatch.Stop();
            results[4] = (double)swatch.ElapsedMilliseconds / (double)count;
            Console.WriteLine("Verification time at " + (Convert.ToString(size)) + " bit ... " + results[4].ToString() + " ms");

            return results;
        }

        static void Main(string[] args)
        {
            int optiune = 0;
            double[] results;
       
            do
            {
                switch (optiune)
                {
                    case 1: {results = returnTime(1024); break;}
                    case 2: {results = returnTime(2048); break;}
                    case 3: {results = returnTime(3072); break;}
                    case 4: {results = returnTime(4096); break;}
                }
                Console.WriteLine("0. exit");
                Console.WriteLine("1. 1024 bits");
                Console.WriteLine("2. 2048 bits");
                Console.WriteLine("3. 3072 bits");
                Console.WriteLine("4. 4096 bits");
                optiune = Convert.ToInt16(Console.ReadLine());

            } while (optiune != 0) ;

        }
    }
}
