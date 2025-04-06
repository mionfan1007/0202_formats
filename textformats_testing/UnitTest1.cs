using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using textformats;

namespace textformats_testing
{
    [TestClass]
    public class UnitTesting
    {
        
        [TestMethod]
        public void TClass_Read()
        {
            Module1<string> mod = new Module1<string>();
            string filename = "test.txt";

            List<string> lines = new List<string>();
            lines = mod.Read(filename);

            Assert.IsNotNull(lines);
        }

        [TestMethod]
        public void TClass_Write()
        {
            Module1<int> mod = new Module1<int>();
            string filename = "newtest1.txt";

            List<int> lines = new List<int>();
            lines.Add(0);
            lines.Add(1);
            mod.Write(filename, lines);
            List<int>lines1 = mod.Read(filename);
            Assert.IsNotNull(lines1);
        }
        [TestMethod]

        public void Formats_CSV()
        {
            Formats fm = new Formats();
            string filename = "test3.csv";
            List <string> lines = new List<string>();
            lines.Add("a1");
            lines.Add("b2");
            fm.CSVWrite(filename, lines);
            List <string> csvread = new List<string>();
            csvread = fm.CSVRead(filename);
            Assert.IsNotNull(csvread);
        }
        [TestMethod]

        public void Formats_XML()
        {
            Formats fm = new Formats();
            string filename = "test4.xml";
            List<string> lines = new List<string>();
            lines.Add("a1");
            lines.Add("b2");
            fm.XMLWrite(filename, lines);
            List<string> xmlread = new List<string>();
            xmlread = fm.XMLRead(filename);
            Assert.IsNotNull(xmlread);
        }


        [TestMethod]

        public void Formats_JSON()
        {
            Formats fm = new Formats();
            string filename = "test5.json";
            List<string> lines = new List<string>();
            lines.Add("a1");
            lines.Add("b2");
            fm.JSONWrite(filename, lines);
            List<string> jsonread = new List<string>();
            jsonread = fm.JSONRead(filename);
            Assert.IsNotNull(jsonread);
        }

        [TestMethod]

        public void Formats_YAML()
        {
            Formats fm = new Formats();
            string filename = "test6.yml";
            List<string> lines = new List<string>();
            lines.Add("a1");
            lines.Add("b2");
            fm.YAMLWrite(filename, lines);
            List<string> yamlread = new List<string>();
            yamlread = fm.YAMLRead(filename);
            Assert.IsNotNull(yamlread);
        }

        [TestMethod]

        public void Menu_File()
        {
            Menu1 menu1 = new Menu1();
            string filename = "test_menu.txt";
            List<string[]> lines = new List<string[]>
            {
                new [] {"a",  "b"}
            };
            menu1.WriteInoFile(filename, lines);
            List<string[]> fileread = new List<string[]>();
            fileread = menu1.ReadFromFile(filename);
            Assert.IsNotNull(fileread);
        }

        [TestMethod]
        public void Menu_Add()
        {
            Menu1 menu1 = new Menu1();
            List<string[]> lines = new List<string[]>
            {
                new [] {"a",  "b"}
            };
            string line = "test line";
            string[]item = line.Split(' ');
            menu1.AddItem(lines, item);
            int actual = 0;
            int expected = 2;

            foreach (string[] line1 in lines)
            {
                actual++;
            }

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void Menu_Remove()
        {
            Menu1 menu1 = new Menu1();
            List<string[]> lines = new List<string[]>
            {
                new [] {"1",  "line"}
            };
            string line = "1";
            string item = "1,line";
            menu1.RemoveItem(lines, line);
            CollectionAssert.DoesNotContain(lines, item);

        }

        [TestMethod]

        public void Menu_Sort()
        {
            Menu1 menu1 = new Menu1();
            List<string[]> lines = new List<string[]>
            {
                new [] {"3",  "line"},
                new [] {"2", "line"}
            };
            List<string[]>lines1 = menu1.Sort(lines, "1");
            CollectionAssert.AreNotEqual(lines, lines1);

        }

        [TestMethod]
        public void Menu_Search()
        {
            Menu1 menu1 = new Menu1();
            List<string[]> lines = new List<string[]>
            {
                new [] {"1",  "line"},
                new [] {"2", "line"}
            };
            string actual  = menu1.SearchItem("1", lines);
            string expected = "1,line";
            Assert.AreEqual(expected, actual);
        }

        





    }
}
