using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task;

namespace UnitTestProjectVS
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add1_Task(Task.Task task)
        {
            Task.Tasks tasks = new Tasks();

             task = new Task.Task(1, "Task1", "Desc", new DateTime(2020, 11, 19), new DateTime(2020, 11, 20), State.Open);

            tasks.AddTask(task);

            Assert.AreEqual(1, tasks.SelectAll().Count);

        }

        [TestMethod]
        public void Remove1_Task()
        {
            Task.Tasks tasks = new Tasks();




        }
    }
}
