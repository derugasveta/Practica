using System.Text;


var path = @"..\..\..\..\txt1.txt";

var path2 = @"..\..\..\..\txt2.txt";

var path3 = @"..\..\..\..\txt3.txt";
string[] s = File.ReadAllLines(path);
using (StreamWriter sw = new StreamWriter(path2))
using (StreamWriter sw2 = new StreamWriter(path3))
{
    for (int i = 0; i < s.Length; i++)
    {
        if (i % 2 == 0)
        {
            {
                sw.WriteLine(s[i]);
            }

        }
        else
        {
            {
                sw2.WriteLine(s[i]);
            }
        }

    }
}