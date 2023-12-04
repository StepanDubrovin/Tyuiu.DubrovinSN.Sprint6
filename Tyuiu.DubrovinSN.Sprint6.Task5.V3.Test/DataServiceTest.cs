using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DubrovinSN.Sprint6.Task5.V3.Lib;
using System.IO;

namespace Tyuiu.DubrovinSN.Sprint6.Task5.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckFile()
        {
            DataService ds = new DataService();
            string path = @"C:\Task5\InPutFileTask5V3.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);
        }
    }
}
