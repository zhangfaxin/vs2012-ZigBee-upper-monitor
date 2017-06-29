using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO.Ports;
namespace SerialCommunicate
{
    public partial class Form1 : Form
    {
        double history =0;
        double history1 = 0;
        double history2 = 0;
        double history3 = 0;
        double history4= 0;
        double history5 = 0;
        double history6 = 0;
        double show = 0;
        double show1 = 0;
        double show2 = 0;
        double show3 = 0;
        double show4 = 0;
        double show5 = 0;
        double show6 = 0;
        public Form1()
        {
            InitializeComponent();
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = comboBox1.Text;
                serialPort1.BaudRate = Convert.ToInt32(comboBox2.Text,10);//十进制数据转换
                serialPort1.Open();
                button1.Enabled = false;//打开串口按钮不可用
                button2.Enabled = true;//关闭串口
            }
            catch {
                MessageBox.Show("端口错误,请检查串口", "错误");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 20; i++)
            {
                comboBox1.Items.Add("COM" + i.ToString());
            }
            comboBox1.Text = "COM1";//串口号多额默认值
            comboBox2.Text = "4800";//波特率默认值
            
            /*****************非常重要************************/
            
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);//必须手动添加事件处理程序

        }
        
        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)//串口数据接收事件
        {
                int i, j;
                for (i = 1000; i > 0; i--)
                for (j = 110; j > 0; j--) ;    //100ms延时程序
                string str = serialPort1.ReadExisting();//字符串方式读
                textBox1.AppendText(str);//添加内容
                char data = str[0];
                if (data=='a')
                {
                    
                    label9.Text = str.Substring(1,2);
                }
                else if (data == 'b')
                {
                    string data1 = str;
                    label11.Text = str.Substring(1,2);
                    label13.Text =str.Substring(3);
                }
                else if (data == 'c')
                {
                    string data1 = str;
                    label23.Text = str.Substring(1, 2);
                    label22.Text = str.Substring(3);
                }
                else if (data == 'd')
                {
                    string data1 = str;
                    label26.Text = str.Substring(1, 2);
                    label27.Text = str.Substring(3);
                }
                else if (data == 'e')
                {

                    label31.Text = str.Substring(1, 2);
                }
                else if (data == 'f')
                {

                    label33.Text = str.Substring(1, 2);
                }
                else if (data == 'g')
                {

                    label36.Text = str.Substring(1, 2);
                }
                else if (data == 'h')
                {
                    int a= str[1]-'0';
                    int b = str[2]-'0';
                    int c = str[3]-'0';
                    
                    int d = a*100+b*10+c;
                    double f= d / 300.0;
                    if (f < history)
                    {
                        history = f;
                        show = show + 1;

                    }
                    else
                    {
                        history = f;
                    }
                    string read=(show+f).ToString("f3");

                    label38.Text = read;
                }
                else if (data == 'i')
                {
                    int a = str[1] - '0';
                    int b = str[2] - '0';
                    int c = str[3] - '0';

                    int d = a * 100 + b * 10 + c;
                    double f = d / 300.0;
                    if (f < history1)
                    {
                        history1 = f;
                        show1 = show1 + 1;

                    }
                    else
                    {
                        history1 = f;
                    }
                    string read = (show1 + f).ToString("f3");

                    label39.Text = read;
                }
                else if (data == 'j')
                {
                    int a = str[1] - '0';
                    int b = str[2] - '0';
                    int c = str[3] - '0';

                    int d = a * 100 + b * 10 + c;
                    double f = d / 300.0;
                    if (f < history2)
                    {
                        history2 = f;
                        show2 = show2 + 1;

                    }
                    else
                    {
                        history2 = f;
                    }
                    string read = (show2 + f).ToString("f3");

                    label44.Text = read;
                }
                else if (data == 'k')
                {
                    int a = str[1] - '0';
                    int b = str[2] - '0';
                    int c = str[3] - '0';

                    int d = a * 100 + b * 10 + c;
                    double f = d / 300.0;
                    if (f < history3)
                    {
                        history3 = f;
                        show3 = show3 + 1;

                    }
                    else
                    {
                        history3 = f;
                    }
                    string read = (show3 + f).ToString("f3");

                    label40.Text = read;
                }
                else if (data == 'l')
                {
                    int a = str[1] - '0';
                    int b = str[2] - '0';
                    int c = str[3] - '0';

                    int d = a * 100 + b * 10 + c;
                    double f = d / 300.0;
                    if (f < history4)
                    {
                        history4 = f;
                        show4 = show4 + 1;

                    }
                    else
                    {
                        history4 = f;
                    }
                    string read = (show4 + f).ToString("f3");

                    label41.Text = read;
                }
                else if (data == 'm')
                {
                    int a = str[1] - '0';
                    int b = str[2] - '0';
                    int c = str[3] - '0';

                    int d = a * 100 + b * 10 + c;
                    double f = d / 300.0;
                    if (f < history5)
                    {
                        history5 = f;
                        show5 = show5 + 1;

                    }
                    else
                    {
                        history5 = f;
                    }
                    string read = (show5 + f).ToString("f3");

                    label43.Text = read;
                }
                else if (data == 'n')
                {
                    int a = str[1] - '0';
                    int b = str[2] - '0';
                    int c = str[3] - '0';

                    int d = a * 100 + b * 10 + c;
                    double f = d / 300.0;
                    if (f < history6)
                    {
                        history6 = f;
                        show6 = show6 + 1;

                    }
                    else
                    {
                        history6 = f;
                    }
                    string read = (show6 + f).ToString("f3");

                    label42.Text = read;
                }

        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Close();//关闭串口
                button1.Enabled = true;//打开串口按钮可用
                button2.Enabled = false;//关闭串口按钮不可用
            }
            catch
            {

            }
        }

        private void SearchAndAddSerialToComboBox(SerialPort MyPort, ComboBox MyBox)
        {                                                               //将可用端口号添加到ComboBox
            string[] MyString = new string[20];                         //最多容纳20个，太多会影响调试效率
            string Buffer;                                              //缓存
            MyBox.Items.Clear();                                        //清空ComboBox内容
            for (int i = 1; i < 20; i++)                                //循环
            {
                try                                                     //核心原理是依靠try和catch完成遍历
                {
                    Buffer = "COM" + i.ToString();
                    MyPort.PortName = Buffer;
                    MyPort.Open();                                      //如果失败，后面的代码不会执行
                    MyString[i - 1] = Buffer;
                    MyBox.Items.Add(Buffer);                            //打开成功，添加至下俩列表
                    MyPort.Close();                                     //关闭
                }
                catch
                {

                }
            }
            MyBox.Text = MyString[0];                                   //初始化
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)//判断串口是否打开，如果打开执行下一步操作
            {
                        try
                        {
                            for (int i = 0; i < 3; i++)
                            {
                                serialPort1.WriteLine("00000");//写数据
                                for (int k = 1000; k > 0; k--)
                                    for (int j = 110; j > 0; j--) ; 
                            }
                        }
                        catch
                        {
                            MessageBox.Show("串口数据写入错误", "错误");//出错提示
                            serialPort1.Close();
                            button1.Enabled = true;//打开串口按钮可用
                            button2.Enabled = false;//关闭串口按钮不可用
                        }

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SearchAndAddSerialToComboBox(serialPort1,comboBox1);
              
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)//判断串口是否打开，如果打开执行下一步操作
            {
                try
                {
                    for (int i = 0; i < 3; i++)
                    {
                        serialPort1.WriteLine("00001");//写数据
                        for (int k = 1000; k > 0; k--)
                            for (int j = 110; j > 0; j--) ; 
                    }
                }
                catch
                {
                    MessageBox.Show("串口数据写入错误", "错误");//出错提示
                    serialPort1.Close();
                    button1.Enabled = true;//打开串口按钮可用
                    button2.Enabled = false;//关闭串口按钮不可用
                }

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)//判断串口是否打开，如果打开执行下一步操作
            {
                try
                {
                    for (int i = 0; i < 3; i++)
                    {
                        serialPort1.WriteLine("00010");//写数据
                        for (int k = 1000; k > 0; k--)
                            for (int j = 110; j > 0; j--) ; 
                    }
                }
                catch
                {
                    MessageBox.Show("串口数据写入错误", "错误");//出错提示
                    serialPort1.Close();
                    button1.Enabled = true;//打开串口按钮可用
                    button2.Enabled = false;//关闭串口按钮不可用
                }

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)//判断串口是否打开，如果打开执行下一步操作
            {
                try
                {
                    for (int i = 0; i < 3; i++)
                    {
                        serialPort1.WriteLine("00011");//写数据
                        for (int k = 1000; k > 0; k--)
                            for (int j = 110; j > 0; j--) ; 
                    }
                }
                catch
                {
                    MessageBox.Show("串口数据写入错误", "错误");//出错提示
                    serialPort1.Close();
                    button1.Enabled = true;//打开串口按钮可用
                    button2.Enabled = false;//关闭串口按钮不可用
                }

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)//判断串口是否打开，如果打开执行下一步操作
            {
                try
                {
                    for (int i = 0; i < 3; i++)
                    {
                        serialPort1.WriteLine("00100");//写数据
                        for (int k = 1000; k > 0; k--)
                            for (int j = 110; j > 0; j--) ; 
                    }
                }
                catch
                {
                    MessageBox.Show("串口数据写入错误", "错误");//出错提示
                    serialPort1.Close();
                    button1.Enabled = true;//打开串口按钮可用
                    button2.Enabled = false;//关闭串口按钮不可用
                }

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)//判断串口是否打开，如果打开执行下一步操作
            {
                try
                {
                    for (int i = 0; i < 3; i++)
                    {
                        serialPort1.WriteLine("00101");//写数据
                        for (int k = 1000; k > 0; k--)
                            for (int j = 110; j > 0; j--) ; 
                    }
                }
                catch
                {
                    MessageBox.Show("串口数据写入错误", "错误");//出错提示
                    serialPort1.Close();
                    button1.Enabled = true;//打开串口按钮可用
                    button2.Enabled = false;//关闭串口按钮不可用
                }

            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)//判断串口是否打开，如果打开执行下一步操作
            {
                try
                {
                    for (int i = 0; i < 3; i++)
                    {
                        serialPort1.WriteLine("00110");//写数据
                        for (int k = 1000; k > 0; k--)
                            for (int j = 110; j > 0; j--) ; 
                    }
                }
                catch
                {
                    MessageBox.Show("串口数据写入错误", "错误");//出错提示
                    serialPort1.Close();
                    button1.Enabled = true;//打开串口按钮可用
                    button2.Enabled = false;//关闭串口按钮不可用
                }

            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)//判断串口是否打开，如果打开执行下一步操作
            {
                try
                {
                    for (int i = 0; i < 2; i++)
                    {
                        serialPort1.WriteLine("00111");//写数据
                        for (int k = 1000; k > 0; k--)
                            for (int j = 110; j > 0; j--) ; 
                    }
                }
                catch
                {
                    MessageBox.Show("串口数据写入错误", "错误");//出错提示
                    serialPort1.Close();
                    button1.Enabled = true;//打开串口按钮可用
                    button2.Enabled = false;//关闭串口按钮不可用
                }

            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)//判断串口是否打开，如果打开执行下一步操作
            {
                try
                {
                    for (int i = 0; i < 2; i++)
                    {
                        serialPort1.WriteLine("01000");//写数据
                        for (int k = 1000; k > 0; k--)
                            for (int j = 110; j > 0; j--) ; 
                    }
                }
                catch
                {
                    MessageBox.Show("串口数据写入错误", "错误");//出错提示
                    serialPort1.Close();
                    button1.Enabled = true;//打开串口按钮可用
                    button2.Enabled = false;//关闭串口按钮不可用
                }

            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)//判断串口是否打开，如果打开执行下一步操作
            {
                try
                {
                    for (int i = 0; i < 2; i++)
                    {
                        serialPort1.WriteLine("01001");//写数据
                        for (int k = 1000; k > 0; k--)
                            for (int j = 110; j > 0; j--) ; 
                    }
                }
                catch
                {
                    MessageBox.Show("串口数据写入错误", "错误");//出错提示
                    serialPort1.Close();
                    button1.Enabled = true;//打开串口按钮可用
                    button2.Enabled = false;//关闭串口按钮不可用
                }

            }
        }



        private void button15_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)//判断串口是否打开，如果打开执行下一步操作
            {
                try
                {
                    for (int i = 0; i < 3; i++)
                    {
                        serialPort1.WriteLine("01010");//写数据
                        for (int k = 1000; k > 0; k--)
                            for (int j = 110; j > 0; j--) ; 
                    }
                }
                catch
                {
                    MessageBox.Show("串口数据写入错误", "错误");//出错提示
                    serialPort1.Close();
                    button1.Enabled = true;//打开串口按钮可用
                    button2.Enabled = false;//关闭串口按钮不可用
                }

            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)//判断串口是否打开，如果打开执行下一步操作
            {
                try
                {
                    for (int i = 0; i < 2; i++)
                    {
                        serialPort1.WriteLine("01011");//写数据
                        for (int k = 1000; k > 0; k--)
                            for (int j = 110; j > 0; j--) ; 
                    }
                }
                catch
                {
                    MessageBox.Show("串口数据写入错误", "错误");//出错提示
                    serialPort1.Close();
                    button1.Enabled = true;//打开串口按钮可用
                    button2.Enabled = false;//关闭串口按钮不可用
                }

            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)//判断串口是否打开，如果打开执行下一步操作
            {
                try
                {
                    for (int i = 0; i < 2; i++)
                    {
                        serialPort1.WriteLine("01100");//写数据
                        for (int k = 1000; k > 0; k--)
                            for (int j = 110; j > 0; j--) ; 
                    }
                }
                catch
                {
                    MessageBox.Show("串口数据写入错误", "错误");//出错提示
                    serialPort1.Close();
                    button1.Enabled = true;//打开串口按钮可用
                    button2.Enabled = false;//关闭串口按钮不可用
                }

            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)//判断串口是否打开，如果打开执行下一步操作
            {
                try
                {
                    for (int i = 0; i < 2; i++)
                    {
                        serialPort1.WriteLine("01101");//写数据
                        for (int k = 1000; k > 0; k--)
                            for (int j = 110; j > 0; j--) ; 
                    }
                }
                catch
                {
                    MessageBox.Show("串口数据写入错误", "错误");//出错提示
                    serialPort1.Close();
                    button1.Enabled = true;//打开串口按钮可用
                    button2.Enabled = false;//关闭串口按钮不可用
                }

            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)//判断串口是否打开，如果打开执行下一步操作
            {
                try
                {
                    for (int i = 0; i < 6; i++)
                    {
                        serialPort1.WriteLine("01110");//写数据
                        for (int k = 1000; k > 0; k--)
                            for (int j = 110; j > 0; j--) ; 
                    }
                }
                catch
                {
                    MessageBox.Show("串口数据写入错误", "错误");//出错提示
                    serialPort1.Close();
                    button1.Enabled = true;//打开串口按钮可用
                    button2.Enabled = false;//关闭串口按钮不可用
                }

            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)//判断串口是否打开，如果打开执行下一步操作
            {
                try
                {
                    for (int i = 0; i < 3; i++)
                    {
                        serialPort1.WriteLine("01111");//写数据

                        for (int k = 1000; k > 0; k--)
                            for (int j = 110; j > 0; j--) ; 
                    }
                }
                catch
                {
                    MessageBox.Show("串口数据写入错误", "错误");//出错提示
                    serialPort1.Close();
                    button1.Enabled = true;//打开串口按钮可用
                    button2.Enabled = false;//关闭串口按钮不可用
                }

            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)//判断串口是否打开，如果打开执行下一步操作
            {
                try
                {
                    for (int i = 0; i < 3; i++)
                    {
                        serialPort1.WriteLine("10000");//写数据
                        for (int k = 1000; k > 0; k--)
                            for (int j = 110; j > 0; j--) ; 
                    }
                }
                catch
                {
                    MessageBox.Show("串口数据写入错误", "错误");//出错提示
                    serialPort1.Close();
                    button1.Enabled = true;//打开串口按钮可用
                    button2.Enabled = false;//关闭串口按钮不可用
                }

            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)//判断串口是否打开，如果打开执行下一步操作
            {
                try
                {
                    for (int i = 0; i < 3; i++)
                    {
                        serialPort1.WriteLine("10001");//写数据
                        for (int k = 1000; k > 0; k--)
                            for (int j = 110; j > 0; j--) ; 
                    }
                }
                catch
                {
                    MessageBox.Show("串口数据写入错误", "错误");//出错提示
                    serialPort1.Close();
                    button1.Enabled = true;//打开串口按钮可用
                    button2.Enabled = false;//关闭串口按钮不可用
                }

            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)//判断串口是否打开，如果打开执行下一步操作
            {
                try
                {
                    for (int i = 0; i < 3; i++)
                    {
                        serialPort1.WriteLine("10010");//写数据
                        for (int k = 1000; k > 0; k--)
                            for (int j = 110; j > 0; j--) ; 
                    }
                }
                catch
                {
                    MessageBox.Show("串口数据写入错误", "错误");//出错提示
                    serialPort1.Close();
                    button1.Enabled = true;//打开串口按钮可用
                    button2.Enabled = false;//关闭串口按钮不可用
                }

            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)//判断串口是否打开，如果打开执行下一步操作
            {
                try
                {
                    for (int i = 0; i < 3; i++)
                    {
                        serialPort1.WriteLine("10011");//写数据
                        for (int k = 1000; k > 0; k--)
                            for (int j = 110; j > 0; j--) ; 
                    }
                }
                catch
                {
                    MessageBox.Show("串口数据写入错误", "错误");//出错提示
                    serialPort1.Close();
                    button1.Enabled = true;//打开串口按钮可用
                    button2.Enabled = false;//关闭串口按钮不可用
                }

            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)//判断串口是否打开，如果打开执行下一步操作
            {
                try
                {
                    for (int i = 0; i < 3; i++)
                    {
                        serialPort1.WriteLine("10100");//写数据
                        for (int k = 1000; k > 0; k--)
                            for (int j = 110; j > 0; j--) ; 
                    }
                }
                catch
                {
                    MessageBox.Show("串口数据写入错误", "错误");//出错提示
                    serialPort1.Close();
                    button1.Enabled = true;//打开串口按钮可用
                    button2.Enabled = false;//关闭串口按钮不可用
                }

            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)//判断串口是否打开，如果打开执行下一步操作
            {
                try
                {
                    for (int i = 0; i < 3; i++)
                    {
                        serialPort1.WriteLine("10101");//写数据
                        for (int k = 1000; k > 0; k--)
                            for (int j = 110; j > 0; j--) ; 
                    }
                }
                catch
                {
                    MessageBox.Show("串口数据写入错误", "错误");//出错提示
                    serialPort1.Close();
                    button1.Enabled = true;//打开串口按钮可用
                    button2.Enabled = false;//关闭串口按钮不可用
                }

            }
        }


    }
}
