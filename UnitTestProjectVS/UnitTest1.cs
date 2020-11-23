using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task;

namespace UnitTestProjectVS
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add1_Task()
        {
            Task.Tasks tasks = new Tasks();

            Task.TaskT task = new Task.TaskT(1, "Task1", "Desc", new DateTime(2020, 11, 19), new DateTime(2020, 11, 20), State.Open);

            tasks.AddTask(task);

            Assert.AreEqual(1, tasks.SelectAll().Count);

        }

        [TestMethod]
        public void Edit1_Task()
        {
            Task.TaskT task = new TaskT();

            Task.Tasks tasks = new Tasks();
            tasks.AddTask(new TaskT(1,"Task2","dawd", new DateTime(2020, 11, 19), new DateTime(2020, 11, 20), State.Open));

            task = tasks.taskList.Where(x => x.Id == 1).FirstOrDefault();

            task.Title = "Hello";

            Assert.AreEqual("Hello", tasks.taskList.Where(x => x.Id == 1).FirstOrDefault().Title);



        }
        [TestMethod]
        public void Remove1_Task()
        {
            Task.Tasks tasks = new Tasks();

            Task.TaskT task = new Task.TaskT(1, "Task1", "Desc", new DateTime(2020, 11, 19), new DateTime(2020, 11, 20), State.Open);

            tasks.RemoveTask(task);

            Assert.AreEqual(0, tasks.SelectAll().Count);


        }
       
    }
}
