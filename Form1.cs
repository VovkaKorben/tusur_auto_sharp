using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

using System.IO;
using System.Diagnostics;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = 0;
                foreach (string line in System.IO.File.ReadLines(@"f:\tusur2\map1.txt"))
            {
                System.Console.WriteLine(line);
                count++;
            }

/*
            with codecs.open('map2.txt', encoding = 'utf-8') as f:
            for line in f:
                line = line.strip()

                # print ("#{} {}".format(count,line))
                a = line.split("\t")

                # street name
                sql = insert[0].format(count, a[0])
                cur.execute(sql)
                con.commit()

                # coords
                pt = 0
                for cc in range(1, len(a)):
                    coords = a[cc].split(",")
                    sql = insert[1].format(count, pt, coords[0], coords[1])
                    cur.execute(sql)


                    pt += 1
                count += 1
        con.commit()
        f.close()

        # создаем ключи
                    for sql in closeup:
            cur.execute(sql)
        con.commit()
        del pt, a, cc, sql, count, line, coords, init, closeup, insert, f
        print('-------------------------------------------------')
        print('База загружена из текстового файла')
*/
        }
    }
}
