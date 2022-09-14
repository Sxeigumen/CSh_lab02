using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSh_lab02
{
    class Program
    {   
        public class Pupil
        {
            public virtual void Study(){}

            public virtual void Read(){}

            public virtual void Write(){}

            public virtual void Relax(){}
        }

        public class ExcelentPupil : Pupil
        {
            public override void Study()
            {
                Console.WriteLine("This pupil can learn language and study excelent");
            }

            public override void Read()
            {
                Console.WriteLine("This pupil can read books and texts excelent");
            }

            public override void Write()
            {
                Console.WriteLine("This pupil can write texts, dictation and essey excelent");
            }

            public override void Relax()
            {
                Console.WriteLine("This pupil can chill and relax excelent");
            }
        }

        public class GoodPupil : Pupil
        {
            public override void Study()
            {
                Console.WriteLine("This pupil can learn language and study very well");
            }

            public override void Read()
            {
                Console.WriteLine("This pupil can read books and texts well");
            }

            public override void Write()
            {
                Console.WriteLine("This pupil can write texts, dictation and essey very well");
            }

            public override void Relax()
            {
                Console.WriteLine("This pupil can chill and relax very well");
            }
        }

        public class BadPupil : Pupil
        {
            public override void Study()
            {
                Console.WriteLine("This pupil can learn language and study very bad");
            }

            public override void Read()
            {
                Console.WriteLine("This pupil can read books and texts very bad");
            }

            public override void Write()
            {
                Console.WriteLine("This pupil can write texts, dictation and essey very very bad");
            }

            public override void Relax()
            {
                Console.WriteLine("This pupil can chill and relax very very bad");
            }
        }

        public class ClassRoom
        {
            private Pupil[] pupils = new Pupil[4];

            public ClassRoom(params Pupil[] SchoolClass)
            {
                for (int i = 0; i < SchoolClass.Length; ++i)
                {
                    if (SchoolClass[i] != null)
                    {
                        pupils[i] = SchoolClass[i];
                    }
                    else
                    {
                        break;
                    }
                }
            }

            public void PrintClassInfo()
            {
                for (int i = 0; i < pupils.Length; ++i)
                {
                    if (pupils[i] != null)
                    {
                        Console.WriteLine($"Pupil #{i + 1}");
                        pupils[i].Study();
                        pupils[i].Write();
                        pupils[i].Read();
                        pupils[i].Relax();
                    }
                    else
                    {
                        break;
                    }
                    Console.WriteLine("\n\n");
                }
                Console.WriteLine("######################################");
            }

        }
        static void Main(string[] args)
        {
            ExcelentPupil EPupil1 = new ExcelentPupil();
            ExcelentPupil EPupil2 = new ExcelentPupil();

            GoodPupil goodPupil1 = new GoodPupil();
            GoodPupil goodPupil2 = new GoodPupil();

            BadPupil badPupil1 = new BadPupil();
            BadPupil badPupil2 = new BadPupil();

            Pupil[] pupils1 = new Pupil[4] {EPupil1, EPupil2, goodPupil1, badPupil1};

            Pupil[] pupils2 = new Pupil[4] { badPupil2, goodPupil2, goodPupil1, badPupil1 };


            ClassRoom schoolClass1 = new ClassRoom(pupils1);
            schoolClass1.PrintClassInfo();

            ClassRoom schoolClass2 = new ClassRoom(EPupil1, EPupil2, goodPupil1);
            schoolClass2.PrintClassInfo();

            ClassRoom schoolClass3 = new ClassRoom(EPupil1, EPupil2);
            schoolClass3.PrintClassInfo();


        }
    }
}
