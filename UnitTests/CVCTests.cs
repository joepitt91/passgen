﻿using JoePitt.PassGen.Generators;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace UnitTests
{
    [TestClass]
    public class CVCTests
    {
        // 3 part CVC
        [TestMethod]
        public void CVC_3Part_1Pass()
        {
            CVCGenerator TestGenerator = new CVCGenerator();
            Console.WriteLine(TestGenerator.Next(3));
        }

        [TestMethod]
        public void CVC_3Part_10Pas()
        {
            List<string> Passwords = new List<string>();
            int i = 0;
            while (i < 10)
            {
                CVCGenerator TestGenerator = new CVCGenerator();
                Passwords.Add(TestGenerator.Next(3));
                Console.WriteLine(Passwords[i]);
                i++;
            }

            if (Passwords.GroupBy(n => n).Any(c => c.Count() > 1))
            {
                Assert.Fail("Duplicates found");
            }
        }

        [TestMethod]
        public void CVC_3Part_100Pass()
        {
            List<string> Passwords = new List<string>();
            int i = 0;
            while (i < 100)
            {
                CVCGenerator TestGenerator = new CVCGenerator();
                Passwords.Add(TestGenerator.Next(3));
                Console.WriteLine(Passwords[i]);
                i++;
            }

            if (Passwords.GroupBy(n => n).Any(c => c.Count() > 1))
            {
                Assert.Fail("Duplicates found");
            }
        }

        //10 part CVC
        [TestMethod]
        public void CVC_10Part_1Pass()
        {
            CVCGenerator TestGenerator = new CVCGenerator();
            Console.WriteLine(TestGenerator.Next(10));
        }

        [TestMethod]
        public void CVC_10Part_10Pass()
        {
            List<string> Passwords = new List<string>();
            int i = 0;
            while (i < 10)
            {
                CVCGenerator TestGenerator = new CVCGenerator();
                Passwords.Add(TestGenerator.Next(10));
                Console.WriteLine(Passwords[i]);
                i++;
            }

            if (Passwords.GroupBy(n => n).Any(c => c.Count() > 1))
            {
                Assert.Fail("Duplicates found");
            }
        }

        [TestMethod]
        public void CVC_10Part_100Pass()
        {
            List<string> Passwords = new List<string>();
            int i = 0;
            while (i < 100)
            {
                CVCGenerator TestGenerator = new CVCGenerator();
                Passwords.Add(TestGenerator.Next(10));
                Console.WriteLine(Passwords[i]);
                i++;
            }

            if (Passwords.GroupBy(n => n).Any(c => c.Count() > 1))
            {
                Assert.Fail("Duplicates found");
            }
        }
    }
}
