using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args) //static = 메무리에 항상 거주하는 친구 - 프로그램 실행시 즉시 실행
        {
            Person A = new Person();
            A.age = 10;
            A.name = "철";

            Person B = new Person();
            B.age = 12;
            B.name = "영";

            A.Say("아 저는 이제 10살이에요", B);
            B.Say("저는 12살 입니다.", A);
        }
    }
    class Math
    {
        public const float PI = 3.14f; //const=값을 바꿀 수가 없다(치환개념) , static=값을 바꿀 수 있다.
    }

    class Person
    {
        public static int AverageLifeTime = 90;

        //생성된 날짜 , readOnly로 변경불가 오직 읽기만 가능
        public readonly DateTime date = DateTime.Now; 
 
        public int age;
        public string name;

        public void Say(string something)
        {
            //데이터를 문자열로 표시하는 방법
            //1. string + string = string -> worst case 
            Console.WriteLine(name + " : " + something);
            //2. string.Format을 이용하는 방법
            Console.WriteLine(string.Format("{0} : {1}", name, something));
            //3. 가장 좋은 방법
            Console.WriteLine($"{name}: {something}");

            Console.WriteLine($"{name}({age}) : {something}");
        }
        public void Say(string something, Person other)
        {
            Console.WriteLine($"{name}({age}) : {other} ");
        }
    }
}
