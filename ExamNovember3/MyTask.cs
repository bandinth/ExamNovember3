using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task;

namespace ExamNovember3
{
    [TestFixture]
    public class MyTask
    {
        [Test]
        public void Add1_Task()
        {
            Task.Tasks tasks = new Tasks();

            Task.Task task=new Task.Task(1,"Task1","Desc",new DateTime(2020, 11, 19), new DateTime(2020, 11, 20), State.Open);

            tasks.AddTask(task);

            Assert.AreEqual(1, tasks.SelectAll().Count);

        }

        [Test]
        public void Remove1_Task()
        {
            Task.Tasks tasks = new Tasks();

            


        }

    }
}
