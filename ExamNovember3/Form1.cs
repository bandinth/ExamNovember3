using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnitTestProjectVS;
using Task;
using System.Xml.Serialization;
using System.IO;

namespace ExamNovember3
{
   
    public partial class Form1 : Form
    {
        

       

        public delegate void MyDelegate(object data);

        public Form1()
        {
            InitializeComponent();
            
            Task.Tasks tasks = DesirializeXML();
            foreach (Task.TaskT item in tasks.taskList)
            {
                listBox1.Items.Add(item);
            }
        }
        public void Add(TaskT task)
        {

        }
        public Task.Tasks DesirializeXML()
        {
            XmlSerializer xml = new XmlSerializer(typeof(Task.Tasks));
            using (FileStream fs = new FileStream("Tasks.xml", FileMode.OpenOrCreate))
            {
                Task.Tasks tasks=(Task.Tasks)xml.Deserialize(fs);
                return tasks;
            }
        }
        public void SerializeXMl(Task.Tasks tasks)
        {
            XmlSerializer xml = new XmlSerializer(typeof(Task.Tasks));
            using (FileStream fs = new FileStream("Tasks.xml", FileMode.OpenOrCreate))
            {
                xml.Serialize(fs, tasks);
            }
            
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {

           
            Task.Tasks tasks = new Tasks();
            tasks.taskList = new List<TaskT>();
            tasks.AddTask(new TaskT(Convert.ToInt32(textBox1.Text),textBox2.Text,textBox3.Text,new DateTime(Convert.ToInt32(textBox4.Text),Convert.ToInt32(textBox5.Text),Convert.ToInt32(textBox6.Text)),
                new DateTime(Convert.ToInt32(textBox7.Text), Convert.ToInt32(textBox8.Text), Convert.ToInt32(textBox9.Text)),State.Open));
            
            foreach (var item in tasks.taskList)
            {

                listBox1.Items.Add(item);

            }
            SerializeXMl(tasks);

        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            Task.Tasks tasks = new Tasks();
            
            foreach(var item in tasks.taskList)
            {
                
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
           
            
            Task.Tasks tasks = new Tasks();
            tasks.taskList.Remove(new TaskT(Convert.ToInt32(textBox1.Text), textBox2.Text, textBox3.Text, new DateTime(Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text)),
                new DateTime(Convert.ToInt32(textBox7.Text), Convert.ToInt32(textBox8.Text), Convert.ToInt32(textBox9.Text)), State.Open));
            foreach(var item in tasks.taskList)
            {
                listBox1.Items.Remove(item);
            }
        }

        
    }
}
